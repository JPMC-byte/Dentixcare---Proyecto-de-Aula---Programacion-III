using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ENTITY;
using Entidadeds;

namespace BLL
{
    public class Validaciones
    {
        ServicioPaciente servicioPaciente = new ServicioPaciente();
        ServicioOrtodoncista servicioOrtodoncista = new ServicioOrtodoncista();
        ServicioCita servicioCita = new ServicioCita();
        public Validaciones() { }
        public bool ValidarLetras(string Texto)
        {
            string Patron = @"^[a-zA-ZñÑ\s]+$";
            return Regex.IsMatch(Texto, Patron);
        }

        public bool ValidarNumeros(string Texto)
        {
            string Patron = @"^[0-9]+$";
            return Regex.IsMatch(Texto, Patron);
        }
        public bool ValidarExistentePaciente(string Texto)
        {
            Paciente paciente = new Paciente();
            paciente = servicioPaciente.GetByID(Texto);

            if (paciente == null)
            {
                return true; 
            }
            return false;
        }
        public bool ValidarExistenteOrtodoncista(string Texto)
        {
            Ortodoncista ortodoncista = new Ortodoncista();
            ortodoncista = servicioOrtodoncista.GetByID(Texto);

            if (ortodoncista == null)
            {
                return true;
            }
            return false;
        }
        public bool ValidarHorario(TimeSpan Hora, DateTime Dia)
        {
            TimeSpan duracionCita = new TimeSpan(1, 0, 0); 
            TimeSpan finNuevaCita = Hora.Add(duracionCita);
            List<Cita> listaCitas = new List<Cita>();
            listaCitas = servicioCita.GetAll();

            if (listaCitas.Count == 0 || listaCitas == null)
            {
                return true;
            }

            foreach (var cita in listaCitas)
            {
                if (cita.Fecha_Cita.Date == Dia.Date)
                {
                    TimeSpan finCitaExistente = cita.Hora_Cita.Add(duracionCita);

                    bool haySuperposicion = (Hora < finCitaExistente) && (finNuevaCita > cita.Hora_Cita);

                    if (haySuperposicion)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
