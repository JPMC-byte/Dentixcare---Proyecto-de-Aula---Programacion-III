using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        private string cadenaConexion = "User Id=admin1;Password=1008;Data Source=localhost:1521/XEPDB1;";

        protected OracleConnection conexion;

        public Conexion()
        {
            conexion = new OracleConnection(cadenaConexion);
        }

        public bool AbrirConexion()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
                return true;
            }
            return false;
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public OracleConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
