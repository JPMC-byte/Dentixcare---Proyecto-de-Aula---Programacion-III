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
        public string UpdateDescripcion(Tratamiento tratamiento, string nuevaDescripcion)
        {
            Tratamiento tratamientoAModificar = GetByID(tratamiento.ID_Tratamiento);
            tratamientoAModificar.Descripcion = nuevaDescripcion;
            return reposTratamiento.Update(tratamientoAModificar);

        }
        public string UpdateCosto(Tratamiento tratamiento, double nuevoCosto)
        {
            Tratamiento tratamientoAModificar = GetByID(tratamiento.ID_Tratamiento);
            tratamientoAModificar.Costo = nuevoCosto;
            return reposTratamiento.Update(tratamientoAModificar);
        }
        public string UpdateFKDiagnostico(Tratamiento tratamiento, string Codigo)
        {
            Tratamiento tratamientoAModificar = GetByID(tratamiento.ID_Tratamiento);
            tratamientoAModificar.CodigoDiagnostico = Codigo;
            return reposTratamiento.Update(tratamientoAModificar);
        }
        public string UpdateFKFactura(Tratamiento tratamiento, string Codigo)
        {
            Tratamiento tratamientoAModificar = GetByID(tratamiento.ID_Tratamiento);
            tratamientoAModificar.CodigoFactura = Codigo;
            return reposTratamiento.Update(tratamientoAModificar);
        }
        public List<Tratamiento> LoadByFactura(string codigo)
        {
            return reposTratamiento.LoadByFactura(codigo);
        }
        public List<Tratamiento> LoadByDiagnostico(string codigo)
        {
            return reposTratamiento.LoadByDiagnostico(codigo);
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
        public string obtenerFacturaRelacionada(string codigoDiagnostico)
        {
            List<Tratamiento> tratamientos = LoadByDiagnostico(codigoDiagnostico);
            if (tratamientos.Count > 0)
            {
                return tratamientos[0].CodigoFactura;
            }
            return "No se encontró factura relacionada";
        }
    }
}
