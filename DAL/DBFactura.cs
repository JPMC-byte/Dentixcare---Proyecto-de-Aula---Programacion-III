using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using ENTITY;
using System.Linq;

namespace DAL
{
    public class DBFactura : ConexionOracle
    {
        public string SaveData(Factura factura)
        {
            try
            {
                string query = "INSERT INTO FACTURA (ID_FACTURA, FECHA_EMISION, ESTADO, MONTO_TOTAL) " +
                               "VALUES (:ID_Factura, TO_DATE(:Fecha_Emision, 'DD-MM-YYYY'), :Estado, :Total)";

                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_Factura", factura.ID_Factura));
                    command.Parameters.Add(new OracleParameter("Fecha_Emision", factura.Fecha_Emision.ToString("dd-MM-yyyy")));
                    command.Parameters.Add(new OracleParameter("Estado", factura.Estado));
                    command.Parameters.Add(new OracleParameter("Total", factura.Total));

                    command.ExecuteNonQuery();
                }

                return "Factura guardada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al guardar la factura: {ex.Message}";
            }
            finally
            {
                CerrarConexion();
            }
        }
        private Factura Map(OracleDataReader reader)
        {
            return new Factura
            {
                ID_Factura = Convert.ToString(reader["ID_FACTURA"]),
                Fecha_Emision = Convert.ToDateTime(reader["FECHA_EMISION"]),
                Estado = Convert.ToString(reader["ESTADO"]),
                Total = Convert.ToDouble(reader["MONTO_TOTAL"])
            };
        }

        public List<Factura> GetAll()
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                string query = "SELECT * FROM FACTURA";

                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            facturas.Add(Map(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<Factura>();
            }
            finally
            {
                CerrarConexion();
            }
            return facturas;
        }

        public Factura GetByID(string id)
        {
            return GetAll().FirstOrDefault<Factura>(x => x.ID_Factura == id);
        }

        public string Delete(string codigo)
        {
            string query = "DELETE FROM FACTURA WHERE ID_FACTURA = :Codigo";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_FACTURA", codigo));
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return "Registro eliminado";
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public string Update(Factura factura)
        {
            try
            {
                string query = "UPDATE FACTURA SET FECHA_EMISION = TO_DATE(:Fecha_Emision, 'DD-MM-YYYY'), ESTADO = :Estado, MONTO_TOTAL = :Total " +
                               "WHERE ID_FACTURA = :ID_Factura";

                AbrirConexion();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_Factura", factura.ID_Factura));
                    command.Parameters.Add(new OracleParameter("Fecha_Emision", factura.Fecha_Emision.ToString("dd-MM-yyyy")));
                    command.Parameters.Add(new OracleParameter("Estado", factura.Estado));
                    command.Parameters.Add(new OracleParameter("Total", factura.Total));

                    command.ExecuteNonQuery();
                }

                return "Factura actualizada correctamente.";
            }
            catch (Exception ex)
            {
                return $"Error al actualizar la factura: {ex.Message}";
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
