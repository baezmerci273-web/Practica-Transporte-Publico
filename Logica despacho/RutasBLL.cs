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

        public List<Rutas> Buscar(List<Rutas> lista, string valor)
        {
            bool esNumero = double.TryParse(valor, out double distancia);

            return lista.FindAll(r =>
                r.Nombre.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                r.Salida.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                r.Llegada.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                (esNumero && r.DistanciaKm == distancia)
            );
        }

        public string Eliminar(int idRutas)
        {
            if (idRutas <= 0)
                return "Error: Ruta no válida.";

            bool ok = _dal.Eliminar(idRutas);
            return ok ? "Ruta eliminada exitosamente"
                      : "Error: No se pudo eliminar la ruta.";
        }

        public Predicate<Rutas> ObtenerSoloActivas()
        {
            return r => r.Estado == true;
        }
        public string CambiarEstado(int idRutas, bool nuevoEstado)
        {
            if (idRutas <= 0)
                return "Error: Ruta no válida.";

            bool ok = _dal.CambiarEstado(idRutas, nuevoEstado);
            string accion = nuevoEstado ? "activada" : "desactivada";
            return ok ? $"Ruta {accion} exitosamente"
                      : "Error: No se pudo cambiar el estado.";
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
