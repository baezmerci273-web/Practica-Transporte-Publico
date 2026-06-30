
using Microsoft.Data.SqlClient;
using System;

namespace Datos
{
    public class ChoferDAL
    {


        public bool Insertar1(chofer C)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand(@"INSERT INTO Chofer (nombre,apellido,cedula,licencia,telefono,estado) VALUES(@Nombre,@Apellido,@Cedula,@Licencia,@Telefono,@Estado)", con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", C.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", C.Apellido);
                    cmd.Parameters.AddWithValue("@Cedula", C.Cedula);
                    cmd.Parameters.AddWithValue("@Licencia", C.Licencia);
                    cmd.Parameters.AddWithValue("@Telefono", C.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", C.Estado);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error: {ex.Message}");
                
            }
        }

        public bool Eliminar(int idChofer)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("DELETE FROM Chofer WHERE idChofer = @IdChofer", con))
                {
                    cmd.Parameters.AddWithValue("@IdChofer", idChofer);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error: {ex.Message}");
                return false;
            }
        }

        public bool CambiarEstado(int idChofer, bool nuevoEstado)
        {
            try
            {
                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("UPDATE Chofer SET estado = @Estado WHERE idChofer = @IdChofer", con))
                {
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@IdChofer", idChofer);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error: {ex.Message}");
            }
        }
        public List<chofer> obtener()
        {

            try
            {
                var lista = new List<chofer>();

                using (var con = Conexion.ObtenerConextion())
                using (var cmd = new SqlCommand("SELECT idChofer,nombre,apellido,cedula,licencia,telefono,estado FROM Chofer", con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new chofer
                        {
                            IdChofer = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Cedula = reader.GetString(3),
                            Licencia = reader.GetString(4),
                            Telefono = reader.GetString(5),
                            Estado = reader.GetBoolean(6)
                        });



                    }
                }
                return lista;


            }
            catch(Exception ex) 
            {
                throw new ArgumentException($"Error: {ex.Message}");
            }
            }
 }      }
