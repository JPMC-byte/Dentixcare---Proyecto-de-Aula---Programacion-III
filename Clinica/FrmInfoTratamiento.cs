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
    public partial class FrmInfoTratamiento : Form
    {
        Tratamiento tratamientoActual;
        public FrmInfoTratamiento(Tratamiento tratamiento)
        {
            InitializeComponent();
            tratamientoActual = tratamiento;
            cargarDatos(tratamientoActual);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmInfoTratamiento_MouseDown(object sender, MouseEventArgs e)
        {
            moverCursor();
        }
        public void cargarDatos(Tratamiento tratamiento)
        {
            txtCodigo.Text = tratamiento.ID_Tratamiento;
            txtCosto.Text = tratamiento.Costo.ToString();
            txtDescripcion.Text = tratamiento.Descripcion;
            txtDuracion.Text = tratamiento.Duracion;

            if (tratamiento.CodigoDiagnostico == "" && tratamiento.CodigoFactura == "")
            {
                txtCodigoDiag.Text = "No asignado";
                txtCodigoFactura.Text = "No asignado";
            }
            else
            {
                txtCodigoDiag.Text = tratamiento.CodigoDiagnostico;
                txtCodigoFactura.Text = tratamiento.CodigoFactura;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        void cerrar()
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
