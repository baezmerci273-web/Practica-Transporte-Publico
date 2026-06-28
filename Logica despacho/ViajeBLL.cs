using Capa_Datos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_despacho
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
               (viaje.CantidadPasajeros <= 0) || (viaje.estado == null))
            {
                return "Error: Todos los campos son obligatorios";
            }
            bool ok = _dal.Insertar2(viaje);
            return ok ? "Estudiantes Registrados Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }

    }
}
