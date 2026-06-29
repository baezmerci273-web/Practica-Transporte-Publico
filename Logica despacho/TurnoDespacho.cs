using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_despacho
{
    public class TurnoDespacho
    {
        public DateTime HoraInicio { get; private set; }
        public double TotalRecaudado { get; private set; }
        public bool TurnoCerrado { get; private set; }

        // Constructor
        public TurnoDespacho()
        {
            HoraInicio = DateTime.Now;
            TotalRecaudado = 0;
            TurnoCerrado = false;
        }

        // Destructor
        ~TurnoDespacho()
        {
            TurnoCerrado = true;
        }

        public void AgregarRecaudacion(double monto)
        {
            TotalRecaudado += monto;
        }
    }
}
