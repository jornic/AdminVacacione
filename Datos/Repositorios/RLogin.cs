using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Soporte.CacheUsers;
using Soporte.Entidades;

namespace Datos.Repositorios
{
    public abstract class RLogin:Conexion
    {
        SqlDataReader read;
        protected bool Login(ELogin eLogin)
        {
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("UsersLogin", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Users", eLogin.Users);
                    comando.Parameters.AddWithValue("@Pwd", eLogin.Password);

                    read = comando.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            CacheUsers.Id = read.GetInt32(0);
                            CacheUsers.Nombre = read.GetString(1);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    comando.Parameters.Clear();                    
                }
                conex.Close();
                conex.Dispose();
            }
            return false;
        }
    }
}
