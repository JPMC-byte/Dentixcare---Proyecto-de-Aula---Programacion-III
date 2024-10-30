﻿using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace DAL
{
    public class DBCita : ConexionOracle
    {
        private List<Cita> listaCitas;

        public DBCita() { }
        public string SaveData(Cita cita)
        {
            string query = "INSERT INTO CITA (ID_CITA, RAZON_CITA, FECHA_CREACION, FECHA_CITA, HORA_CITA, ESTADO, RECORDATORIO_CITA, CEDULA_O, CEDULA_P, ID_CONSULTORIO, ID_CHATBOT) " +
                           "VALUES (:Codigo, :Razon_Cita, :Fecha_Creacion, :Fecha_Cita, :Hora_Cita, :Estado, :Recordatorio_Cita, :CodigoOrtodoncista, :CodigoPaciente, :CodigoConsultorio, :CodigoChatbot)";

            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Codigo", cita.Codigo));
                    command.Parameters.Add(new OracleParameter("Razon_Cita", cita.Razon_Cita));
                    command.Parameters.Add(new OracleParameter("Fecha_Creacion", cita.Fecha_Creacion));
                    command.Parameters.Add(new OracleParameter("Fecha_Cita", cita.Fecha_Cita));
                    command.Parameters.Add(new OracleParameter("Hora_Cita", cita.Hora_Cita));
                    command.Parameters.Add(new OracleParameter("Estado", cita.Estado ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Recordatorio_Cita", cita.RecordatorioCita ? '1' : '0'));
                    command.Parameters.Add(new OracleParameter("CodigoOrtodoncista", cita.CodigoOrtodoncista ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("CodigoPaciente", cita.CodigoPaciente));
                    command.Parameters.Add(new OracleParameter("CodigoConsultorio", cita.CodigoConsultorio));
                    command.Parameters.Add(new OracleParameter("CodigoChatbot", cita.CodigoChatbot ?? (object)DBNull.Value));
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                return "Cita registrada exitosamente";
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

        private Cita Map(OracleDataReader reader)
        {
            return new Cita
            {
                Codigo = Convert.ToString(reader["ID_CITA"]),
                Razon_Cita = Convert.ToString(reader["RAZON_CITA"]),
                Fecha_Creacion = Convert.ToDateTime(reader["FECHA_CREACION"]),
                Fecha_Cita = Convert.ToDateTime(reader["FECHA_CITA"]),
                Hora_Cita = (TimeSpan)reader["HORA_CITA"],
                Estado = Convert.ToString(reader["ESTADO"]),
                RecordatorioCita = Convert.ToString(reader["RECORDATORIO_CITA"]) == "1",
                CodigoOrtodoncista = Convert.ToString(reader["CEDULA_O"]),
                CodigoPaciente = Convert.ToString(reader["CEDULA_P"]),
                CodigoConsultorio = Convert.ToString(reader["ID_CONSULTORIO"]),
                CodigoChatbot = Convert.ToString(reader["ID_CHATBOT"])
            };
        }

        public List<Cita> GetAll()
        {
            listaCitas = new List<Cita>();
            string query = "SELECT * FROM CITAS";

            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCitas.Add(Map(reader));
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
            return listaCitas;
        }

        public Cita GetByID(string codigo)
        {
            return GetAll().FirstOrDefault<Cita>(x => x.Codigo == codigo);
        }
        public Cita GetByIDPaciente(string codigo)
        {
            return GetAll().FirstOrDefault<Cita>(x => x.CodigoPaciente == codigo);
        }
        public List<Cita> LoadByID(string codigo)
        {
            return GetAll().Where(cita => cita.CodigoPaciente == codigo).ToList();
        }
        public List<Cita> LoadByEstado(string estado)
        {
            return GetAll().Where(cita => cita.Estado == estado).ToList();
        }
        public List<Cita> LoadFilters(string estado, string cedulaPaciente)
        {
            List<Cita> Citas = GetAll();
            Citas = Citas.Where(cita => cita.Estado == estado).ToList();
            Citas = Citas.Where(cita => cita.CodigoPaciente == cedulaPaciente).ToList();
            return Citas;
        }
        public string Modify(Cita cita)
        {
            string query = "UPDATE CITA SET " + 
                           "RAZON_CITA = :RazonCita, " +
                           "FECHA_CREACION = TO_DATE(:FechaCreacion, 'DD-MM-YYYY'), " +
                           "FECHA_CITA = TO_DATE(:FechaCita, 'DD-MM-YYYY'), " +
                           "HORA_CITA = :HoraCita, " + 
                           "ESTADO = :Estado, " + 
                           "RECORDATORIO_CITA = :RecordatorioCita, " +
                           "CEDULA_O = :CodigoOrtodoncista, " + 
                           "CEDULA_P = :CodigoPaciente, " +
                           "ID_CONSULTORIO = :CodigoConsultorio, " +
                           "ID_CHATBOT = :CodigoChatbot " +
                           "WHERE ID_CITA = :Codigo";

            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Codigo", cita.Codigo));
                    command.Parameters.Add(new OracleParameter("Razon_Cita", cita.Razon_Cita));
                    command.Parameters.Add(new OracleParameter("Fecha_Creacion", cita.Fecha_Creacion));
                    command.Parameters.Add(new OracleParameter("Fecha_Cita", cita.Fecha_Cita));
                    command.Parameters.Add(new OracleParameter("Hora_Cita", cita.Hora_Cita));
                    command.Parameters.Add(new OracleParameter("Estado", cita.Estado ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Recordatorio_Cita", cita.RecordatorioCita ? '1' : '0'));
                    command.Parameters.Add(new OracleParameter("CodigoOrtodoncista", cita.CodigoOrtodoncista ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("CodigoPaciente", cita.CodigoPaciente));
                    command.Parameters.Add(new OracleParameter("CodigoConsultorio", cita.CodigoConsultorio));
                    command.Parameters.Add(new OracleParameter("CodigoChatbot", cita.CodigoChatbot ?? (object)DBNull.Value));
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
                return "Registro modificado";
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
        public string Delete(string codigo)
        {
            string query = "DELETE FROM CITA WHERE ID_CITA = :Codigo";
            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("ID_CITA", codigo));
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