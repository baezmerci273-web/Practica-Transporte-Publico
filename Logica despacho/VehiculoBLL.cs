using Capa_Datos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class VehiculoBLL
    {
        private readonly VehiculoDal _dal = new VehiculoDal();

        public string Registrar(Vehiculo v)
        {
            if (string.IsNullOrEmpty(v.Placa) ||
                string.IsNullOrEmpty(v.Marca) ||
                string.IsNullOrEmpty(v.Modelo) ||
                (v.Anio) <=1800 || 
               (v.Capacidad<=0))
            {
                return "Error: Todos los campos son obligatorios";
            }
            bool ok = _dal.Insertar2(v);
            return ok ? "Vehiculo Registrado Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }

        public List<Vehiculo> Buscar(List<Vehiculo> lista, string valor)
        {
            bool esNumero = int.TryParse(valor, out int numero);

            return lista.FindAll(v =>
                v.Placa.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                v.Marca.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                v.Modelo.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                (esNumero && v.Anio == numero) ||
                (esNumero && v.Capacidad == numero)
            );
        }
        public string CambiarEstado(int idVehiculo, bool nuevoEstado)
        {
            if (idVehiculo <= 0)
                return "Error: Vehículo no válido.";
            bool ok = _dal.CambiarEstado(idVehiculo, nuevoEstado);
            string accion = nuevoEstado ? "activado" : "desactivado";
            return ok ? $"Vehículo {accion} exitosamente"
                      : "Error: No se pudo cambiar el estado.";
        }
        public string Eliminar(int idVehiculo)
        {
            if (idVehiculo <= 0)
                return "Error: Vehiculo no válido.";

            bool ok = _dal.Eliminar(idVehiculo);
            return ok ? "Vehiculo eliminado exitosamente"
                      : "Error: No se pudo eliminar el vehiculo.";
        }

        public abstract class VehiculoTransporteBLL  //clase y metodos abstractos
        {
            public abstract string TipoTransporte();
            public abstract double CalcularTarifa();

            
        }
        public class Guagua : VehiculoTransporteBLL
        {
            public override string TipoTransporte() => "Guagua";
            public override double CalcularTarifa() => 135.0;
        }
        public class Voladorcito : VehiculoTransporteBLL
        {
            public override string TipoTransporte() => "Voladorcito";
            public override double CalcularTarifa() => 75.0;
        }



        public List<Vehiculo> ObtenerTodos()
        {
            return _dal.ObtenerTodos2();
        }

    }    
}
