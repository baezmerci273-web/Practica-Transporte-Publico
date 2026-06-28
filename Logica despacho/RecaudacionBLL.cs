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
        public List<Recaudacion> ObtenerTodos()
        {
            return _dal.ObtenerTodos2();
        }

    }
}
