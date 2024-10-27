using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class RepositorioDiagnostico : BaseRepository<Diagnostico>
    {
        public RepositorioDiagnostico(string fileName) : base(fileName)
        {

        }

        public override List<Diagnostico> LoadData()
        {
            try
            {
                List<Diagnostico> Diag = new List<Diagnostico>();
                string line;
                StreamReader reader = new StreamReader(_fileName);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Diag.Add(Map(line));
                }
                reader.Close();
                return Diag;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        private Diagnostico Map(string line)
        {
            var diag = new Diagnostico();
            diag.Codigo = line.Split(';')[0];
            diag.Descripcion = line.Split(';')[1];
            diag.Fecha_Diagnostico = DateTime.Parse(line.Split(';')[2]);
            diag.CodigoCita = line.Split(';')[3];
            diag.CedulaPaciente = line.Split(';')[4];
            return diag;
        }
        public Diagnostico GetById(string id)
        {
            return LoadData().FirstOrDefault<Diagnostico>(x => x.Codigo == id);
        }
    }
}
