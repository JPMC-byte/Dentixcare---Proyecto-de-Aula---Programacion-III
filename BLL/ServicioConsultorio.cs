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
        RepositorioConsultorio reposConsul;

        public ServicioConsultorio()
        {
            reposConsul = new RepositorioConsultorio(Config.FILENAME_CONSULTORIO);
        }
        public Consultorio CargarConsultorio(string ID)
        {
            return reposConsul.GetById(ID);
        }
        public List<Consultorio> GetAll()
        {
            return reposConsul.LoadData();
        }
    }
}
