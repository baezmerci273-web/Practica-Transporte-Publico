using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;


namespace Datos
{
    public class RutasDAL
    {
        public bool Insertar(Rutas R)
        {
            using (var con = Conexion.ObtenerConextion())
            using (var cmd = new SqlCommand(@"INSERT INTO RUTAS (nombre,salida,llegada,distanciaKM,estado) VALUES(@Nombre,@Salida,@Llegada,@Distancia,@Estado)", con))
            {
                cmd.Parameters.AddWithValue("@Nombre", R.Nombre);
                cmd.Parameters.AddWithValue("@Salida",R.Salida);
                cmd.Parameters.AddWithValue("@Llegada", R.Llegada);
                cmd.Parameters.AddWithValue("@DistanciaKM",R.DistanciaKm);
                cmd.Parameters.AddWithValue("@Estado",R.Estado);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public List<Rutas> ObtenerTodos()
        {
           var lista= new List<Rutas>();

            using (var con = Conexion.ObtenerConextion())
            using (var cmd = new SqlCommand("SELECT idRutas,nombre,salida,llegada,distanciaKM,Estado FROM Rutas", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Rutas
                    {
                        IdRutas=reader.GetInt32(0),
                        Nombre=reader.GetString(1),
                        Salida=reader.GetString(2),
                        Llegada=reader.GetString(3),
                        DistanciaKm=reader.GetInt32(4),
                        Estado=reader.GetBoolean(5)
                    });



            }   }
           return lista;
       
        
        }


      

        

    }
}
