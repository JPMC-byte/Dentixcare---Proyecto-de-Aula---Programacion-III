using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmRealizarDiagnostico : Form
    {
        Persona pacienteActual;
        Cita citaActual;
        ServicioDiagnostico servisDiag = new ServicioDiagnostico();
        public FrmRealizarDiagnostico(Cita cita, Persona paciente)
        {
            InitializeComponent();
            pacienteActual = paciente;
            citaActual = cita;
            CargarDatos(cita,paciente);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void CargarDatos(Cita cita, Persona paciente)
        {
            txtCodigo.Text = servisDiag.GenerarCodigo();
            txtFecha.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            txtCodigoCita.Text = cita.Codigo;
            txtCedula.Text = paciente.Cedula;
        }
        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            Registrar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtDescripcionDiag_Enter(object sender, EventArgs e)
        {
            EventoEntrar();
        }
        private void txtDescripcionDiag_Leave(object sender, EventArgs e)
        {
            EventoSalir();
        }
        private void FrmRealizarDiagnostico_MouseDown(object sender, MouseEventArgs e)
        {
            moverMouse();
        }
        public void Registrar()
        {
            Diagnostico diagnostico = new Diagnostico();
            diagnostico.Codigo = txtCodigo.Text;
            diagnostico.Fecha_Diagnostico = DateTime.Today.Date;
            diagnostico.CodigoCita = citaActual.Codigo;
            diagnostico.CedulaPaciente = pacienteActual.Cedula;
            diagnostico.Descripcion = txtDescripcionDiag.Text;
            servisDiag.Add(diagnostico);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        void cerrar()
        {
            this.Close();
        }
        private void Limpiar()
        {
            txtDescripcionDiag.Text = "DESCRIPCION";
            txtDescripcionDiag.ForeColor = Color.DimGray;
        }
        void EventoEntrar()
        {
            if (txtDescripcionDiag.Text == "DESCRIPCION")
            {
                txtDescripcionDiag.Text = "";
                txtDescripcionDiag.ForeColor = Color.Black;
            }
        }
        void EventoSalir()
        {
            if (txtDescripcionDiag.Text == "")
            {
                txtDescripcionDiag.Text = "DESCRIPCION";
                txtDescripcionDiag.ForeColor = Color.DimGray;
            }
        }
        void moverMouse()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
