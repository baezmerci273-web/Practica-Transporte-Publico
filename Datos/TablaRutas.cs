using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Rutas
    {
        public int IdRutas { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Salida { get; set; } = string.Empty;
        public string Llegada { get; set; } = string.Empty;
        public double DistanciaKm { get; set; } = 0.0;
        public bool Estado { get; set; } = true;
        public bool TieneAC { get; set; } = false;
        public DateTime Fecha {  get; set; } 

        public Rutas() { }
        public Rutas(string codigo, bool tieneAC, int id, string salida, string llegada, double Distancia)
        {
            Nombre = codigo;
            TieneAC = tieneAC;
            Estado = true;
            IdRutas = id;
            Salida=salida;
            Llegada=llegada;
            DistanciaKm = Distancia;

        }

        public Rutas(string codigo)
        {
            Nombre = codigo;
            TieneAC = false;
            Estado = true;
        }







}   }
