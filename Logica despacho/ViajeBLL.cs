using Capa_Datos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ViajeBLL
    {
        private readonly ViajeDAL _dal = new ViajeDAL();

        public string Registrar(Viaje viaje)
        {
            if ((viaje.IdRutas<=0) ||
                (viaje.IdChofer<=0) ||
                (viaje.IdVehiculo<=0) ||
                viaje.HoraSalida==default ||
               (viaje.CantidadPasajeros <0) || string.IsNullOrEmpty (viaje.Estado))
            {
                return "Error: Todos los campos son obligatorios";
            }

            if (viaje.HoraSalida< DateTime.Now)
            {
                return "Error: Ingrese una fecha futura.";
            }

            if (viaje.HoraLlegada<= viaje.HoraSalida)
            {
                return "Error: Debe ingresar una fecha valida";
            }
            bool ok = _dal.Insertar2(viaje);
            return ok ? "Viaje Registrado Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }

        public List<Viaje> Buscar(List<Viaje> lista, string valor)
        {
            bool esNumero = int.TryParse(valor, out int numero);
            bool esFecha = DateTime.TryParse(valor, out DateTime fecha);

            return lista.FindAll(v =>
                v.Estado.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                (esNumero && v.IdRutas == numero) ||
                (esNumero && v.IdChofer == numero) ||
                (esNumero && v.IdVehiculo == numero) ||
                (esNumero && v.CantidadPasajeros == numero) ||
                (esFecha && v.HoraSalida.Date == fecha.Date) ||
                (esFecha && v.HoraLlegada.Date == fecha.Date)
            );
        }

        public string Eliminar(int idViaje)
        {
            if (idViaje <= 0)
                return "Error: Viaje no válido.";

            bool ok = _dal.Eliminar(idViaje);
            return ok ? "Viaje eliminado exitosamente"
                      : "Error: No se pudo eliminar el viaje.";
        }

        public string RegistrarViaje(Viaje viaje)
        {
            return Registrar(viaje); // validacion de arriba
        }

        public string AsignarChofer(Viaje viaje, int idChofer)
        {
            if (idChofer <= 0)
                return "Error: Chofer inválido";

            viaje.IdChofer = idChofer;
            return "Chofer asignado correctamente";
        }
        public double CalcularRendimiento(Viaje viaje)
        {
            if (viaje.CantidadPasajeros <= 0)
                return 0;

            double duracionHoras = (viaje.HoraLlegada - viaje.HoraSalida).TotalHours;

            if (duracionHoras <= 0)
                return 0;

            return viaje.CantidadPasajeros / duracionHoras; // pasajeros por hora
        }
        public List<Viaje> ObtenerTodos()
        {
            return _dal.ObtenerTodos2();
        }
    }
}
