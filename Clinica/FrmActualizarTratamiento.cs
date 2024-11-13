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
    public partial class FrmActualizarTratamiento : Form
    {
        Tratamiento tratamientoActual;
        ServicioTratamiento servisTrat = new ServicioTratamiento();
        Validaciones vali = new Validaciones();
        public FrmActualizarTratamiento(Tratamiento tratamiento)
        {
            InitializeComponent();
            tratamientoActual = tratamiento;
        }
        private void FrmActualizarTratamiento_Load(object sender, EventArgs e)
        {
            CargarDatos(tratamientoActual);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmActualizarTratamiento_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarNumeros() || !validarMonto() )
            {
                return;
            }
            if (Confirmar())
            {
                Actualizar();
            }
        }
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void CargarDatos(Tratamiento tratamiento)
        {
            txtCodigo.Text = tratamiento.ID_Tratamiento;
            txtCodigoDiagnostico.Text = tratamiento.CodigoDiagnostico;
            txtCodigoFactura.Text = tratamiento.CodigoFactura;
        }
        void Actualizar()
        {
            string nuevaDescripcion = txtDescripcion.Text;
            string nuevaDuracion = txtDuracion.Text;
            double nuevoCosto = Convert.ToDouble(txtCosto.Text);
            servisTrat.UpdateTratamiento(tratamientoActual, nuevaDescripcion, nuevaDuracion, nuevoCosto);
            MessageBox.Show("Proceso de modificación exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtDuracion.Text == "DURACION" || txtCosto.Text == "COSTO" || txtDescripcion.Text == "DESCRIPCION")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        bool validarMonto()
        {
            double monto = Convert.ToDouble(txtCosto.Text);
            if (!vali.ValidarMonto(monto))
            {
                MessageBox.Show("Error - El monto asignado no es valido", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        bool validarNumeros()
        {
            if (!vali.ValidarNumeros(txtCosto.Text))
            {
                MessageBox.Show("Error - El monto solo puede contener numeros", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea actualizar dicho registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        void cerrar()
        {
            this.Close();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Limpiar()
        {
            BaseTextbox(txtDuracion, "DURACION");
            BaseTextbox(txtCosto, "COSTO");
            BaseTextbox(txtDescripcion, "DESCRIPCION");
        }
        void BaseTextbox(TextBox textBox, string nombre)
        {
            textBox.Text = nombre;
            textBox.ForeColor = Color.DimGray;
        }
        void EventoEntrarTextbox(TextBox textBox, string nombre)
        {
            if (textBox.Text == nombre)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        void EventoSalirTextbox(TextBox textBox, string nombre)
        {
            if (textBox.Text == "")
            {
                textBox.Text = nombre;
                textBox.ForeColor = Color.DimGray;
            }
        }
        private void txtCosto_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtCosto, "COSTO");
        private void txtCosto_Leave(object sender, EventArgs e) => EventoSalirTextbox(txtCosto, "COSTO");
        private void txtDuracion_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtDuracion, "DURACION");
        private void txtDuracion_Leave(object sender, EventArgs e) => EventoSalirTextbox(txtDuracion, "DURACION");
        private void txtDescripcion_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtDescripcion, "DESCRIPCION");
        private void txtDescripcion_Leave(object sender, EventArgs e) => EventoSalirTextbox(txtDescripcion, "DESCRIPCION");

    }
}
