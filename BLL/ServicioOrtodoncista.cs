using DAL;
using ENTITY;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioOrtodoncista : ServicioPersona<Ortodoncista>
    {
        //RepositorioOrtodoncista RepsOrto;
        DBOrtodoncista RepsOrto;
        public ServicioOrtodoncista()
        {
            //RepsOrto = new RepositorioOrtodoncista(Config.FILENAME_ORTODONCISTA);
            RepsOrto = new DBOrtodoncista();
        }
        public string Add(Ortodoncista value)
        {
            return RepsOrto.SaveData(value);
        }
        public List<Ortodoncista> GetAll()
        {
            return RepsOrto.GetAll();
        }

        public Ortodoncista GetByID(string ID)
        {
            return RepsOrto.GetByID(ID);
        }

        public Ortodoncista IniciarSesion(string id, string Password)
        {
            return RepsOrto.GetByUser(id, Password);
        }
    }
}
