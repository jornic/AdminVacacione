using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Repositorios
{
    public abstract class RepoEmpleado:Conexion
    {
       protected string AgregarEmpleado()
        {
            using(var conex = GetConnection())
            {
                conex.Open();
                using(var comando = new SqlCommand("SelectAll",conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    ////comando.Parameters.AddWithValue("@Opcion", Opcion);
                    ////comando.Parameters.AddWithValue("@IdEmpleado", Id);
                }

            }
            return "";
        }
    }
}
