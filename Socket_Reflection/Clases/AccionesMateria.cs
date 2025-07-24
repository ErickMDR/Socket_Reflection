using Microsoft.Extensions.Configuration;
using Npgsql;
using Sistema_Academia.Datos;
using Socket_Reflection.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Socket_Reflection.Datos;

namespace Socket_Reflection.Clases
{
    public class AccionesMateria : TablaBase<AccionesMateria>
    {
        private readonly IConfigurationRoot _config;
        public AccionesMateria() : base()
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("queries.json")
                .Build();
        }
        public void Insertar(Entidades.Materia materia)
        {
            var query = _config["Materia:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", materia.Nombre);
            cmd.ExecuteNonQuery();
        }
        public List<Entidades.Materia> BuscarPorNombre(string nombreMateria)
        {
            var materias = new List<Entidades.Materia>();
            var query = _config["Materia:Buscar"];

            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(query, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@descripcion", $"%{nombreMateria}%");

            using var lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                materias.Add(new Entidades.Materia
                {
                    Id = lector.GetInt32(lector.GetOrdinal("materia_id")),
                    Nombre = lector.GetString(lector.GetOrdinal("materia_de"))
                });
            }

            return materias;
        }
    }
}
