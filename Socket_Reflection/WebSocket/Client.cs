using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Socket_Reflection.WebSocket;

namespace Socket_Reflection.WebSocket
{
    public class Client
    {
        private string _servidor;
        private int _puerto;
        private bool _configurado = false;

        // Propiedades públicas para acceso externo
        public string Host => _servidor;
        public int Port => _puerto;
        public bool Configurado => _configurado;

        public Client()
        {
            // Valores por defecto
            _servidor = "localhost";
            _puerto = 1024;
        }

        /// <summary>
        /// Configura el cliente desde un archivo JSON
        /// </summary>
        /// <param name="jsonPath">Ruta del archivo de configuración</param>
        public void ConfigurarDesdeJson(string jsonPath)
        {
            try
            {
                if (!File.Exists(jsonPath))
                {
                    throw new FileNotFoundException("Archivo de configuración no encontrado", jsonPath);
                }

                var json = File.ReadAllText(jsonPath);
                var config = JsonConvert.DeserializeObject<ConfiguracionCliente>(json);

                if (config == null || string.IsNullOrEmpty(config.Libreria))
                {
                    throw new Exception("Configuración inválida o vacía");
                }

                ParsearConfiguracion(config.Libreria);
                _configurado = true;
            }
            catch (Exception ex)
            {
                _configurado = false;
                throw new Exception($"Error al cargar configuración: {ex.Message}");
            }
        }

        private void ParsearConfiguracion(string configString)
        {
            var partes = configString.Split(';');
            foreach (var parte in partes)
            {
                if (parte.Trim().StartsWith("Host=", StringComparison.OrdinalIgnoreCase))
                {
                    _servidor = parte.Substring(5).Trim();
                }
                else if (parte.Trim().StartsWith("Port=", StringComparison.OrdinalIgnoreCase))
                {
                    if (int.TryParse(parte.Substring(5).Trim(), out int port))
                    {
                        _puerto = port;
                    }
                }
            }
        }

        public Resultado EnviarSolicitud<T>(string tabla, string accion, T parametro)
        {
            if (!_configurado)
            {
                return new Resultado
                {
                    Exitoso = false,
                    Mensaje = "Cliente no configurado. Primero cargue la librería."
                };
            }

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

                    // Enviar solicitud
                    var solicitudJson = JsonConvert.SerializeObject(solicitud);
                    var bytes = Encoding.UTF8.GetBytes(solicitudJson);
                    stream.Write(bytes, 0, bytes.Length);

                    // Recibir respuesta
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

    // Clase para deserialización de la configuración
    public class ConfiguracionCliente
    {
        public string Libreria { get; set; }
    }
}