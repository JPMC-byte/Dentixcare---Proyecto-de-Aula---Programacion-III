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
    public partial class FrmActualizarCita : Form
    {
        ServicioCita serviscita = new ServicioCita();
        Cita CitaActual;
        public FrmActualizarCita(Cita cita)
        {
            InitializeComponent();
            CitaActual = cita;
        }
        private void FrmActualizarCita_Load(object sender, EventArgs e)
        {
            CargarDatos(CitaActual);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            if (Confirmar())
            {
                Actualizar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtRazonCita_Enter(object sender, EventArgs e)
        {
            eventoEnter();
        }
        private void txtRazonCita_Leave(object sender, EventArgs e)
        {
            eventoSalir();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void eventoEnter()
        {
            if (txtRazonCita.Text == "RAZON DE CITA")
            {
                txtRazonCita.Text = "";
                txtRazonCita.ForeColor = Color.Black;
            }
        }
        void eventoSalir()
        {
            if (txtRazonCita.Text == "")
            {
                txtRazonCita.Text = "RAZON DE CITA";
                txtRazonCita.ForeColor = Color.DimGray;
            }
        }
        void cerrar()
        {
            this.Close();
        }
        private void CargarDatos(Cita cita)
        {
            txtHora.Text = cita.Hora_Cita.ToString();
            txtFecha.Text = cita.Fecha_Cita.ToString("dd/MM/yyyy");
        }
        void Actualizar()
        {
            string RazonCita = txtRazonCita.Text;
            serviscita.UpdateRazon(CitaActual, RazonCita);
            MessageBox.Show("Proceso de modificación exitoso");
            Limpiar();
        }
        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea actualizar dicha cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        bool Verificar()
        {
            if (txtRazonCita.Text == "RAZON DE CITA")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            if (txtRazonCita.Text == CitaActual.Razon_Cita)
            {
                MessageBox.Show("Error - No es posible actualizar si no se realiza alguna modificación correspondiente.");
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            txtRazonCita.Text = "RAZON DE CITA";
            txtRazonCita.ForeColor = Color.DimGray;
        }
    }
}
