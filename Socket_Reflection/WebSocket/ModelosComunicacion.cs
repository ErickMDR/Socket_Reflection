using Newtonsoft.Json;
using Socket_Reflection.Entidades;
using System;

namespace Socket_Reflection.WebSocket
{
    public class Solicitud
    {
        public string Tabla { get; set; } 
        public string Accion { get; set; } 
        public string ParametrosJson { get; set; } 
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string DatosJson { get; set; }
        public string Mensaje { get; set; }
        public DetalleEjecucion DetalleEjecucion { get; set; }
    }

    public class DetalleEjecucion
    {
        public string Clase { get; set; }
        public string Metodo { get; set; }
        public string[] ParametrosJson { get; set; }
        public string[] TiposParametros { get; set; }
    }

    public static class SerializadorEntidades
    {
        public static string Serializar(object obj)
        {
            return JsonConvert.SerializeObject(obj,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        }

        public static object Deserializar(string json)
        {
            return JsonConvert.DeserializeObject(json,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
        }
    }
}