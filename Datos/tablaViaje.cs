using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Viaje
    {
        
        public int IdViaje { get; set; }
        public int IdRutas { get; set; }
        public Rutas Rutas { get; set; }
        public int IdChofer { get; set; }
        public chofer Chofer { get; set; }
        public int idVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public string estado { get; set; } = string.Empty;
    }
}
