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
                (viaje.idVehiculo<=0) ||
                viaje.HoraSalida==default ||
               (viaje.CantidadPasajeros <0) || string.IsNullOrEmpty (viaje.estado))
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
