using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Recaudacion
    {
        public int IdRecaudacion { get; set; }
        public int IdViaje { get; set; }
        public Viaje viaje { get; set; }
        public int MontoTotal { get; set; }
        public int CantidadPasajero { get; set; }
        public DateTime Fecha { get; set; }



        // Constructor vacío
        public Recaudacion() { }

        // Constructor completo (solo FK, sin navegación)
        public Recaudacion(int idRecaudacion, int idViaje,
                           int montoTotal, int cantidadPasajero, DateTime fecha)
        {
            IdRecaudacion = idRecaudacion;
            IdViaje = idViaje;
            MontoTotal = montoTotal;
            CantidadPasajero = cantidadPasajero;
            Fecha = fecha;
        }
    }
}
