using Entidadeds;
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

        public override List<Cita> LoadData()
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
                return null;
            }

        }
        private Cita Map(string line)
        {
            var cita = new Cita();
            cita.Codigo = line.Split(',')[0];
            cita.CodigoOrtodoncista = line.Split(';')[1];
            cita.CodigoPaciente = line.Split(';')[2];
            cita.Fecha_Cita = DateTime.Parse(line.Split(';')[3]);
            cita.Fecha_Creacion = DateTime.Parse(line.Split(';')[4]);
            cita.Hora_Cita = TimeSpan.Parse(line.Split(';')[5]);
            cita.Razon_Cita = line.Split(';')[6];
            cita.Estado = line.Split(';')[7];

            return cita;
        }
        public Cita GetById(string id)
        {
            return LoadData().FirstOrDefault<Cita>(x => x.Codigo == id);
        }
    }
}

