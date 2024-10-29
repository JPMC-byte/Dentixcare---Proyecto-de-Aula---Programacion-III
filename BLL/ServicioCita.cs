using DAL;
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
        public Cita GetByIDPaciente(string id)
        {
            return reposCita.GetByIDPaciente(id);
        }
        public List<Cita> LoadByID(string id)
        {
            return reposCita.LoadByID(id);
        }
        public List<Cita> LoadByEstado(string Estado)
        {
            return reposCita.LoadByEstado(Estado);
        }
        public List<Cita> LoadByFilters(string Estado, string Cedula)
        {
            return reposCita.LoadFilters(Estado, Cedula);
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
        public string UpdateRazon(Cita cita, string RazonCita)
        {
            List<Cita> Citas = GetAll();
            Cita CitaAModificar = Citas.Find(CitaABuscar => CitaABuscar.Codigo == cita.Codigo);
            CitaAModificar.Razon_Cita = RazonCita;
            return reposCita.SaveData(Citas);
        }
        public string UpdateAtendida(Cita cita, string CodigoOrtodoncista, string estado)
        {
            List<Cita> Citas = GetAll();
            Cita CitaAModificar = Citas.Find(CitaABuscar => CitaABuscar.Codigo == cita.Codigo);
            CitaAModificar.CodigoOrtodoncista = CodigoOrtodoncista;
            CitaAModificar.Estado = estado;
            return reposCita.SaveData(Citas);
        }

        public string Delete(Cita cita)
        {
            List<Cita> Citas = GetAll();
            Citas.RemoveAll(CitaAEliminar => CitaAEliminar.Codigo == cita.Codigo);
            return reposCita.SaveData(Citas);
        }
    }
}
