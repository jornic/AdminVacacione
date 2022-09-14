using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soporte.Entidades;
using Datos.Repositorios;
using System.Data;

namespace Negocio.Modelos
{
    public class NVacacion
    {
        RVacacion rVacacion = new RVacacion();
        public string InsertVacacion(EVacacion e)
        {
            return rVacacion.InsertVacacion(e);
        }
        public string InsertVacacionEspecial(EVacacion e)
        {
            return rVacacion.InsertVacacionEspecial(e);
        }

        public DataTable ListVacacEspeci()
        {
            return rVacacion.ListVacacEspec();
        }

        public DataTable MostrarVacaciones(DateTime finicio,DateTime ffin)
        {
            return rVacacion.MostrarVacaciones(finicio,ffin);
        }
        public DataTable MostrarDetalleVacaciones(int id,DateTime finicio, DateTime ffin)
        {
            return rVacacion.MostrarDetalleVacaciones(id,finicio, ffin);
        }
    }
}
