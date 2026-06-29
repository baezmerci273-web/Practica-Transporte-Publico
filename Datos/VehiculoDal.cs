using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class VehiculoDal
    {
        public bool Insertar2(Vehiculo v)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand(@"INSERT INTO RUTAS (nombre,salida,llegada,distanciaKM,estado) VALUES(@Nombre,@Salida,@Llegada,@Distancia,@Estado)", con))
                {
                    cmd.Parameters.AddWithValue("@placa", v.Placa);
                    cmd.Parameters.AddWithValue("@marca", v.Marca);
                    cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                    cmd.Parameters.AddWithValue("@anio", v.Anio);
                    cmd.Parameters.AddWithValue("@capacidad", v.Capacidad);
                    cmd.Parameters.AddWithValue("@Estado", v.Estado);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al insertar vehiculo: {ex.Message}");
            }

        }


        public List<Vehiculo> ObtenerTodos2()
        {
            try
            {
                var lista = new List<Vehiculo>();

                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("SELECT idVehiculo,placa,marca,modelo,anio,capacidad,estado FROM Vehiculo", con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Vehiculo
                        {
                            IdVehiculo = reader.GetInt32(0),
                            Placa = reader.GetString(1),
                            Marca = reader.GetString(2),
                            Modelo = reader.GetString(3),
                            Anio = reader.GetInt32(4),
                            Capacidad = reader.GetInt32(5),
                            Estado = reader.GetBoolean(6)
                        });



                    }
                }
                return lista;
            } catch (Exception ex)
            { throw new ArgumentException($"Error al insertar Vehiculo:${ex.Message}"); }

        }
    }
}
