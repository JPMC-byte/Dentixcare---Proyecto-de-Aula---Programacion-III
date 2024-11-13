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
    public partial class FrmPagoRelacionado : Form
    {
        Pago pagoActual;
        public FrmPagoRelacionado(Pago pago)
        {
            InitializeComponent();
            pagoActual = pago;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FrmPagoRelacionado_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        public void cargarDatos(Pago pago)
        {
            txtCodigo.Text = pago.ID_Pago;
            txtFechaPago.Text = pago.Fecha_Pago.ToString("dd/MM/yyyy");
            txtMetodoPago.Text = pago.Metodo_Pago;
            txtMonto.Text = pago.Monto.ToString();
            txtCodigoFactura.Text = pago.CodigoFactura;
            txtCedulaPaciente.Text = pago.CodigoPaciente;
        }
        private void FrmPagoRelacionado_Load(object sender, EventArgs e)
        {
            cargarDatos(pagoActual);
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
    }
}
