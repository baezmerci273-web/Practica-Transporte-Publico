using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class chofer
    {
        public int IdChofer { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string Licencia { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        

    public chofer() { }

        // Constructor completo
        public chofer(int idChofer, string nombre, string apellido, string cedula,
                      string licencia, string telefono, bool estado,string tipo)
        {
            IdChofer = idChofer;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Licencia = licencia;
            Telefono = telefono;
            Estado = estado;
            
        }
}   }
