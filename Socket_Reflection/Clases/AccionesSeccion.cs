﻿using Microsoft.Extensions.Configuration;
using Npgsql;
using Socket_Reflection.Datos;
using System;
using System.Data;
using System.IO;

namespace Socket_Reflection.Datos
{
    public abstract class AccionesSeccion<T> : IDisposable
    {
        private readonly Conexion _conexionFactory;
        protected abstract string NombreTabla { get; }

        public AccionesSeccion()
        {
            _conexionFactory = new Conexion();
        }

        public DataTable Listado()
        {
            var dt = new DataTable();

            try
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("queries.json")
                    .Build();

                var query = config[$"{NombreTabla}:Leer"];

                if (string.IsNullOrEmpty(query))
                    throw new InvalidOperationException("Query no encontrado");

                using (var manejador = new ManejadorConexion(_conexionFactory))
                using (var cmd = new NpgsqlCommand(query, manejador.ConexionAbierta))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener listado", ex);
            }

            return dt;
        }

        public void Dispose()
        {
            _conexionFactory?.Dispose();
        }
    }
}