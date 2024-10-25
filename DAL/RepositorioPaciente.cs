using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace DAL
{
    public class RepositorioPaciente : BaseRepository<Paciente>
    {
        public RepositorioPaciente(string fileName) : base(fileName)
        {
        }

        public override List<Paciente> LoadData()
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
                return null;
            }

        }
        private Paciente Map(string line)
        {
            var paciente = new Paciente();
            paciente.CodigoConsultorio = line.Split(',')[0];
            paciente.Nombre = line.Split(';')[1];
            paciente.Apellido = line.Split(';')[2];
            paciente.Cedula = line.Split(';')[3];
            paciente.Telefono = line.Split(';')[4];
            paciente.Fecha_De_Nacimiento = DateTime.Parse(line.Split(';')[5]);
            paciente.Edad = int.Parse(line.Split(';')[6]);
            paciente.Contrasena = line.Split(';')[7];

            return paciente;
        }
        public Paciente GetByUser(string ID, string Password)
        {
            return LoadData().FirstOrDefault<Paciente>(x => x.Cedula == ID && x.Contrasena == Password);
        }

        public Paciente getByID(string ID)
        {
            return LoadData().FirstOrDefault<Paciente>(x => x.Cedula == ID);
        }
    }
}
