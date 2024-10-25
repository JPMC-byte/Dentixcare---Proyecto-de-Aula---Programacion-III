using DAL;
using Entidadeds;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioCita
    {
        RepositorioCita reposCita;

        public ServicioCita()
        {
            reposCita = new RepositorioCita(Config.FILENAME_CITA);
        }
        public string Add(Cita cita)
        {
            return reposCita.SaveData(cita);
        }
        public List<Cita> GetAll()
        {
            return reposCita.LoadData();
        }
    }
}
