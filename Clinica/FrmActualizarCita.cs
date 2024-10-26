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
            CargarDatos(CitaActual);
        }

        private void CargarDatos(Cita cita)
        {
            txtHora.Text = cita.Hora_Cita.ToString();
            txtFecha.Text = cita.Fecha_Cita.ToString("dd/MM/yyyy");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            Actualizar();
        }
        void Actualizar()
        {
            string RazonCita = txtRazonCita.Text;
            serviscita.Update(CitaActual, RazonCita);
            MessageBox.Show("Proceso de modificación exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtRazonCita.Text == "RAZON DE CITA" )
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
