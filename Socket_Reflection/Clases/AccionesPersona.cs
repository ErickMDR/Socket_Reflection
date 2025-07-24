using Microsoft.Extensions.Configuration;
using Npgsql;
using Socket_Reflection.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Socket_Reflection.Clases
{
    public class AccionesPersona : TablaBase<AccionesPersona>
    {
        protected override string NombreTabla => "Persona";
        private readonly IConfigurationRoot _config;

        public AccionesPersona() : base()
        {
            _config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("queries.json")
              .Build();
        }

        public int Insertar(Persona p)
        {
            var q = _config["Persona:Crear"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@apellido", p.Apellido);
            cmd.Parameters.AddWithValue("@ci", p.Cedula);
            cmd.Parameters.AddWithValue("@tipoPersona", ConvertirTipoPersonaANumero(p.TipoPersona));
            return cmd.ExecuteNonQuery();
        }

        public Persona BuscarPorCedula(int ci)
        {
            var q = _config["Persona:BuscarCi"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@ci", ci);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Persona
                {
                    Id = reader.GetInt32(reader.GetOrdinal("persona_id")),
                    Nombre = reader.GetString(reader.GetOrdinal("persona_no")),
                    Apellido = reader.GetString(reader.GetOrdinal("persona_ap")),
                    Cedula = reader.GetInt32(reader.GetOrdinal("persona_ci")),
                    TipoPersona = ObtenerDescripcionTipoPersona(reader.GetInt32(reader.GetOrdinal("tipo_persona_id")))
                };
            }
            return null;
        }

        private int ConvertirTipoPersonaANumero(string tipo) =>
            tipo.ToLower() == "profesor" ? 1 : 2;

        private string ObtenerDescripcionTipoPersona(int id) =>
            id == 1 ? "Profesor" : "Estudiante";
    }
}