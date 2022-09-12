using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositorios;
using System.Data;
using Soporte.Entidades;

namespace Negocio.Modelos
{
     public class NEmpleado
    {
        RepoEmpleado empleado = new RepoEmpleado();

        public DataTable ListEmpleado()
        {
            return empleado.SelectAll();
        }

        public string InsertEmpleado(EEmpleado e)
        {
            return empleado.GuardarDatos(e);
        }

        public string Delete(string id)
        {
            int Id = Convert.ToInt32(id);
            return empleado.Delete(Id);
        }
        public EEmpleado InforEmpleado(string id)
        {
            int Id = Convert.ToInt32(id);
            return empleado.SelectEmpleado(Id);
        }
    }
}
