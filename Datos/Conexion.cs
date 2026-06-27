using System;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private static readonly string _cadena =
            @"Server=.;Database=transporte;" +
            "Trusted_Connection=True;TrustServerCertificate=True;";

        public static  SqlConnection ObtenerConextion()
        {
            var conexion = new SqlConnection (_cadena);
            conexion.Open();
            return conexion;
        }
    }
}
