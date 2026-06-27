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

    }
}
