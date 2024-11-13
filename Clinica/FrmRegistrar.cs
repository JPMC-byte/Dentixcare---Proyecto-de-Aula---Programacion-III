using System;
using System.Drawing;
using System.Windows.Forms;
using Logica;
using ENTITY;
using BLL;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class FrmRegistrar : Form
    {
        ServicioPaciente servispaciente = new ServicioPaciente();
        ServicioConsultorio servisconsulto = new ServicioConsultorio();
        Validaciones vali = new Validaciones();
        public FrmRegistrar()
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

        private void Registrar()
        {
            if (!Verificar() || !ValidarExistente() || !VerificarCamposOpcionales())
            {
                return;
            }
            Paciente paciente = new Paciente();
            Consultorio consultorio = new Consultorio();
            consultorio = servisconsulto.CargarConsultorio("P101");
            paciente.CodigoConsultorio = consultorio.Codigo;
            paciente.PrimerNombre = txtPrimerNombre.Text;
            paciente.SegundoNombre = (txtSegundoNombre.Text == "SEGUNDO NOMBRE") ? "N/A" : txtSegundoNombre.Text;
            paciente.PrimerApellido = txtPrimerApellido.Text;
            paciente.SegundoApellido = (txtSegundoApellido.Text == "SEGUNDO APELLIDO") ? "N/A" : txtSegundoApellido.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Fecha_De_Nacimiento = DTFecha_Nacimiento.Value.Date;
            paciente.Contrasena = txtContraseña.Text;
            servispaciente.Add(paciente);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        private bool VerificarCamposOpcionales()
        {
            if (!vali.ValidarSegundos(txtSegundoNombre.Text))
            {
                DialogResult result = MessageBox.Show("El campo 'Segundo Nombre' está vacío. ¿Desea continuar y dejarlo como 'N/A'?", "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.No)
                {
                    txtSegundoNombre.Focus();
                    return false;
                }
            }
            if (!vali.ValidarSegundos(txtSegundoApellido.Text))
            {
                DialogResult result = MessageBox.Show("El campo 'Segundo Apellido' está vacío. ¿Desea continuar y dejarlo como 'N/A'?", "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.No)
                {
                    txtSegundoApellido.Focus();
                    return false;
                }
            }
            return true; 
        }
        bool Verificar()
        {
            if (txtPrimerNombre.Text == "PRIMER NOMBRE" || txtPrimerApellido.Text == "PRIMER APELLIDO" || 
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
            if (!vali.ValidarExistentePaciente(txtCedula.Text))
            {
                MessageBox.Show("Error - Esté paciente ya se encuentra registrado.");
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
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRegistrar_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
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
        private void txtContrasena_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtContraseña, "CONTRASEÑA");
        private void txtContrasena_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtContraseña, "CONTRASEÑA");
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarLetras(e)) e.Handled = true; }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarNumeros(e)) e.Handled = true; }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarNumeros(e)) e.Handled = true; }
    }
}
