using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Entidades
{
    public class EVacacion
    {
        private string motivo;
        private string descripcion;
        private DateTime finicio;
        private DateTime ffin;
        private int fk_empleado;

        public string Motivo { get => motivo; set => motivo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Finicio { get => finicio; set => finicio = value; }
        public DateTime Ffin { get => ffin; set => ffin = value; }
        public int Fk_empleado { get => fk_empleado; set => fk_empleado = value; }
    }
}
