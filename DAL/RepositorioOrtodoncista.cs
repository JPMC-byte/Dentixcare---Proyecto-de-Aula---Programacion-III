using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class RepositorioOrtodoncista : BaseRepository<Ortodoncista>
    {
        public RepositorioOrtodoncista(string fileName) : base(fileName) { }

        public override List<Ortodoncista> GetAll()
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
            ortodon.CodigoConsultorio = line.Split(';')[0];
            ortodon.PrimerNombre = line.Split(';')[1];
            ortodon.SegundoNombre = line.Split(';')[2];
            ortodon.PrimerApellido = line.Split(';')[3];
            ortodon.SegundoApellido = line.Split(';')[4];
            ortodon.Cedula = line.Split(';')[5];
            ortodon.Telefono = line.Split(';')[6];
            ortodon.Fecha_De_Nacimiento = DateTime.Parse(line.Split(';')[7]);
            ortodon.Contrasena = line.Split(';')[8];

            return ortodon;
        }

        public Ortodoncista GetByUser(string id, string Password)
        {
            return GetAll().FirstOrDefault(x => x.Cedula == id && x.Contrasena == Password);
        }

        public Ortodoncista GetByID(string ID)
        {
            return GetAll().FirstOrDefault(x => x.Cedula == ID);
        }
    }
}
