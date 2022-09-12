using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositorios;
using Soporte.Entidades;

namespace Negocio
{
    public class NLogin
    {
        public bool AccessLogin(ELogin eLogin)
        {
            RLogin r = new RLogin();
            return r.Login(eLogin);
        }
    }
}
