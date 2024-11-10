using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmAgendarCita : Form
    {
        Persona UsuarioActual;
        ServicioCita servisCita = new ServicioCita();
        ServicioConsultorio servisconsulto = new ServicioConsultorio();
        Validaciones vali = new Validaciones();
        public FrmAgendarCita(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !ValidarFecha() || !ValidarFechaFutura() || !ValidarHoraDisponible())
            {
                return;
            }
            Registrar();
        }
        private void Registrar()
        {
            Cita cita = new Cita();
            Consultorio consultorio = new Consultorio();
            consultorio = servisconsulto.CargarConsultorio("P101");

            cita.Codigo = GenerarCodigo();
            cita.CodigoConsultorio = consultorio.Codigo;
            cita.CodigoPaciente = UsuarioActual.Cedula;
            cita.CodigoOrtodoncista = null;
            cita.Fecha_Cita = DTFecha_Nacimiento.Value.Date;
            cita.Fecha_Creacion = DateTime.Today.Date;
            cita.Hora_Cita = DTHora.Value.TimeOfDay;
            cita.Razon_Cita = txtRazonCita.Text;
            cita.Estado = "Solicitada";
            cita.RecordatorioCita = false;
            servisCita.Add(cita);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        private string GenerarCodigo()
        {
            return servisCita.GenerarCodigo();
        }
        bool Verificar()
        {
            if (txtRazonCita.Text == "RAZON DE CITA")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        bool ValidarFecha()
        {
            DateTime fechaCita = DTFecha_Nacimiento.Value.Date;
            TimeSpan horaCita = DTHora.Value.TimeOfDay;
            if (!vali.ValidarHorario(horaCita, fechaCita))
            {
                MessageBox.Show("Error - Ya hay una cita existente en el horario establecido.");
                return false;
            }
            return true;
        }
        bool ValidarFechaFutura()
        {
            DateTime fechaCita = DTFecha_Nacimiento.Value.Date;
            if (!vali.ValidarFechaFutura(fechaCita))
            {
                MessageBox.Show("Error - No es posible agendar una cita en días pasados.");
                return false;
            }
            return true;
        }
        bool ValidarHoraDisponible()
        {
            TimeSpan horaCita = DTHora.Value.TimeOfDay;
            if (!vali.ValidarAperturaCierre(horaCita))
            {
                MessageBox.Show("Error - No es posible agendar una cita en un horario no correspondiente.");
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            txtRazonCita.Text = "RAZON DE CITA";
            txtRazonCita.ForeColor = Color.DimGray;
        }
        private void txtRazonCita_Enter(object sender, EventArgs e)
        {
            EventoEntrar();
        }
        private void txtRazonCita_Leave(object sender, EventArgs e)
        {
            EventoSalir();
        }
        void EventoEntrar()
        {
            if (txtRazonCita.Text == "RAZON DE CITA")
            {
                txtRazonCita.Text = "";
                txtRazonCita.ForeColor = Color.Black;
            }
        }
        void EventoSalir()
        {
            if (txtRazonCita.Text == "")
            {
                txtRazonCita.Text = "RAZON DE CITA";
                txtRazonCita.ForeColor = Color.DimGray;
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }
    }
}
