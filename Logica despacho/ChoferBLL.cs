using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ChoferBLL
    {
        private readonly ChoferDAL _dal= new ChoferDAL();

        public string Registrar(chofer  c)
        {
            if (string.IsNullOrEmpty(c.Nombre) ||
                string.IsNullOrEmpty(c.Apellido) ||
                string.IsNullOrEmpty(c.Cedula) ||
                string.IsNullOrEmpty(c.Licencia) ||
                string.IsNullOrEmpty(c.telefono)
                )
            {
                return "Error: Todos los campos son obligatorios";
            }

            if (c.Cedula.Length<13)
            {
                return "Error: Faltan caracteres.";
            }


            bool ok = _dal.Insertar1(c);
            return ok ? "Chofer Registrado Exitosamente" : "Error:No se pudo guardar en base de datos,";
        }



        public List<chofer> ObtenerTodos()
        {
            return _dal.obtener();
        }
    }
}

