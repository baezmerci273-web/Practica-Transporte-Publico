using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class ViajeDAL
    {

        public bool Insertar2(Viaje viaje)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand(@"INSERT INTO Viaje (idRutas,idChofer,idVehiculo,horaSalida,horaLlegada,estado,cantidadPasajeros) 
                                  VALUES(@IdRutas,@IdChofer,@IdVehiculo,@HoraSalida,@HoraLlegada,@Estado,@CantidadPasajeros)", con))
                    
                {
                    cmd.Parameters.AddWithValue("@idRutas", viaje.IdRutas);
                    cmd.Parameters.AddWithValue("@idChofer", viaje.IdChofer);
                    cmd.Parameters.AddWithValue("@idVehiculo", viaje.IdVehiculo);
                    cmd.Parameters.AddWithValue("@horaSalida", viaje.HoraSalida);
                    cmd.Parameters.AddWithValue("@horaLlegada", viaje.HoraLlegada);
                    cmd.Parameters.AddWithValue("@Estado", viaje.Estado);
                    cmd.Parameters.AddWithValue(@"CantidadPasajeros", viaje.CantidadPasajeros);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al insertar ruta: {ex.Message}");
            }
            
        }

        public bool Eliminar(int idViaje)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("DELETE FROM Viaje WHERE idViaje = @IdViaje", con))
                {
                    cmd.Parameters.AddWithValue("@IdViaje", idViaje);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error al eliminar viaje: {ex.Message}");
                return false;
            }
        }

        public List<Viaje> ObtenerTodos2()
        {
            try
            {
                var lista = new List<Viaje>();

                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("SELECT idVehiculo,placa,marca,modelo,anio,capacidad,estado,CantidadPasajeros FROM Vehiculo", con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Viaje
                        {
                            IdViaje = reader.GetInt32(0),
                            IdRutas = reader.GetInt32(1),
                            IdChofer = reader.GetInt32(2),
                            IdVehiculo = reader.GetInt32(3),
                            HoraSalida = reader.GetDateTime(4),
                            HoraLlegada = reader.GetDateTime(5),
                            Estado = reader.GetString(6),
                            CantidadPasajeros = reader.GetInt32(7)

                        });



                    }
                }
                return lista;

            } catch (Exception ex)
            { throw new ArgumentException($"Error al insertar ruta: {ex.Message}"); }
        }
    }
}
