using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Entidades
{
    public class NuevoUsuario
    {
        private string usuario;
        private string contrasena;
        private int fk_Empleado;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Fk_Empleado { get => fk_Empleado; set => fk_Empleado = value; }
    }
}
