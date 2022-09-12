using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Entidades
{
    public class EEmpleado
    {
        private int id;
        private string nombrea;
        private string nombreb;
        private string apellidoa;
        private string apellidob;
        private string ttipodeident;
        private string nident;
        private DateTime fecha;
        private double salario;
        private string direccion;

        public int Id { get => id; set => id = value; }
        public string Nombrea { get => nombrea; set => nombrea = value; }
        public string Nombreb { get => nombreb; set => nombreb = value; }
        public string Apellidoa { get => apellidoa; set => apellidoa = value; }
        public string Apellidob { get => apellidob; set => apellidob = value; }
        public string Ttipodeident { get => ttipodeident; set => ttipodeident = value; }
        public string Nident { get => nident; set => nident = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
