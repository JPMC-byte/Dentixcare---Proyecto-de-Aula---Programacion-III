using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ServicioDiagnostico
    {
        private DBDiagnostico reposDiagnostico;

        public ServicioDiagnostico()
        {
            reposDiagnostico = new DBDiagnostico();
        }

        public string Add(Diagnostico diagnostico)
        {
            return reposDiagnostico.SaveData(diagnostico);
        }

        public List<Diagnostico> GetAll()
        {
            return reposDiagnostico.GetAll();
        }

        public Diagnostico GetByID(string codigo)
        {
            return reposDiagnostico.GetByID(codigo);
        }

        public string Delete(string codigo)
        {
            return reposDiagnostico.Delete(codigo);
        }
        public string Update(Diagnostico diagnostico, string diagnosticoDescripcion)
        {
            Diagnostico diagnosticoAModificar = GetByID(diagnostico.Codigo);
            diagnosticoAModificar.Descripcion = diagnosticoDescripcion;
            return reposDiagnostico.Update(diagnosticoAModificar);
        }
        public List<Diagnostico> LoadByCedula(string codigo) 
        {
            return reposDiagnostico.LoadByCedula(codigo);
        }
        public List<Diagnostico> LoadByFecha(DateTime fecha)
        {
            return reposDiagnostico.LoadByFecha(fecha);
        }
        public List<Diagnostico> LoadByFilters(DateTime fecha, string IDPaciente)
        {
            return reposDiagnostico.LoadFilters(fecha, IDPaciente);
        }
        public string GenerarCodigo()
        {
            List<Diagnostico> diagnosticosExistentes = GetAll();
            string nuevoCodigo;

            if (diagnosticosExistentes == null || diagnosticosExistentes.Count == 0)
            {
                nuevoCodigo = "D001";
            }
            else
            {
                Diagnostico ultimoDiagnostico = diagnosticosExistentes.Last();
                int ultimoCodigoNumerico = int.Parse(ultimoDiagnostico.Codigo);
                nuevoCodigo = 'D' + (ultimoCodigoNumerico + 1).ToString().PadLeft(3, '0');
            }

            return nuevoCodigo;
        }
    }
}
