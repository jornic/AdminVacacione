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
     public class NUser
    {
        RUser u = new RUser();
        public DataTable SelectAllUsers()
        {
            return u.SelectAllUsers();
        }

        public string DeleteUser(string id)
        {
            return u.DelectUser(Convert.ToInt32(id));
        }

        public string InsertUser(NuevoUsuario usuario)
        {
            return u.InsertUser(usuario);
        }
    }
}
