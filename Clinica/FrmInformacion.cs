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
    public partial class FrmInformacion : Form
    {
        Cita citaSeleccionada;
        public FrmInformacion(Cita cita)
        {
            InitializeComponent();
            citaSeleccionada = cita;
            CargarDatos(citaSeleccionada);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void CargarDatos(Cita cita)
        {
            txtCodigo.Text = cita.Codigo;
            txtCedulaPaciente.Text = cita.CodigoPaciente;
            txtCedulaOrtodoncista.Text = cita.CodigoOrtodoncista;
            txtFechaDeCreacion.Text = cita.Fecha_Creacion.ToString("dd/MM/yyyy");
            txtFechaCita.Text = cita.Fecha_Cita.ToString("dd/MM/yyyy");
            txtHoraCita.Text = cita.Hora_Cita.ToString();
            txtRazon.Text = cita.Razon_Cita;
            txtEstado.Text = cita.Estado;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        void Cerrar()
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FrmInformacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
