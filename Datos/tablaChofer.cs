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
        public string telefono { get; set; } = string.Empty;
        public bool estado { get; set; } = true;
    }
}
