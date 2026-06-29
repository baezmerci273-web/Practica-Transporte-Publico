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
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand(@"INSERT INTO Recaudacion (idViaje,montoTotal,cantidadPasajero,fecha) VALUES(@IdViaje,@MontoTotal,@CantidadPasajero,@Fecha)", con))
                {
                    cmd.Parameters.AddWithValue("@IdViaje", recaudacion.IdViaje);
                    cmd.Parameters.AddWithValue("@MontoTotal", recaudacion.MontoTotal);
                    cmd.Parameters.AddWithValue("@CantidadPasajero", recaudacion.CantidadPasajero);
                    cmd.Parameters.AddWithValue("@Fecha", recaudacion.Fecha);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException ($"Error al insertar recaudacion: {ex.Message}");
                return false;
            }
        }

        public List<Recaudacion> ObtenerTodos2()
        {
            var lista = new List<Recaudacion>();
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("SELECT idRecaudacion,idViaje,montoTotal,cantidadPasajero,fecha FROM Recaudacion", con))
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
            }
            catch (Exception ex)
            {
                throw new ArgumentException ($"Error al insertar recaudacion: {ex.Message}");
            }
            return lista;
        }
    }
}
