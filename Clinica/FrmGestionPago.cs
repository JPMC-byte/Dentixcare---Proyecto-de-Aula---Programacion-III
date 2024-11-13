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

namespace GUI
{
    public partial class FrmGestionPago : Form
    {
        Factura facturaActual;
        ServicioPago servicioPago = new ServicioPago();
        public FrmGestionPago(Factura factura)
        {
            InitializeComponent();
            facturaActual = factura;
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
        private void FrmGestionPago_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void FrmGestionPago_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        public Pago pagoSeleccionado()
        {
            var IDPago = DGVPagos.SelectedRows[0].Cells["ID_Pago"].Value.ToString();

            Pago pagoSeleccionado = servicioPago.GetByID(IDPago);
            return pagoSeleccionado;
        }
        void cerrar()
        {
            this.Close();
        }
        void cargarDatos()
        {
            var listaPagos = servicioPago.LoadByFactura(facturaActual.ID_Factura);
            DGVPagos.DataSource = listaPagos;
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            abrirInfoPago();
        }
        void abrirInfoPago()
        {
            Pago pago = pagoSeleccionado();
            FrmPagoRelacionado F = new FrmPagoRelacionado(pago);
            F.Show();
        }
    }
}
