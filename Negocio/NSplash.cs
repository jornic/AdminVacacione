using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Datos.Repositorios;
using System.Threading;
using Soporte.Server;

namespace Negocio
{
    public class NSplash
    {
        PConex pcon = new PConex();
       
        public bool PruebaConexion()
        {
            return pcon.PConection();
        }
       
    }
}
