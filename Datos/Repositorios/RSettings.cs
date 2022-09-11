using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Soporte.Server;

namespace Datos.Repositorios
{
     public class RSettings:Conexion
    {
        public void UpdateConex()
        {     
            string Cadena = "Data Source = " + Server.Servidor + "; Initial Catalog = " + Server.BD + "; User ID = " + Server.Users + "; Password = " + Server.pwd + ";";
            SettingsConection(Cadena);
        }
    }
}
