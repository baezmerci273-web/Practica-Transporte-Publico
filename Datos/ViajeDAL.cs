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
            using (var con = Conexion.ObtenerConextion())
            using (var cmd = new SqlCommand(@"INSERT INTO RUTAS (idRutas,idChofer,idVehiculo,horaSalida,horaLlegada,estado,CantidadPasajero) VALUES(@IdRutas,@IdChofer,@IdVehiculo,@HoraSalida,HoraLlegada,@Estado,@CantidadPasajeros)", con))
            {
                cmd.Parameters.AddWithValue("@idRutas", viaje.IdRutas);
                cmd.Parameters.AddWithValue("@idChofer", viaje.IdChofer);
                cmd.Parameters.AddWithValue("@idVehiculo", viaje.idVehiculo);
                cmd.Parameters.AddWithValue("@horaSalida", viaje.HoraSalida);
                cmd.Parameters.AddWithValue("@horaLlegada", viaje.HoraLlegada);
                cmd.Parameters.AddWithValue("@Estado", viaje.estado);
                cmd.Parameters.AddWithValue(@"CantidadPasajeros", viaje.CantidadPasajeros);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public List<Viaje> ObtenerTodos2()
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
                        idVehiculo = reader.GetInt32(3),
                        HoraSalida = reader.GetDateTime(4),
                        HoraLlegada = reader.GetDateTime(5),
                        estado = reader.GetString(6),
                        CantidadPasajeros = reader.GetInt32(7)

                    });



                }
            }
            return lista;


        }
    }
}
