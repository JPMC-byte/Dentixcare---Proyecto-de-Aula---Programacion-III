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

namespace GUI
{
    public partial class FrmInfoDiagnostico : Form
    {
        Diagnostico diagnosticoActual;
        public FrmInfoDiagnostico(Diagnostico diagnostico)
        {
            InitializeComponent();
            diagnosticoActual = diagnostico;
            CargarDatos(diagnosticoActual);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmInfoDiagnostico_MouseDown(object sender, MouseEventArgs e)
        {
            moverCursor();
        }
        public void CargarDatos(Diagnostico diagnostico) 
        { 
            txtCodigo.Text = diagnostico.Codigo;
            txtCodigoCita.Text = diagnostico.CodigoCita;
            txtCedulaPaciente.Text = diagnostico.CedulaPaciente;
            txtFecha.Text = diagnostico.Fecha_Diagnostico.ToString("dd/MM/yyyy");
            txtDescripcion.Text = diagnostico.Descripcion;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        void Cerrar()
        {
            this.Close();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void moverCursor()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
