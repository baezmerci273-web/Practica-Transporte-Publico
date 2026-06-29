using Datos;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                (r.DistanciaKm) <=0.0)
            {
                return "Error: Todos los campos son obligatorios";
            }


            bool ok=_dal.Insertar(r);
            return ok ? "Ruta Registrada Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }
        public Predicate<Rutas> ObtenerSoloActivas()
        {
            return r => r.Estado == true;
        }


        public List<Rutas> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
        public List<Rutas> ObtenerActivas()
        {
            return _dal.ObtenerTodos().FindAll(ObtenerSoloActivas());
        }
    }
}
