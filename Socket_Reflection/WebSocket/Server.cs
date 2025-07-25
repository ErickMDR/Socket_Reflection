using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using Socket_Reflection.Entidades;
using Newtonsoft.Json;
using Socket_Reflection.WebSocket;

namespace Socket_Reflection.WebSocket
{
    public class Server
    {
        public event Action<bool> EstadoServidorCambiado;

        private TcpListener _servidor;
        private bool _encendido;
        private Thread _hiloServidor;

        public void Iniciar(int puerto = 1024)
        {
            _servidor = new TcpListener(IPAddress.Any, puerto);
            _servidor.Start();
            _encendido = true;
            EstadoServidorCambiado?.Invoke(true);

            _hiloServidor = new Thread(() =>
            {
                while (_encendido)
                {
                    try
                    {
                        var cliente = _servidor.AcceptTcpClient();
                        ProcesarCliente(cliente);
                    }
                    catch (SocketException ex) when (!_encendido)
                    {
                        Console.WriteLine("Servidor detenido correctamente");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al aceptar cliente: {ex.Message}");
                    }
                }
            });

            _hiloServidor.IsBackground = true;
            _hiloServidor.Start();
        }

        public void Detener()
        {
            _encendido = false;
            _servidor?.Stop();
            _hiloServidor?.Join(500);

            EstadoServidorCambiado?.Invoke(false);
        }

        private void ProcesarCliente(TcpClient cliente)
        {
            try
            {
                using (var stream = cliente.GetStream())
                {
                    // Leer solicitud
                    var buffer = new byte[4096];
                    var bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                    var solicitudJson = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                    var solicitud = JsonConvert.DeserializeObject<Solicitud>(solicitudJson);
                    var resultado = EjecutarAccion(solicitud);

                    // Enviar respuesta
                    var respuestaJson = JsonConvert.SerializeObject(resultado);
                    var respuestaBytes = Encoding.UTF8.GetBytes(respuestaJson);
                    stream.Write(respuestaBytes, 0, respuestaBytes.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar cliente: {ex.Message}");
            }
        }

        private Resultado EjecutarAccion(Solicitud solicitud)
        {
            try
            {
                // Usamos reflexión para encontrar la clase y método adecuados
                var nombreClase = $"Acciones{solicitud.Tabla}";
                var tipoClase = Type.GetType($"Socket_Reflection.Clases.{nombreClase}");

                if (tipoClase == null)
                    throw new Exception($"Clase no encontrada: {nombreClase}");

                // Creamos una instancia de la clase
                var instancia = Activator.CreateInstance(tipoClase);

                // Obtenemos el método a ejecutar
                var metodo = tipoClase.GetMethod(solicitud.Accion);

                if (metodo == null)
                    throw new Exception($"Método no encontrado: {solicitud.Accion}");

                // Deserializamos los parámetros
                var parametrosMetodo = metodo.GetParameters();
                object[] parametros;

                if (parametrosMetodo.Length > 0)
                {
                    var tipoParametro = parametrosMetodo[0].ParameterType;
                    var parametro = SerializadorEntidades.Deserializar(solicitud.ParametrosJson);
                    parametros = new[] { Convert.ChangeType(parametro, tipoParametro) };
                }
                else
                {
                    parametros = Array.Empty<object>();
                }

                // Invocamos el método
                var resultado = metodo.Invoke(instancia, parametros);

                // Preparamos la respuesta
                return new Resultado
                {
                    Exitoso = true,
                    DatosJson = resultado != null ? SerializadorEntidades.Serializar(resultado) : null,
                    Mensaje = "Acción ejecutada correctamente",
                    DetalleEjecucion = new DetalleEjecucion
                    {
                        Clase = nombreClase,
                        Metodo = solicitud.Accion,
                        ParametrosJson = parametros.Select(p => p?.ToString()).ToArray(),
                        TiposParametros = parametros.Select(p => p?.GetType().Name).ToArray()
                    }
                };
            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    Exitoso = false,
                    Mensaje = ex.InnerException?.Message ?? ex.Message
                };
            }
        }
    }
}