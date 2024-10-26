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
        public Cita GetByID(string id) 
        {
            return reposCita.GetById(id);
        }
        public List<Cita> LoadByID(string id)
        {
            return reposCita.LoadByID(id);
        }
        public string GenerarCodigo()
        {
            List<Cita> citasExistentes = GetAll();
            string nuevoCodigo;

            if (citasExistentes.Count == 0 || citasExistentes == null)
            {
                nuevoCodigo = "001";
            }
            else
            {
                Cita ultimaCita = citasExistentes.Last();
                int ultimoCodigoNumerico = int.Parse(ultimaCita.Codigo);
                nuevoCodigo = (ultimoCodigoNumerico + 1).ToString().PadLeft(3, '0');
            }
            return nuevoCodigo;
        }

        public string Update(Cita cita, string RazonCita)
        {
            List<Cita> Citas = GetAll();
            Cita CitaAModificar = Citas.Find(CitaABuscar => CitaABuscar.Codigo == cita.Codigo);
            CitaAModificar.Razon_Cita = RazonCita;
            return reposCita.SaveData(Citas);
        }

    }
}
