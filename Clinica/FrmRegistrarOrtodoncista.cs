using BLL;
using ENTITY;
using Logica;
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
    public partial class FrmRegistrarOrtodoncista : Form
    {
        ServicioOrtodoncista servispaciente = new ServicioOrtodoncista();
        ServicioConsultorio servisconsulto = new ServicioConsultorio();
        Validaciones vali = new Validaciones();
        public FrmRegistrarOrtodoncista()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        public void Registrar()
        {
            if (!Verificar() || !ValidarExistente())
            {
                return;
            }

            Ortodoncista ortodoncista = new Ortodoncista();
            Consultorio consultorio = servisconsulto.CargarConsultorio("P101");

            ortodoncista.CodigoConsultorio = consultorio.Codigo;
            ortodoncista.PrimerNombre = txtPrimerNombre.Text;
            ortodoncista.SegundoNombre = txtSegundoNombre.Text;
            ortodoncista.PrimerApellido = txtPrimerApellido.Text;
            ortodoncista.SegundoApellido = txtSegundoApellido.Text;
            ortodoncista.Telefono = txtTelefono.Text;
            ortodoncista.Cedula = txtCedula.Text;
            ortodoncista.Fecha_De_Nacimiento = DTFecha_Nacimiento.Value;
            ortodoncista.Contrasena = txtContraseña.Text;

            servispaciente.Add(ortodoncista);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtPrimerNombre.Text == "PRIMER NOMBRE" || txtSegundoNombre.Text == "SEGUNDO NOMBRE" ||
                txtPrimerApellido.Text == "PRIMER APELLIDO" || txtSegundoApellido.Text == "SEGUNDO APELLIDO" ||
                txtTelefono.Text == "TELEFONO" || txtCedula.Text == "CEDULA" || txtContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        bool ValidarLetras(KeyPressEventArgs e)
        {
            if (!vali.ValidarLetras(e))
            {
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
        bool ValidarExistente()
        {
            if (!vali.ValidarExistenteOrtodoncista(txtCedula.Text))
            {
                MessageBox.Show("Error - Esté usuario ya se encuentra registrado.");
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            BaseTextbox(txtPrimerNombre, "NOMBRE");
            BaseTextbox(txtSegundoNombre, "NOMBRE");
            BaseTextbox(txtPrimerApellido, "APELLIDO");
            BaseTextbox(txtSegundoApellido, "APELLIDO");
            BaseTextbox(txtTelefono, "TELEFONO");
            BaseTextbox(txtCedula, "CEDULA");
            BaseTextbox(txtContraseña, "CONTRASEÑA");
        }
        void BaseTextbox(TextBox textBox, string nombre)
        {
            textBox.Text = nombre;
            textBox.ForeColor = Color.DimGray;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
        void Volver()
        {
            var f = new FrmAcceso();
            f.Show();
            this.Close();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
        private void txtPrimerNombre_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtPrimerNombre, "PRIMER NOMBRE");
        private void txtPrimerNombre_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtPrimerNombre, "PRIMER NOMBRE");
        private void txtSegundoNombre_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtSegundoNombre, "SEGUNDO NOMBRE");
        private void txtSegundoNombre_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtSegundoNombre, "SEGUNDO NOMBRE");
        private void txtPrimerApellido_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtPrimerApellido, "PRIMER APELLIDO");
        private void txtPrimerApellido_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtPrimerApellido, "PRIMER APELLIDO");
        private void txtSegundoApellido_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtSegundoApellido, "SEGUNDO APELLIDO");
        private void txtSegundoApellido_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtSegundoApellido, "SEGUNDO APELLIDO");
        private void txtTelefono_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtTelefono, "TELEFONO");
        private void txtTelefono_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtTelefono, "TELEFONO");
        private void txtCedula_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtCedula, "CEDULA");
        private void txtCedula_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtCedula, "CEDULA");
        private void txtContraseña_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtContraseña, "CONTRASEÑA");
        private void txtContraseña_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtContraseña, "CONTRASEÑA");

        private void FrmRegistrarOrtodoncista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarNumeros(e)) e.Handled = true; }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarNumeros(e)) e.Handled = true; }
    }
}
