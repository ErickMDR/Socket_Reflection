using Microsoft.Extensions.Configuration;
using Npgsql;
using Socket_Reflection.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Socket_Reflection.Datos
{
    public class AccionesSeccion : TablaBase<AccionesSeccion>
    {
        protected override string NombreTabla => "Seccion";
        private readonly IConfigurationRoot _config;

        public AccionesSeccion() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }

        public void Insertar(Seccion seccion)
        {
            var query = _config["Seccion:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", seccion.Descripcion);
            cmd.ExecuteNonQuery();
        }

        public List<Seccion> BuscarPorDescripcion(string descripcionSeccion)
        {
            var secciones = new List<Seccion>();
            var query = _config["Seccion:Buscar"];

            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", $"%{descripcionSeccion}%");

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                secciones.Add(new Seccion
                {
                    Id = reader.GetInt32(reader.GetOrdinal("seccion_id")),
                    Descripcion = reader.GetString(reader.GetOrdinal("seccion_de"))
                });
            }

            return secciones;
        }
    }
}