using BLL;
using ENTITY;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        ServicioPaciente servispaciente = new ServicioPaciente();
        Validaciones vali = new Validaciones();
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnIngresar_Click(object sender, EventArgs e) 
        {
            Ingreso();
        }

        private void Ingreso()
        {
            if (!Verificar())
            {
                return;
            }
            string Cedula = txtCedula.Text;
            string Contraseña = txtContraseña.Text;
            Paciente paciente = servispaciente.IniciarSesion(Cedula,Contraseña);
            if (paciente != null)
            {
                MessageBox.Show("Inicio de sesion exitoso");

                var F = new FrmPaciente(paciente);
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error - Cedula y/o contraseña incorrectas");
            }
        }
        bool Verificar()
        {
            if (txtCedula.Text == "CEDULA" || txtContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        bool Validar(KeyPressEventArgs e)
        {
            if (!vali.ValidarNumeros(e))
            {
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            txtCedula.Text = "CEDULA";
            txtContraseña.Text = "CONTRASEÑA";
            txtCedula.ForeColor = Color.DimGray;
            txtContraseña.ForeColor = Color.DimGray;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "CEDULA")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Black;
            }
        }
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "CEDULA";
                txtCedula.ForeColor = Color.DimGray;
            }
        }
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }
        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
        void Volver()
        {
            var f = new FrmInicioSesion();
            f.Show();
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CBVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVerContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0'; 
            }
            else
            {
                txtContraseña.PasswordChar = '*'; 
            }
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e) { if (!Validar(e)) e.Handled = true; }
    
    }
}
