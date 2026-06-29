using Capa_Datos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class RecaudacionBLL
    {
        private readonly RecaudacionDAL _dal = new RecaudacionDAL();
        
        public string Registrar(Recaudacion re)
        {
            if ((re.IdViaje <= 0) ||
               (re.MontoTotal < 0) ||
                (re.CantidadPasajero < 0) ||
                (re.Fecha == default(DateTime)))
               
            {
                return "Error: Todos los campos son obligatorios";
            }
            
            bool ok = _dal.Insertar2(re);
            return ok ? "Recaudacion Registrada Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }

        public virtual double CalcularRecaudacion(Recaudacion re)
        {
            return re.MontoTotal;
        }
        public class RecaudacionPorCapacidadBLL : RecaudacionBLL
{
    private readonly double _tarifaPorPasajero;

    public RecaudacionPorCapacidadBLL(double tarifaPorPasajero)
    {
        _tarifaPorPasajero = tarifaPorPasajero;
    }

    public override double CalcularRecaudacion(Recaudacion re)
    {
        if (re.CantidadPasajero <= 0)
            return 0;

        return re.CantidadPasajero * _tarifaPorPasajero;
    }
}
        public List<Recaudacion> ObtenerTodos()
        {
            return _dal.ObtenerTodos2();
        }

    }
}
