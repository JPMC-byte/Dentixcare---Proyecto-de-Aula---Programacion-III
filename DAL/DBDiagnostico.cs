using System;
using System.Collections.Generic;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class DBDiagnostico : ConexionOracle
    {
        private List<Diagnostico> listaDiagnosticos;
        public DBDiagnostico() { }
        public string SaveData(Diagnostico diagnostico)
        {
            string query = "INSERT INTO DIAGNOSTICO (ID_DIAGNOSTICO, FECHA_DIAGNOSTICO, DESCRIPCION, ID_CITA, CEDULA_P) " +
                           "VALUES (:Codigo, :Fecha_Diagnostico, :Descripcion, :CodigoCita, :CedulaPaciente)";

            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Codigo", diagnostico.Codigo));
                    command.Parameters.Add(new OracleParameter("Fecha_Diagnostico", diagnostico.Fecha_Diagnostico));
                    command.Parameters.Add(new OracleParameter("Descripcion", diagnostico.Descripcion));
                    command.Parameters.Add(new OracleParameter("CodigoCita", diagnostico.CodigoCita));
                    command.Parameters.Add(new OracleParameter("CedulaPaciente", diagnostico.CedulaPaciente));

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return "Diagnóstico registrado exitosamente";
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                return "Error al guardar diagnóstico: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }
        public List<Diagnostico> GetAll()
        {
            listaDiagnosticos = new List<Diagnostico>();
            string query = "SELECT * FROM DIAGNOSTICO";

            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaDiagnosticos.Add(Map(reader));
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CerrarConexion();
            }
            return listaDiagnosticos;
        }

        public Diagnostico GetByID(string codigo)
        {
            listaDiagnosticos = GetAll();
            return listaDiagnosticos.Find(c => c.Codigo == codigo);
        }

        private Diagnostico Map(OracleDataReader reader)
        {
            return new Diagnostico
            {
                Codigo = Convert.ToString(reader["ID_DIAGNOSTICO"]),
                Fecha_Diagnostico = Convert.ToDateTime(reader["FECHA_DIAGNOSTICO"]),
                Descripcion = Convert.ToString(reader["DESCRIPCION"]),
                CodigoCita = Convert.ToString(reader["ID_CITA"]),
                CedulaPaciente = Convert.ToString(reader["CEDULA_P"])
            };
        }

        public string Delete(string codigo)
        {
            string query = "DELETE FROM DIAGNOSTICO WHERE ID_DIAGNOSTICO = :Codigo";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("NumeroDocumento", codigo));
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
    }
}
