using Datos;
using System;

namespace Negocios
{
    public class RutasBLL
    {
        private readonly RutasDAL _dal = new RutasDAL();

        public string Registrar(Rutas r)
        {
            if (string.IsNullOrEmpty(r.Nombre) ||
                string.IsNullOrEmpty(r.Salida) ||
                string.IsNullOrEmpty(r.Llegada) ||
                (r.DistanciaKm) <0.0||(r.Estado==null))
            {
                return "Error: Todos los campos son obligatorios";
            }
            bool ok=_dal.Insertar(r);
            return ok ? "Estudiantes Registrados Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }

        public List<Rutas> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}
