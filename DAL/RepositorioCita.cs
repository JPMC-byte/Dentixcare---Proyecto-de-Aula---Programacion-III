
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioCita : BaseRepository<Cita>
    {
        public RepositorioCita(string fileName) : base(fileName)
        {
        }

        public override List<Cita> GetAll()
        {
            try
            {
                List<Cita> cita = new List<Cita>();
                string line;
                StreamReader reader = new StreamReader(_fileName);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    cita.Add(Map(line));
                }
                reader.Close();
                return cita;
            }
            catch (Exception ex)
            {
                return new List<Cita>();
            }

        }
        private Cita Map(string line)
        {
            var cita = new Cita();
            cita.Codigo = line.Split(';')[0];
            cita.CodigoConsultorio = line.Split(';')[1];
            cita.CodigoOrtodoncista = line.Split(';')[2];
            cita.CodigoPaciente = line.Split(';')[3];
            cita.Fecha_Cita = DateTime.Parse(line.Split(';')[4]);
            cita.Fecha_Creacion = DateTime.Parse(line.Split(';')[5]);
            cita.Hora_Cita = TimeSpan.Parse(line.Split(';')[6]);
            cita.Razon_Cita = line.Split(';')[7];
            cita.Estado = line.Split(';')[8];
            cita.RecordatorioCita = bool.Parse(line.Split(';')[9]);

            return cita;
        }
        public Cita GetById(string id)
        {
            return GetAll().FirstOrDefault<Cita>(x => x.Codigo == id);
        }
        public Cita GetByIDPaciente(string id)
        {
            return GetAll().FirstOrDefault<Cita>(x => x.CodigoPaciente == id);
        }
        public List<Cita> LoadByID(string id)
        {
            return GetAll().Where(cita => cita.CodigoPaciente == id).ToList();
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
    }
}

