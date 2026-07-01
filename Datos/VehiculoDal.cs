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
                using (var cmd = new SqlCommand(@"INSERT INTO VEHICULO (placa,marca,modelo,anio,capacidad,estado,tipo,tarifa) VALUES(@placa,@marca,@modelo,@anio,@capacidad,@Estado,@Tipo,@Tarifa)", con))
                {
                    cmd.Parameters.AddWithValue("@placa", v.Placa);
                    cmd.Parameters.AddWithValue("@marca", v.Marca);
                    cmd.Parameters.AddWithValue("@modelo", v.Modelo);
                    cmd.Parameters.AddWithValue("@anio", v.Anio);
                    cmd.Parameters.AddWithValue("@capacidad", v.Capacidad);
                    cmd.Parameters.AddWithValue("@Estado", v.Estado);
                    cmd.Parameters.AddWithValue("@Tipo", v.Tipo);
                    cmd.Parameters.AddWithValue("@Tarifa",v.Tarifa);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al insertar vehiculo: {ex.Message}");
            }

        }

        public bool Eliminar(int idVehiculo)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("DELETE FROM Vehiculo WHERE idVehiculo = @IdVehiculo", con))
                {
                    cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al eliminar vehiculo: {ex.Message}");
               
            }
        }
        public bool CambiarEstado(int idVehiculo, bool nuevoEstado)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("UPDATE Vehiculo SET estado = @Estado WHERE idVehiculo = @IdVehiculo", con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error: Cambio de estado fallido {ex.Message}");


            }
        }

        public bool Actualizar(Vehiculo v)
        {
            try {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand(@"UPDATE Vehiculo 
                                       SET Placa=@Placa, Marca=@Marca, Modelo=@Modelo, 
                                           Anio=@Anio, Capacidad=@Capacidad, 
                                           Tipo=@Tipo, Tarifa=@Tarifa
                                       WHERE IdVehiculo=@IdVehiculo", con))
                {
                    cmd.Parameters.AddWithValue("@Placa", v.Placa);
                    cmd.Parameters.AddWithValue("@Marca", v.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", v.Modelo);
                    cmd.Parameters.AddWithValue("@Anio", v.Anio);
                    cmd.Parameters.AddWithValue("@Capacidad", v.Capacidad);
                    cmd.Parameters.AddWithValue("@Tipo", v.Tipo);
                    cmd.Parameters.AddWithValue("@Tarifa", v.Tarifa);
                    cmd.Parameters.AddWithValue("@IdVehiculo", v.IdVehiculo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error: Actulizacion fallida {ex.Message}");
        }   }
        public List<Vehiculo> ObtenerTodos2()
        {
            try
            {
                var lista = new List<Vehiculo>();

                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("SELECT idVehiculo,placa,marca,modelo,anio,capacidad,estado,tipo,tarifa FROM Vehiculo", con))
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
                            Estado = reader.GetBoolean(6),
                            Tipo = reader.IsDBNull(7) ? "Sin especificar" : reader.GetString(7),
                            Tarifa = reader.IsDBNull(8) ? 0 : (double)reader.GetDecimal(8)
                        });



                    }
                }
                return lista;
            } catch (Exception ex)
            { throw new ArgumentException($"Error al insertar Vehiculo:${ex.Message}"); }

        }
    }
}
