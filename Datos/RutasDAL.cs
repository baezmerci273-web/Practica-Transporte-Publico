using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;


namespace Datos
{
    public class RutasDAL
    {
        public bool Insertar(Rutas R)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand(@"INSERT INTO RUTAS (nombre,salida,llegada,distanciaKM,estado,tieneAC) VALUES(@Nombre,@Salida,@Llegada,@Distancia,@Estado,@TieneAC)", con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", R.Nombre);
                    cmd.Parameters.AddWithValue("@Salida", R.Salida);
                    cmd.Parameters.AddWithValue("@Llegada", R.Llegada);
                    cmd.Parameters.AddWithValue("@DistanciaKM", R.DistanciaKm);
                    cmd.Parameters.AddWithValue("@Estado", R.Estado);
                    cmd.Parameters.AddWithValue("@TieneAC", R.TieneAC);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al insertar ruta: {ex.Message}");
                return false;



            }
        }  

        public List<Rutas> ObtenerTodos()
        {
            try
            {
                var lista = new List<Rutas>();

                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("SELECT idRutas,nombre,salida,llegada,distanciaKM,Estado,tieneAC FROM Rutas", con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Rutas
                        {
                            IdRutas = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Salida = reader.GetString(2),
                            Llegada = reader.GetString(3),
                            DistanciaKm = reader.GetInt32(4),
                            Estado = reader.GetBoolean(5),
                            TieneAC = reader.GetBoolean(6)
                        });



                    }
                }
                return lista;

            }
            catch (SqlException ex)
            {
                throw new ArgumentException($"Error al insertar recaudacion: {ex.Message}");
                
            }
        }
    }
}
