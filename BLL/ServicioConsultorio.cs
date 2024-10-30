using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioConsultorio
    {
        DBConsultorio reposConsul;

        public ServicioConsultorio()
        {
            //reposConsul = new RepositorioConsultorio(Config.FILENAME_CONSULTORIO);
            reposConsul = new DBConsultorio();
        }
        public Consultorio CargarConsultorio(string ID)
        {
            return reposConsul.GetByID(ID);
        }
        public List<Consultorio> GetAll()
        {
            return reposConsul.GetAll();
        }
    }
}
