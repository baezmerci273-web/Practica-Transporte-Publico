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
        public int IdVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public string Estado { get; set; } = string.Empty;
        public int CantidadPasajeros { get; set; }


        public Viaje() { }

        // Constructor completo (solo FKs, sin navegación)
        public Viaje(int idViaje, int idRutas, int idChofer, int idVehiculo,
                     DateTime horaSalida, DateTime horaLlegada,
                     string estado, int cantidadPasajeros)
        {
            IdViaje = idViaje;
            IdRutas = idRutas;
            IdChofer = idChofer;
            IdVehiculo = idVehiculo;
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            Estado = estado;
            CantidadPasajeros = cantidadPasajeros;
        }
    }
}
