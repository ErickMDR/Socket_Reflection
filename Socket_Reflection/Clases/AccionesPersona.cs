using Microsoft.Extensions.Configuration;
using Npgsql;
using Socket_Reflection.Entidades;
using Socket_Reflection.Datos;
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

        public void Eliminar(int ci)
        {
            var q = _config["Persona:Eliminar"];
            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@ci", ci);
            cmd.ExecuteNonQuery();
        }

        public List<Persona> BuscarPorCedula(int ci)
        {
            var personas = new List<Persona>();
            var q = _config["Persona:BuscarCi"];

            using var m = new ManejadorConexion(new Conexion());
            using var cmd = new NpgsqlCommand(q, m.ConexionAbierta);
            cmd.Parameters.AddWithValue("@ci", ci);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                personas.Add(new Persona
                {
                    Cedula = reader.GetInt32(reader.GetOrdinal("persona_ci")),
                    Nombre = reader.GetString(reader.GetOrdinal("persona_no"))
                });
            }
            return personas;
        }

        private int ConvertirTipoPersonaANumero(string tipo) =>
            tipo.ToLower() == "profesor" ? 1 : 2;
    }
}