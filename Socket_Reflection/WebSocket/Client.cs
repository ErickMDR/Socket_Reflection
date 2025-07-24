using System;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Socket_Reflection.Entidades;
using Socket_Reflection.WebSocket;

namespace Socket_Reflection.WebSocket
{
    public class Client
    {
        private readonly string _servidor;
        private readonly int _puerto;

        public Client (string servidor = "localhost", int puerto = 1024)
        {
            _servidor = servidor;
            _puerto = puerto;
        }

        public Resultado EnviarSolicitud<T>(string tabla, string accion, T parametro)
        {
            try
            {
                using (var cliente = new TcpClient(_servidor, _puerto))
                using (var stream = cliente.GetStream())
                {
                    var solicitud = new Solicitud
                    {
                        Tabla = tabla,
                        Accion = accion,
                        ParametrosJson = SerializadorEntidades.Serializar(parametro)
                    };

                    var solicitudJson = JsonConvert.SerializeObject(solicitud);
                    var bytes = Encoding.UTF8.GetBytes(solicitudJson);
                    stream.Write(bytes, 0, bytes.Length);

                    var buffer = new byte[4096];
                    var bytesLeidos = stream.Read(buffer, 0, buffer.Length);
                    var respuestaJson = Encoding.UTF8.GetString(buffer, 0, bytesLeidos);

                    return JsonConvert.DeserializeObject<Resultado>(respuestaJson);
                }
            }
            catch (Exception ex)
            {
                return new Resultado
                {
                    Exitoso = false,
                    Mensaje = ex.Message
                };
            }
        }

        public Resultado EnviarSolicitud(string tabla, string accion)
        {
            return EnviarSolicitud<object>(tabla, accion, null);
        }
    }
}