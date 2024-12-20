﻿using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ENTITY;
using System.Windows.Forms;

namespace BLL
{
    public class Validaciones
    {
        ServicioPaciente servicioPaciente = new ServicioPaciente();
        ServicioOrtodoncista servicioOrtodoncista = new ServicioOrtodoncista();
        ServicioCita servicioCita = new ServicioCita();
        ServicioConsultorio servicioConsultorio = new ServicioConsultorio();
        ServicioTratamiento servicioTratamiento = new ServicioTratamiento();
        public Validaciones() { }
        public bool ValidarTeclasControl(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return true;
            }
            return false;
        }
        public bool ValidarLetras(KeyPressEventArgs e)
        {
            if (ValidarTeclasControl(e)) return true;
            string Patron = @"^[a-zA-ZñÑ\s]$";
            bool esValido = Regex.IsMatch(e.KeyChar.ToString(), Patron);
            return esValido;
        }
        public bool ValidarNumeros(KeyPressEventArgs e)
        {
            if (ValidarTeclasControl(e)) return true;
            string Patron = @"^[0-9]$";
            bool esValido = Regex.IsMatch(e.KeyChar.ToString(), Patron);
            return esValido;
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
        public bool ValidarExistenteFactura(string Texto)
        {
            List<Tratamiento> lista = new List<Tratamiento>();
            lista = servicioTratamiento.LoadByDiagnostico(Texto);
            if (lista.Count > 0)
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
        public bool ValidarFechaFutura(DateTime fechaCita)
        {
            return fechaCita.Date > DateTime.Now.Date;
        }

        public bool ValidarAperturaCierre(TimeSpan Hora)
        {
            Consultorio consul = new Consultorio();
            consul = servicioConsultorio.CargarConsultorio("P101");

            bool horaNoDisponibilidad = (Hora < consul.Hora_Apertura) || (Hora > consul.Hora_Cierre);
            if (horaNoDisponibilidad)
            {
                return false;
            }
            return true;
        }
        public bool ValidarSegundos(string Texto)
        {
            if (Texto == "SEGUNDO NOMBRE")
            {
                return false;
            }
            if (Texto == "SEGUNDO APELLIDO")
            {
                return false;
            }
            return true;
        }
        public bool ValidarAtendida(string texto)
        {
            if (texto == "Pendiente" || texto == "Finalizada")
            {
                return false;
            }
            return true;
        }
        public bool ValidarFiltroEstado(bool activo,string texto)
        {
            if (!activo || texto == "N/A")
            {
                return false;
            }
            return true;
        }
        public bool ValidarFiltroPaciente(bool activo, string texto)
        {
            Cita cita = servicioCita.GetByIDPaciente(texto);
            Paciente paciente = servicioPaciente.GetByID(texto);
            if (!activo || texto == "CEDULA DEL PACIENTE" || cita == null || paciente == null)
            {
                return false;
            }
            return true;
        }
        public bool ValidarFiltroFecha(bool activo, DateTime fecha)
        {
            if (!activo || fecha.Date > DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }
        public bool ValidarTratamientoAsignado(Tratamiento tratamiento)
        {
            if (tratamiento.CodigoDiagnostico == "" || tratamiento.CodigoFactura == "")
            {
                return false;
            }
            return true;
        }
        public bool ValidarMonto(double monto)
        {
            if(monto <= 0)
            {
                return false;
            }
            return true;
        }
        public bool ValidarFacturaPagada(Factura factura)
        {
            if (factura.Total_Pagado >= factura.Total || factura.Estado == "Finalizada")
            {
                return true;
            }
            return false;
        }
        public bool ValidarMetodoPago(string texto)
        {
            if(texto == "" || texto == "N/A")
            {
                return false;
            }
            return true;
        }
    }
}
