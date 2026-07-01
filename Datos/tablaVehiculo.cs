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
        public int Capacidad { get; set; } = 0;
        public bool Estado { get; set; } = true;
        public string Tipo { get; set; } = string.Empty;
        public double Tarifa {  get; set; } = 0;

        public Vehiculo() { }

        // Constructor completo
        public Vehiculo(int idVehiculo, string placa, string marca,
                        string modelo, int anio, int capacidad, bool estado, string tipo, double tarifa)
        {
            IdVehiculo = idVehiculo;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Capacidad = capacidad;
            Estado = estado;
            Tipo= tipo;
            Tarifa = tarifa;
        }
}   }
