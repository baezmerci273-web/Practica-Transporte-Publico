using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Anio { get; set; } = 0;
        public int capacidad { get; set; } = 0;
        public bool estado { get; set; } = true;

    }
}
