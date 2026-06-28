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

        public List<Viaje> ObtenerTodos()
        {
            return _dal.ObtenerTodos2();
        }
    }
}
