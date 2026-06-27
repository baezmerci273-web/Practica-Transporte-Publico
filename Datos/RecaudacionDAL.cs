using Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class RecaudacionDAL
    {
        public bool Insertar2(Recaudacion recaudacion)
        {
            using (var con = Conexion.ObtenerConextion())
            using (var cmd = new SqlCommand(@"INSERT INTO RUTAS (idViaje,montoTotal,cantidadPasajero,fecha) VALUES(@IdViaje,@MontoTotal,@CantidadPasajero,@Fecha)", con))
            {
                cmd.Parameters.AddWithValue("@idViaje", recaudacion.IdViaje);
                cmd.Parameters.AddWithValue("@montoTotal", recaudacion.MontoTotal);
                cmd.Parameters.AddWithValue("@cantidadPasajero", recaudacion.CantidadPasajero);
                cmd.Parameters.AddWithValue("@fecha", recaudacion.Fecha);


                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public List<Recaudacion> ObtenerTodos2()
        {
            var lista = new List<Recaudacion>();

            using (var con = Conexion.ObtenerConextion())
            using (var cmd = new SqlCommand("SELECT idVehiculo,placa,marca,modelo,anio,capacidad,estado FROM Vehiculo", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Recaudacion
                    {
                        IdRecaudacion = reader.GetInt32(0),
                        IdViaje = reader.GetInt32(1),
                        MontoTotal = reader.GetInt32(2),
                        CantidadPasajero = reader.GetInt32(3),
                        Fecha = reader.GetDateTime(4),

                    });



                }
            }
            return lista;

        }
    }
}
