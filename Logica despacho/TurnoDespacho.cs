using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Logica_despacho
{
    public class TurnoDespacho
    {
        public DateTime HoraInicio { get; private set; }
        public DateTime HoraCierre { get; private set; }
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
        // Recurso que libera: el turno activo de despacho.
        // Justificación: cuando el objeto es recolectado por el GC, garantizamos
        // que el turno quede cerrado y se registre el total recaudado en un log,
        // evitando turnos que queden abiertos indefinidamente en el sistema.
        ~TurnoDespacho()
        {
            if (!TurnoCerrado)
            {
                HoraCierre = DateTime.Now;
                TurnoCerrado = true;

                // Registra el cierre en un archivo de log
                string log = $"[CIERRE AUTOMÁTICO] {HoraCierre:dd/MM/yyyy HH:mm:ss} | " +
                             $"Inicio: {HoraInicio:HH:mm:ss} | " +
                             $"Total recaudado: RD${TotalRecaudado:N2}";

                File.AppendAllText("log_turnos.txt", log + Environment.NewLine);
            }
        }

        public void AgregarRecaudacion(double monto)
        {
            if (!TurnoCerrado)
                TotalRecaudado += monto;
        }

        public void CerrarTurno()
        {
            if (!TurnoCerrado)
            {
                HoraCierre = DateTime.Now;
                TurnoCerrado = true;

                string log = $"[CIERRE MANUAL] {HoraCierre:dd/MM/yyyy HH:mm:ss} | " +
                             $"Inicio: {HoraInicio:HH:mm:ss} | " +
                             $"Total recaudado: RD${TotalRecaudado:N2}";

                File.AppendAllText("log_turnos.txt", log + Environment.NewLine);
            }
        }
    }
}
