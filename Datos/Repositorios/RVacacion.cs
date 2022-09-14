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
    public class RVacacion:Conexion
    {
        public string InsertVacacion(EVacacion eVacacion)
        {
            string msj = string.Empty;
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("InsertVacacion", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@NMod", string.Concat(CacheUsers.NomA, " ", CacheUsers.ApeA));
                    comando.Parameters.AddWithValue("@Motivo", eVacacion.Motivo);
                    comando.Parameters.AddWithValue("@Descripcion", eVacacion.Descripcion);
                    comando.Parameters.AddWithValue("@FechaInicio", eVacacion.Finicio);
                    comando.Parameters.AddWithValue("@FechaFin", eVacacion.Ffin);
                    comando.Parameters.AddWithValue("@fk_Empleado", eVacacion.Fk_empleado);

                    try
                    {
                        comando.ExecuteNonQuery();
                        msj = "Consulta realizada con exito";
                    }
                    catch (Exception e)
                    {
                        msj = "Error :" + e;
                    }
                }
            }
            return msj;
        }
        public string InsertVacacionEspecial(EVacacion eVacacion)
        {
            string msj = string.Empty;
            using (var conex = GetConnection())
            {
                conex.Open();
                using (var comando = new SqlCommand("InsertVacacionEspecial", conex))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@NMod", string.Concat(CacheUsers.NomA, " ", CacheUsers.ApeA));
                    comando.Parameters.AddWithValue("@Motivo", eVacacion.Motivo);
                    comando.Parameters.AddWithValue("@Descripcion", eVacacion.Descripcion);
                    comando.Parameters.AddWithValue("@FechaInicio", eVacacion.Finicio);
                    comando.Parameters.AddWithValue("@FechaFin", eVacacion.Ffin);

                    try
                    {
                        comando.ExecuteNonQuery();
                        msj = "Consulta realizada con exito";
                    }
                    catch (Exception e)
                    {
                        msj = "Error :" + e;
                    }
                }
            }
            return msj;
        }

        public DataTable ListVacacEspec()
        {
            SqlDataReader Lector;
            using (var table = new DataTable())
            {
                using (var conex = GetConnection())
                {
                    conex.Open();
                    using (var comando = new SqlCommand("MostrarDiasEspeciales", conex))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        Lector = comando.ExecuteReader();
                        table.Load(Lector);
                        comando.Dispose();
                    }

                }

                return table;
            }
        }

        public DataTable MostrarVacaciones(DateTime a,DateTime b)
        {
            SqlDataReader lector;
            using (var table = new DataTable())
            {
                using (var conex = GetConnection())
                {
                    conex.Open();
                    using (var comando = new SqlCommand("MostraVacaciones", conex))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@FechA", a);
                        comando.Parameters.AddWithValue("@FechB", b);

                        lector = comando.ExecuteReader();
                        table.Load(lector);

                    }
                }

                return table;
            }
        }

        public DataTable MostrarDetalleVacaciones(int id,DateTime a, DateTime b)
        {
            SqlDataReader lector;
            using (var table = new DataTable())
            {
                using (var conex = GetConnection())
                {
                    conex.Open();
                    using (var comando = new SqlCommand("MostrarDetalleDeVa", conex))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@FeIni", a);
                        comando.Parameters.AddWithValue("@FeFin", b);

                        lector = comando.ExecuteReader();
                        table.Load(lector);
                    }
                }

                return table;
            }
        }
    }
}
