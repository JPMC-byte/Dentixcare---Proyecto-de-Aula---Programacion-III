using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ServicioTratamiento
    {
        private DBTratamiento reposTratamiento;

        public ServicioTratamiento()
        {
            reposTratamiento = new DBTratamiento();
        }

        public string Add(Tratamiento tratamiento)
        {
            return reposTratamiento.SaveData(tratamiento);
        }

        public List<Tratamiento> GetAll()
        {
            return reposTratamiento.GetAll();
        }

        public Tratamiento GetByID(string id)
        {
            return reposTratamiento.GetByID(id);
        }

        public string Delete(string id)
        {
            return reposTratamiento.Delete(id);
        }

        public string GenerarCodigo()
        {
            List<Tratamiento> tratamientosExistentes = GetAll();
            string nuevoCodigo;

            if (tratamientosExistentes == null || tratamientosExistentes.Count == 0)
            {
                nuevoCodigo = "T001";
            }
            else
            {
                Tratamiento ultimoTratamiento = tratamientosExistentes.Last();
                int ultimoCodigoNumerico = int.Parse(ultimoTratamiento.ID_Tratamiento.Substring(1));
                nuevoCodigo = "T" + (ultimoCodigoNumerico + 1).ToString().PadLeft(3, '0');
            }
            return nuevoCodigo;
        }

        public string UpdateDescripcion(Tratamiento tratamiento, string nuevaDescripcion)
        {
            List<Tratamiento> tratamientos = GetAll();
            Tratamiento tratamientoAModificar = tratamientos.Find(t => t.ID_Tratamiento == tratamiento.ID_Tratamiento);
            tratamientoAModificar.Descripcion = nuevaDescripcion;
            return reposTratamiento.SaveData(tratamientoAModificar);

        }

        public string UpdateCosto(Tratamiento tratamiento, double nuevoCosto)
        {
            List<Tratamiento> tratamientos = GetAll();
            Tratamiento tratamientoAModificar = tratamientos.Find(t => t.ID_Tratamiento == tratamiento.ID_Tratamiento);
            tratamientoAModificar.Costo = nuevoCosto;
            return reposTratamiento.SaveData(tratamientoAModificar); 

        }
    }
}
