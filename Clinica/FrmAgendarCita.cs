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
        Validaciones vali = new Validaciones();
        public FrmAgendarCita(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            Registrar();
        }
        private void Registrar()
        {
            if (!Verificar() || !ValidarFecha())
            {
                return;
            }
            Cita cita = new Cita();
            cita.Codigo = GenerarCodigo();
            cita.CodigoPaciente = UsuarioActual.Cedula;
            cita.CodigoOrtodoncista = "No asignado";
            cita.Fecha_Cita = DTFecha_Nacimiento.Value.Date;
            cita.Fecha_Creacion = DateTime.Today.Date;
            cita.Hora_Cita = DTHora.Value.TimeOfDay;
            cita.Razon_Cita = txtRazonCita.Text;
            cita.Estado = "Solicitada";
            servisCita.Add(cita);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        private string GenerarCodigo()
        {
            List<Cita> citasExistentes = servisCita.GetAll();
            string nuevoCodigo;

            if (citasExistentes.Count == 0 ||citasExistentes == null)
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
        private void Limpiar()
        {
            txtRazonCita.Text = "RAZON DE CITA";
            txtRazonCita.ForeColor = Color.DimGray;
        }
        private void txtRazonCita_Enter(object sender, EventArgs e)
        {
            if (txtRazonCita.Text == "RAZON DE CITA")
            {
                txtRazonCita.Text = "";
                txtRazonCita.ForeColor = Color.Black;
            }
        }
        private void txtRazonCita_Leave(object sender, EventArgs e)
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
    }
}
