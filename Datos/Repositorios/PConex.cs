using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos.Repositorios
{
     public class PConex:Conexion
    {
        public bool PConection()
        {

            bool Resultado = false;
            using(var conex = GetConnection())
            {
                try
                {
                    conex.Open();
                    Resultado = true;
                }
                catch
                {
                    Resultado = false;
                }
                conex.Close();
                conex.Dispose();
            }
            
            return Resultado;
        }
    }
}
