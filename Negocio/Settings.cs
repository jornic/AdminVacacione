using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositorios;

namespace Negocio
{
     public class Settings
    {
        RSettings rSettings = new RSettings();
        public void UpdateSettings()
        {
            rSettings.UpdateConex();
        }
    }
}
