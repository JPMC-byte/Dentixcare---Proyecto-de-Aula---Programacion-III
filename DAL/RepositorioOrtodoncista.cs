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
    public class RepositorioOrtodoncista : BaseRepository<Ortodoncista>
    {
        public RepositorioOrtodoncista(string fileName) : base(fileName)
        {
        }

        public override List<Ortodoncista> LoadData()
        {
            try
            {
                List<Ortodoncista> ortodon = new List<Ortodoncista>();
                string line;
                StreamReader reader = new StreamReader(_fileName);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    ortodon.Add(Map(line));
                }
                reader.Close();
                return ortodon;
            }
            catch (Exception ex)
            {
                return new List<Ortodoncista>();
            }

        }
        private Ortodoncista Map(string line)
        {
            var ortodon = new Ortodoncista();
            ortodon.CodigoConsultorio = line.Split(',')[0];
            ortodon.Nombre = line.Split(';')[1];
            ortodon.Apellido = line.Split(';')[2];
            ortodon.Cedula = line.Split(';')[3];
            ortodon.Telefono = line.Split(';')[4];
            ortodon.Fecha_De_Nacimiento = DateTime.Parse(line.Split(';')[5]);
            ortodon.Edad = int.Parse(line.Split(';')[6]);
            ortodon.Contrasena = line.Split(';')[7];

            return ortodon;
        }
        public Ortodoncista GetByUser(string id, string Password)
        {
            return LoadData().FirstOrDefault<Ortodoncista>(x => x.Cedula == id && x.Contrasena == Password);
        }
        public Ortodoncista getByID(string ID)
        {
            return LoadData().FirstOrDefault<Ortodoncista>(x => x.Cedula == ID);
        }
    }
}

