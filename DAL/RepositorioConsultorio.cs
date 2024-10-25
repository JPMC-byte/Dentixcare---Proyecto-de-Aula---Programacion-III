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
    public class RepositorioConsultorio : BaseRepository<Consultorio>
    {
        public RepositorioConsultorio(string fileName) : base(fileName)
        {
            ConsultorioCreado();
        }

        public override List<Consultorio> LoadData()
        {
            try
            {
                List<Consultorio> Consul = new List<Consultorio>();
                string line;
                StreamReader reader = new StreamReader(_fileName);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Consul.Add(Map(line));
                }
                reader.Close();
                return Consul;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        private Consultorio Map(string line)
        {
            var consulto = new Consultorio();
            consulto.Codigo = line.Split(';')[0];
            consulto.Nombre = line.Split(';')[1];
            consulto.Telefono = line.Split(';')[2];
            consulto.Direccion = line.Split(';')[3];

            return consulto;
        }
        public Consultorio GetById(string id)
        {
            return LoadData().FirstOrDefault<Consultorio>(x => x.Codigo == id);
        }

        private void ConsultorioCreado()
        {
            if (!File.Exists(_fileName))
            {
                string Codigo = "P101";
                string Nombre = "DentixCare";
                string telefono = "+57 3053274924";
                string direccion = "Calle 45A #12-34, Barrio San Carlos";
                Consultorio consultorio = new Consultorio(Codigo, Nombre, telefono, direccion);
                SaveData(consultorio);
            }
        }
    }
}
