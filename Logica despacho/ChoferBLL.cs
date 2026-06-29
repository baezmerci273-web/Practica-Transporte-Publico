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
                string.IsNullOrEmpty(c.Telefono)
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

        public List<chofer> Buscar(List<chofer> lista, string valor)
        {
            return lista.FindAll(c =>
                c.Nombre.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                c.Apellido.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                c.Cedula.Contains(valor, StringComparison.OrdinalIgnoreCase) ||
                c.Licencia.Contains(valor, StringComparison.OrdinalIgnoreCase)
            );
        }

        public string Eliminar(int idChofer)
        {
            if (idChofer <= 0)
                return "Error: Chofer no válido.";

            bool ok = _dal.Eliminar(idChofer);
            return ok ? "Chofer eliminado exitosamente"
                      : "Error: No se pudo eliminar el chofer.";
        }
        public List<chofer> ObtenerTodos()
        {
            return _dal.obtener();
        }
    }
}

