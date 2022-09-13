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
    public class RUser : Conexion
    {
        DataTable table = new DataTable();
        SqlDataReader lector;

        public DataTable SelectAllUsers()
        {
            table.Clear();
            using(var conex = GetConnection())
            {
                conex.Open();
                using(var comando = new SqlCommand("SelectAllUsers", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    lector = comando.ExecuteReader();

                    table.Load(lector);
                }
            }
            return table;
        }

        public string DelectUser(int id)
        {
            string msj = string.Empty;

            using(var conex = GetConnection())
            {
                conex.Open();
                using(var comando = new SqlCommand("DeleteUsers", conex))
                {
                    
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NMod", string.Concat(CacheUsers.NomA," ",CacheUsers.ApeA));
                    comando.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        comando.ExecuteNonQuery();
                        msj = "Usuario eliminado";
                    }
                    catch(Exception e)
                    {
                        msj = "Fallo!";
                    }
                }
            }

            return msj;
        }
        public string InsertUser(NuevoUsuario usuario)
        {
            string msj = string.Empty;

            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("InsertUsers", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NMod", string.Concat(CacheUsers.NomA, " ", CacheUsers.ApeA));
                    comando.Parameters.AddWithValue("@User", usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                    comando.Parameters.AddWithValue("@IdEmpleado", usuario.Fk_Empleado);

                    try
                    {
                        comando.ExecuteNonQuery();
                        msj = "Usuario agregado";
                    }
                    catch (Exception e)
                    {
                        SqlException sq = e as SqlException;
                        if (sq != null && sq.Number == 2627)
                        {
                            msj = "Informacion duplicada\nEl empleado ya esta registrado";
                        }
                        else
                        {
                            msj = "Error :" + e;
                        }
                    }
                }
            }

            return msj;
        }
    }
}
