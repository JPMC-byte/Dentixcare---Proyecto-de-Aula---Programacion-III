using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DBTratamiento : ConexionOracle
    {
        private List<Tratamiento> listaTratamientos;
        public DBTratamiento() { }

        public string SaveData(Tratamiento tratamiento)
        {
            string query = "INSERT INTO TRATAMIENTO (ID_TRATAMIENTO, DESCRIPCION, DURACION, COSTO, ID_DIAGNOSTICO, ID_FACTURA) " +
                           "VALUES (:ID_Tratamiento, :Descripcion, :Duracion, :Costo, :CodigoDiagnostico, :CodigoFactura)";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_Tratamiento", tratamiento.ID_Tratamiento));
                    command.Parameters.Add(new OracleParameter("Descripcion", tratamiento.Descripcion));
                    command.Parameters.Add(new OracleParameter("Duracion", tratamiento.Duracion));
                    command.Parameters.Add(new OracleParameter("Costo", (float)tratamiento.Costo));
                    command.Parameters.Add(new OracleParameter("CodigoDiagnostico", tratamiento.CodigoDiagnostico ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("CodigoFactura", tratamiento.CodigoFactura ?? (object)DBNull.Value));

                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                return "Tratamiento registrado exitosamente";
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error al guardar: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        private Tratamiento Map(OracleDataReader reader)
        {
            return new Tratamiento
            {
                ID_Tratamiento = Convert.ToString(reader["ID_TRATAMIENTO"]),
                Descripcion = Convert.ToString(reader["DESCRIPCION"]),
                Duracion = Convert.ToString(reader["DURACION"]),
                Costo = Convert.ToDouble(reader["COSTO"]),
                CodigoDiagnostico = Convert.ToString(reader["ID_DIAGNOSTICO"]),
                CodigoFactura = Convert.ToString(reader["ID_FACTURA"])
            };
        }

        public List<Tratamiento> GetAll()
        {
            listaTratamientos = new List<Tratamiento>();
            string query = "SELECT * FROM TRATAMIENTO";

            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaTratamientos.Add(Map(reader));
                        }
                    }
                }
            }
            catch (Exception)
            {
                return new List<Tratamiento>();
            }
            finally
            {
                CerrarConexion();
            }
            return listaTratamientos;
        }
        public List<Tratamiento> LoadByDiagnostico(string codigo)
        {
            return GetAll().Where(trat => trat.CodigoDiagnostico == codigo).ToList();
        }
        public List<Tratamiento> LoadByFactura(string codigo)
        {
            return GetAll().Where(trat => trat.CodigoFactura == codigo).ToList();
        }

        public Tratamiento GetByID(string idTratamiento)
        {
            return GetAll().FirstOrDefault(t => t.ID_Tratamiento == idTratamiento);
        }

        public string Delete(string idTratamiento)
        {
            string query = "DELETE FROM TRATAMIENTO WHERE ID_TRATAMIENTO = :ID_Tratamiento";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_Tratamiento", idTratamiento));
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return "Tratamiento eliminado";
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
        public string Update(Tratamiento tratamiento)
        {
            string query = "UPDATE TRATAMIENTO SET " +
                           "DESCRIPCION = :Descripcion, " +
                           "DURACION = :Duracion, " +
                           "COSTO = :Costo, " +
                           "ID_DIAGNOSTICO = :CodigoDiagnostico, " +
                           "ID_FACTURA = :CodigoFactura " +
                           "WHERE ID_TRATAMIENTO = :ID_Tratamiento";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Descripcion", tratamiento.Descripcion));
                    command.Parameters.Add(new OracleParameter("Duracion", tratamiento.Duracion));
                    command.Parameters.Add(new OracleParameter("Costo", (float)tratamiento.Costo));
                    command.Parameters.Add(new OracleParameter("CodigoDiagnostico", tratamiento.CodigoDiagnostico ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("CodigoFactura", tratamiento.CodigoFactura ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("ID_Tratamiento", tratamiento.ID_Tratamiento));

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return "Tratamiento actualizado exitosamente";
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error al actualizar: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

    }
}
