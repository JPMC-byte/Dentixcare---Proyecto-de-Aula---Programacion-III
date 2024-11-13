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
    public partial class FrmRealizarPago : Form
    {
        Factura facturaActual;
        Persona usuarioActual = new Paciente();
        ServicioPago servicioPago = new ServicioPago();
        ServicioFactura servisFactu = new ServicioFactura();
        Validaciones vali = new Validaciones();
        public FrmRealizarPago(Factura factura, Persona persona)
        {
            InitializeComponent();
            facturaActual = factura;
            usuarioActual = persona;
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
        private void FrmRealizarPago_Load(object sender, EventArgs e)
        {
            CargarFecha();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        private void FrmRealizarPago_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        void CargarFecha()
        {
            txtFecha.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
        }
        void cerrar()
        {
            this.Close();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea realizar dicho movimiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        bool validarMetodoPago()
        {
            if (!vali.ValidarMetodoPago(CBMetodoPago.Text))
            {
                MessageBox.Show("Error - Por favor, seleccione un metodo de pago", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        bool validarMonto()
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            if (!vali.ValidarMonto(monto))
            {
                MessageBox.Show("Error - El monto asignado no es valido", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        bool ValidarNumeros(KeyPressEventArgs e)
        {
            if (!vali.ValidarNumeros(e))
            {
                return false;
            }
            return true;
        }
        bool Verificar()
        {
            if (txtMonto.Text == "MONTO")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarMonto() || !validarMetodoPago() ) { return; }
            if (Confirmar()) 
            {
                realizarPago();
            }
        }
        bool validarFacturaPagada()
        {
            if (vali.ValidarFacturaPagada(facturaActual))
            {
                return true;
            }
            return false;
        }
        public void realizarPago()
        {
            Pago pago = new Pago();
            pago.ID_Pago = servicioPago.GenerarCodigo();
            pago.Fecha_Pago = DateTime.Now.Date;
            pago.Metodo_Pago = CBMetodoPago.Text;
            pago.Monto = Convert.ToDouble(txtMonto.Text);
            pago.CodigoFactura = facturaActual.ID_Factura;
            pago.CodigoPaciente = usuarioActual.Cedula;
            servicioPago.Add(pago);
            servisFactu.SumarMontoAPagado(facturaActual, pago.Monto);
            facturaActual = servisFactu.GetByID(facturaActual.ID_Factura);
            if (validarFacturaPagada())
            {
                servisFactu.UpdateEstado(facturaActual, "Finalizada"); 
                servisFactu.SumarCambio(facturaActual);
            }
            MessageBox.Show("Proceso de registro exitoso");
        }
        void EventoEntrarTextbox(TextBox textBox, string nombre)
        {
            if (textBox.Text == nombre)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        void EventoDejarTextbox(TextBox textBox, string nombre)
        {
            if (textBox.Text == "")
            {
                textBox.Text = nombre;
                textBox.ForeColor = Color.DimGray;
            }
        }
        private void txtMonto_Enter(object sender, EventArgs e) { EventoEntrarTextbox(txtMonto, "MONTO"); }
        private void txtMonto_Leave(object sender, EventArgs e) { EventoDejarTextbox(txtMonto, "MONTO"); }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarNumeros(e)) e.Handled = true; }
    }
}
