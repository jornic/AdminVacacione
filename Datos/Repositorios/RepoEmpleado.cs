using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Soporte.Entidades;
using Soporte.CacheUsers;

namespace Datos.Repositorios
{
    public class RepoEmpleado:Conexion
    {
        DataTable tabla = new DataTable();
        SqlDataReader dataReader;
       public DataTable SelectAll()
        {
            tabla.Clear();

            using(var conex = GetConnection())
            {
                conex.Open();
                using(var comando = new SqlCommand("SelectAll", conex))
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

        public string GuardarDatos(EEmpleado empleado)
        {
            string msj = string.Empty;
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("InsertEmpleado", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@NMod", string.Concat(CacheUsers.NomA," ",CacheUsers.ApeA));
                    comando.Parameters.AddWithValue("@Id", empleado.Id);
                    comando.Parameters.AddWithValue("@NA", empleado.Nombrea);
                    comando.Parameters.AddWithValue("@NB", empleado.Nombreb);
                    comando.Parameters.AddWithValue("@AA", empleado.Apellidoa);
                    comando.Parameters.AddWithValue("@AB", empleado.Apellidob);
                    comando.Parameters.AddWithValue("@TIdenti", empleado.Ttipodeident);
                    comando.Parameters.AddWithValue("@NIdenti", empleado.Nident);
                    comando.Parameters.AddWithValue("@Fe", empleado.Fecha);
                    comando.Parameters.AddWithValue("@Sa", empleado.Salario);
                    comando.Parameters.AddWithValue("@Dir", empleado.Direccion);

                    try
                    {
                        comando.ExecuteNonQuery();
                        msj = "Consulta realizada con exito";
                    }
                    catch (Exception e)
                    {
                        SqlException sq = e as SqlException;
                        if (sq != null && sq.Number == 2627)
                        {
                            msj = "Informacion duplicada";
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
        public string Delete(int Id)
        {
            string msj = string.Empty;
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("DeleteEmpleado", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Id", Id);
                    comando.Parameters.AddWithValue("@NMod", string.Concat(CacheUsers.NomA, " ", CacheUsers.ApeA));

                    try
                    {
                        comando.ExecuteNonQuery();
                        msj = "Registro eliminado";
                    }
                    catch (Exception e)
                    {
                        msj = "Error :" + e;
                    }
                }
            }
            return msj;
        }
        public EEmpleado SelectEmpleado(int Id)
        {
            var e = new EEmpleado();
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("SelectEmpl", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Id", Id);

                    dataReader = comando.ExecuteReader();
                    
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            e.Id = dataReader.GetInt32(0);
                            e.Nombrea = dataReader.GetString(1);
                            e.Nombreb = dataReader.GetString(2);
                            e.Apellidoa = dataReader.GetString(3);
                            e.Apellidob = dataReader.GetString(4);
                            e.Ttipodeident = dataReader.GetString(5);
                            e.Nident = dataReader.GetString(6);
                            e.Fecha = dataReader.GetDateTime(7);
                            e.Salario = Convert.ToDouble(dataReader.GetDecimal(8));
                            e.Direccion = dataReader.GetString(9);

                        }
                    }
                }
            }
            return e;
        }
    }
}
