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
                (v.Anio) <=0 || 
               (v.capacidad<=0)||(v.estado == null))
            {
                return "Error: Todos los campos son obligatorios";
            }
            bool ok = _dal.Insertar2(v);
            return ok ? "Estudiantes Registrados Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }

    }
}
