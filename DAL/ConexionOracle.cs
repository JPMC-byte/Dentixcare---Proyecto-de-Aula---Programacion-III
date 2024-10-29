using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexionOracle
    {
        private string cadenaConexion = "User Id=ESQUEMA_AGENDA;Password=123456;Data Source=localhost:1521/orcl;";

        protected OracleConnection conexion;

        public ConexionOracle()
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
