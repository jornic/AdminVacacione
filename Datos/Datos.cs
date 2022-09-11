using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Soporte.CacheUsers;

namespace Datos
{
  /*  class Datos:Conexion
    {
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando;
        #region Login
        public bool Login(string users, string pwd)
        {
            var con = connection();
            con.Open();
            comando = new SqlCommand("LoginUsers", con);

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Users", users);
            comando.Parameters.AddWithValue("@Pwd", pwd);

            leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
               while (leer.Read())
                {
                    CacheUsers.Id = leer.GetInt32(0);
                    CacheUsers.Nombre = leer.GetString(1);
                    CacheUsers.Apellido = leer.GetString(2);
                    CacheUsers.Cargo = leer.GetString(3);
                }
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
            comando.Parameters.Clear();
        }
        #endregion

        #region Empleados
        public DataTable ListaEmpleados(string Opcion,string Id,string Nombre, string Apellido,string Tel,string Email,string Dir,string Edad,string Genero,string Cargo)
        {
            tabla.Clear();
            var con = connection();
            con.Open();
            comando = new SqlCommand("ProcEmpleado", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Opcion",Opcion);
            comando.Parameters.AddWithValue("@IdEmpleado", Id);
            comando.Parameters.AddWithValue("@Nombre",Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Telefono", Tel);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Direccion", Dir);
            comando.Parameters.AddWithValue("@Edad", Edad);
            comando.Parameters.AddWithValue("@Genero",Genero);
            comando.Parameters.AddWithValue("@fk_Cargo", Cargo);
            

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            con.Close();
            comando.Parameters.Clear();
            return tabla;
        }

        public string AccionesEmpleado(string Opcion, string Id, string Nombre, string Apellido, string Tel, string Email, string Dir, string Edad, string Genero, string Cargo)
        {
            string Resultado = "";
            var con = connection();
            con.Open();

            comando = new SqlCommand("ProcEmpleado", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Opcion", Opcion);
            comando.Parameters.AddWithValue("@IdEmpleado", Id);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Telefono", Tel);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Direccion", Dir);
            comando.Parameters.AddWithValue("@Edad", Edad);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@fk_Cargo", Cargo);

            try
            {
                comando.ExecuteNonQuery();
                Resultado = "Consulta realizada con exito";
            }catch(Exception e)
            {
                Resultado = "Error :"+e;        
            }

            comando.Parameters.Clear();
            con.Close();
            return Resultado;
        }
        #endregion

        #region Cargos

        public DataTable AccionCargo(string Opcion, string Id, string Cargo, string Descripcion)
        {
            tabla.Clear();
            var con = connection();
            con.Open();
            comando = new SqlCommand("ProcCargo", con);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Opcion", Opcion);
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Cargo", Cargo);
            comando.Parameters.AddWithValue("@Des", Descripcion);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            con.Close();
            comando.Parameters.Clear();
            return tabla;
        }

        #endregion
    }*/
}
