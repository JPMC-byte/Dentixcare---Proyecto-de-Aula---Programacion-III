using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ENTITY;

namespace DAL
{
    public class RepositorioPaciente : BaseRepository<Paciente>
    {
        public RepositorioPaciente(string fileName) : base(fileName) { }

        public override List<Paciente> GetAll()
        {
            try
            {
                List<Paciente> pacientes = new List<Paciente>();
                string line;
                StreamReader reader = new StreamReader(_fileName);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    pacientes.Add(Map(line));
                }
                reader.Close();
                return pacientes;
            }
            catch (Exception ex)
            {
                return new List<Paciente>();
            }
        }

        private Paciente Map(string line)
        {
            var paciente = new Paciente();
            paciente.CodigoConsultorio = line.Split(';')[0];
            paciente.PrimerNombre = line.Split(';')[1];
            paciente.SegundoNombre = line.Split(';')[2];
            paciente.PrimerApellido = line.Split(';')[3];
            paciente.SegundoApellido = line.Split(';')[4];
            paciente.Cedula = line.Split(';')[5];
            paciente.Telefono = line.Split(';')[6];
            paciente.Fecha_De_Nacimiento = DateTime.Parse(line.Split(';')[7]);
            paciente.Contrasena = line.Split(';')[8];

            return paciente;
        }

        public Paciente GetByUser(string ID, string Password)
        {
            return GetAll().FirstOrDefault(x => x.Cedula == ID && x.Contrasena == Password);
        }

        public Paciente GetByID(string ID)
        {
            return GetAll().FirstOrDefault(x => x.Cedula == ID);
        }
    }
}
