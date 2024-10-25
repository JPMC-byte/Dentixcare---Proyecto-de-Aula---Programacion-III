using BLL;
using Entidadeds;
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

namespace Clinica
{
    public partial class FrmRegistrarOrtodoncista : Form
    {
        FrmIngreso frmIngreso;
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
            if (!Verificar() || !Validar())
            {
                return;
            }
            Ortodoncista ortodoncista = new Ortodoncista();
            Consultorio consultorio = new Consultorio();
            consultorio = servisconsulto.CargarConsultorio("P101");
            ortodoncista.CodigoConsultorio = consultorio.Codigo;
            ortodoncista.Nombre = txtNombre.Text;
            ortodoncista.Apellido = txtApellido.Text;
            ortodoncista.Telefono = txtTelefono.Text;
            ortodoncista.Cedula = txtCedula.Text;
            ortodoncista.Fecha_De_Nacimiento = DTFecha_Nacimiento.Value;
            ortodoncista.Edad = ortodoncista.CalcularEdad(DTFecha_Nacimiento.Value);
            ortodoncista.Contrasena = txtContraseña.Text;
            servispaciente.Add(ortodoncista);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtNombre.Text == "NOMBRE" || txtApellido.Text == "APELLIDO" || txtTelefono.Text == "TELEFONO" || txtCedula.Text == "CEDULA" || txtContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        bool Validar()
        {
            if (!vali.ValidarLetras(txtNombre.Text) || !vali.ValidarLetras(txtApellido.Text))
            {
                MessageBox.Show("El nombre y apellido solo pueden contener letras.");
                return false;
            }

            if (!vali.ValidarNumeros(txtTelefono.Text) || !vali.ValidarNumeros(txtCedula.Text))
            {
                MessageBox.Show("El teléfono y la cédula solo pueden contener números.");
                return false;
            }
            return true;
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtContraseña.Clear();
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
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.DimGray;
            }
        }
        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
                txtApellido.ForeColor = Color.DimGray;
            }
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELEFONO")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "TELEFONO";
                txtTelefono.ForeColor = Color.DimGray;
            }
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
    }
}
