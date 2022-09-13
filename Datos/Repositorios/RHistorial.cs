using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos.Repositorios
{
    public class RHistorial:Conexion
    {
        DataTable tabla = new DataTable();
        SqlDataReader dataReader;
        public DataTable SelectAllHistory()
        {
            tabla.Clear();

            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("sp_Historial", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    dataReader = comando.ExecuteReader();
                    tabla.Load(dataReader);
                    comando.Parameters.Clear();
                }
                conex.Dispose();
            }
            return tabla;
        }
    }
}
