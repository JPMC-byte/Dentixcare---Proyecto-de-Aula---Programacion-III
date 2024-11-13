using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DBPago : ConexionOracle
    {
        public string SaveData(Pago pago)
        {
            try
            {
                string query = "INSERT INTO PAGO (ID_PAGO, FECHA_PAGO, METODO_PAGO, MONTO, ID_FACTURA, CEDULA_P) " +
                               "VALUES (:ID_Pago, TO_DATE(:Fecha_Pago, 'DD-MM-YYYY'), :Metodo_Pago, :Monto, :ID_Factura, :Cedula_P)";

                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_Pago", pago.ID_Pago));
                    command.Parameters.Add(new OracleParameter("Fecha_Pago", pago.Fecha_Pago.ToString("dd-MM-yyyy")));
                    command.Parameters.Add(new OracleParameter("Metodo_Pago", pago.Metodo_Pago));
                    command.Parameters.Add(new OracleParameter("Monto", (float)pago.Monto));
                    command.Parameters.Add(new OracleParameter("ID_Factura", pago.CodigoFactura));
                    command.Parameters.Add(new OracleParameter("Cedula_P", pago.CodigoPaciente));

                    command.ExecuteNonQuery();
                }

                return "Pago guardado correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al guardar el pago: {ex.Message}";
            }
            finally
            {
                CerrarConexion();
            }
        }
        private Pago Map(OracleDataReader reader)
        {
            return new Pago
            {
                ID_Pago = Convert.ToString(reader["ID_PAGO"]),
                Fecha_Pago = Convert.ToDateTime(reader["FECHA_PAGO"]),
                Metodo_Pago = Convert.ToString(reader["METODO_PAGO"]),
                Monto = Convert.ToDouble(reader["MONTO"]),
                CodigoFactura = Convert.ToString(reader["ID_FACTURA"]),
                CodigoPaciente = Convert.ToString(reader["CEDULA_P"])
            };
        }
        public List<Pago> GetAll()
        {
            List<Pago> pagos = new List<Pago>();
            try
            {
                string query = "SELECT * FROM PAGO";
                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pagos.Add(Map(reader));
                        }
                    }
                }
                return pagos;
            }
            catch (Exception ex)
            {
                return new List<Pago>();
            }
            finally
            {
                CerrarConexion();
            }
        }
        public List<Pago> LoadByFactura(string codigo)
        {
            return GetAll().Where(pago => pago.CodigoFactura == codigo).ToList();
        }
        public Pago GetById(string id)
        {
            return GetAll().FirstOrDefault<Pago>(x => x.ID_Pago == id);
        }
    }
}
