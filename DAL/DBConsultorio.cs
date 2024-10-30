using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class DBConsultorio : ConexionOracle
    {
        private List<Consultorio> listaConsultorios;
        public DBConsultorio() { ConsultorioCreado(); }
        public string SaveData(Consultorio consultorio)
        {
            string query = "INSERT INTO CONSULTORIO (ID_CONSULTORIO, NOMBRE_CONSULTORIO, BARRIO, ETAPA, MANZANA, CALLE, TELEFONO, HORA_APERTURA, HORA_CIERRE) " +
                           "VALUES (:Codigo, :Nombre, :Barrio, :Etapa, :Manzana, :Calle, :Telefono, :Hora_Apertura, :Hora_Cierre)";

            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Codigo", consultorio.Codigo));
                    command.Parameters.Add(new OracleParameter("Nombre", consultorio.Nombre));
                    command.Parameters.Add(new OracleParameter("Barrio", consultorio.Barrio ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Etapa", consultorio.Etapa ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Manzana", consultorio.Manzana ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Calle", consultorio.Calle ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Telefono", consultorio.Telefono ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Hora_Apertura", consultorio.Hora_Apertura));
                    command.Parameters.Add(new OracleParameter("Hora_Cierre", consultorio.Hora_Cierre));

                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                return "Registro exitoso";
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

        private Consultorio Map(OracleDataReader reader)
        {
            return new Consultorio
            {
                Codigo = Convert.ToString(reader["ID_CONSULTORIO"]),
                Nombre = Convert.ToString(reader["NOMBRE_CONSULTORIO"]),
                Telefono = Convert.ToString(reader["TELEFONO"]),
                Barrio = Convert.ToString(reader["BARRIO"]),
                Etapa = Convert.ToString(reader["ETAPA"]),
                Manzana = Convert.ToString(reader["MANZANA"]),
                Calle = Convert.ToString(reader["CALLE"]),
                Hora_Apertura = (TimeSpan)reader["HORA_APERTURA"],
                Hora_Cierre = (TimeSpan)reader["HORA_CIERRE"]
            };
        }

        public List<Consultorio> GetAll()
        {
            listaConsultorios = new List<Consultorio>();
            string query = "SELECT * FROM CONSULTORIO";

            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaConsultorios.Add(Map(reader));
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
            return listaConsultorios;
        }

        public Consultorio GetByID(string codigo)
        {
            return GetAll().Find(x => x.Codigo == codigo);
        }
        private void ConsultorioCreado()
        {
            string codigo = "P101";
            string nombre = "DentixCare";
            string telefono = "+57 3053274924";
            string barrio = "San Carlos";
            string etapa = "Etapa 5";
            string manzana = "Manzana 12";
            string calle = "Calle 45A #12-34";
            TimeSpan horaApertura = new TimeSpan(8, 0, 0);
            TimeSpan horaCierre = new TimeSpan(18, 0, 0);

            var consultorioExistente = GetByID(codigo);

            if (consultorioExistente == null)
            {
                Consultorio consultorio = new Consultorio(codigo, nombre, telefono, barrio, etapa, manzana, calle, horaApertura, horaCierre);
                string resultado = SaveData(consultorio);
            }
        }
    }
}
