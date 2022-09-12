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
    public class RLogin:Conexion
    {
        SqlDataReader read;
        public bool Login(ELogin eLogin)
        {
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("UsersLogin", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@User", eLogin.Users);
                    comando.Parameters.AddWithValue("@Pass", eLogin.Password);

                    read = comando.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            CacheUsers.Id = read.GetInt32(0);
                            CacheUsers.NomA = read.GetString(1);
                            CacheUsers.NomB = read.GetString(2);
                            CacheUsers.ApeA = read.GetString(3);
                            CacheUsers.ApeB = read.GetString(4);
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
