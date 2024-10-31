using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DBOrtodoncista : ConexionOracle
    {
        private List<Ortodoncista> listaOrtodoncistas;

        public DBOrtodoncista() { }
        public string SaveData(Ortodoncista ortodoncista)
        {
            string query = "INSERT INTO ORTODONCISTA (CEDULA_O, PRIMER_NOMBRE, SEGUNDO_NOMBRE, PRIMER_APELLIDO, " +
                           "SEGUNDO_APELLIDO, TELEFONO, FECHA_NACIMIENTO, CONTRASENA, ID_CONSULTORIO) " +
                           "VALUES (:Cedula, :PrimerNombre, :SegundoNombre, :PrimerApellido, :SegundoApellido, " +
                           ":Telefono, TO_DATE(:Fecha_De_Nacimiento, 'DD-MM-YYYY'), :Contrasena, :CodigoConsultorio)";

            OracleTransaction transaction = null;

            try
            {
                AbrirConexion();
                transaction = conexion.BeginTransaction();

                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    command.Parameters.Add(new OracleParameter("Cedula", ortodoncista.Cedula));
                    command.Parameters.Add(new OracleParameter("PrimerNombre", ortodoncista.PrimerNombre));
                    command.Parameters.Add(new OracleParameter("SegundoNombre", ortodoncista.SegundoNombre ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("PrimerApellido", ortodoncista.PrimerApellido));
                    command.Parameters.Add(new OracleParameter("SegundoApellido", ortodoncista.SegundoApellido ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Telefono", ortodoncista.Telefono ?? (object)DBNull.Value));
                    command.Parameters.Add(new OracleParameter("Fecha_De_Nacimiento", ortodoncista.Fecha_De_Nacimiento.ToString("dd-MM-yyyy")));
                    command.Parameters.Add(new OracleParameter("Contrasena", ortodoncista.Contrasena));
                    command.Parameters.Add(new OracleParameter("CodigoConsultorio", ortodoncista.CodigoConsultorio));

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

        private Ortodoncista Map(OracleDataReader reader)
        {
            return new Ortodoncista
            {
                Cedula = Convert.ToString(reader["CEDULA_O"]),
                PrimerNombre = Convert.ToString(reader["PRIMER_NOMBRE"]),
                SegundoNombre = Convert.ToString(reader["SEGUNDO_NOMBRE"]),
                PrimerApellido = Convert.ToString(reader["PRIMER_APELLIDO"]),
                SegundoApellido = Convert.ToString(reader["SEGUNDO_APELLIDO"]),
                Telefono = Convert.ToString(reader["TELEFONO"]),
                Fecha_De_Nacimiento = Convert.ToDateTime(reader["FECHA_NACIMIENTO"]),
                Contrasena = Convert.ToString(reader["CONTRASENA"]),
                CodigoConsultorio = Convert.ToString(reader["ID_CONSULTORIO"])
            };
        }

        public List<Ortodoncista> GetAll()
        {
            listaOrtodoncistas = new List<Ortodoncista>();
            string query = "SELECT * FROM ORTODONCISTA";

            try
            {
                using (OracleCommand command = new OracleCommand(query, conexion))
                {
                    AbrirConexion();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaOrtodoncistas.Add(Map(reader));
                        }
                    }
                }
            }
            catch (Exception)
            {
                return new List<Ortodoncista>();
            }
            finally
            {
                CerrarConexion();
            }
            return listaOrtodoncistas;
        }

        public Ortodoncista GetByID(string ID)
        {
            listaOrtodoncistas = GetAll();
            return listaOrtodoncistas.Find(x => x.Cedula == ID);
        }

        public Ortodoncista GetByUser(string ID, string contrasena)
        {
            listaOrtodoncistas = GetAll();
            return listaOrtodoncistas.FirstOrDefault(x => x.Cedula == ID && x.Contrasena == contrasena);
        }
    }
}
