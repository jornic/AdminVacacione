using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos.Repositorios
{
    public abstract class Conexion
    {
        private readonly string CadenaDeConex;
        public Conexion()
        {
            CadenaDeConex = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(CadenaDeConex);
        }
        protected void SettingsConection(string conex)
        {
            string Cadena = conex;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["Conexion"].ConnectionString = Cadena;
            config.Save(ConfigurationSaveMode.Modified, true);
        }
    }
}
