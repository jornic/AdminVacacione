using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos.Repositorios;

namespace Negocio.Modelos
{
    public class NHistorial
    {
        RHistorial historial = new RHistorial();
        public DataTable SelectHistorial()
        {
            return historial.SelectAllHistory();
        }
    }
}
