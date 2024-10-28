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

namespace Clinica
{
    public partial class FrmPaciente : Form
    {
        ServicioConsultorio servisConsul = new ServicioConsultorio();
        Persona paciente = new Paciente();
        Form FormularioActivo = null;
        public FrmPaciente(Persona persona)
        {
            InitializeComponent();
            paciente = persona;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PCFondo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        private void Panellogo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }
        void cerrarSesion()
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close(); 
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void OcultarSubmenu()
        {
            if (PanelSubmenuDatos.Visible == true)
                PanelSubmenuDatos.Visible = false;
            if (PanelSubmenuCitas.Visible == true)
                PanelSubmenuCitas.Visible = false;
        }
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }else
            {
                submenu.Visible = false;
            }
        }
        private void btnDatosUsuario_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubmenuDatos);
        }
        private void btnGestionCitas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubmenuCitas);
        }
        private void btnGestionPagos_Click(object sender, EventArgs e)
        {


            OcultarSubmenu();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPerfil(paciente));
            OcultarSubmenu();
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {


            OcultarSubmenu();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgendarCita(paciente));
            OcultarSubmenu();
        }
        private void btnRegistroCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistroCita(paciente));
            OcultarSubmenu();
        }
        private void btnCancelarCita_Click(object sender, EventArgs e)
        {


            OcultarSubmenu();
        }

        private void AbrirFormulario(Form FormularioHijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelHijo.Controls.Add(FormularioHijo);
            PanelHijo.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void btnDatosConsultorio_Click(object sender, EventArgs e)
        {
            Consultorio consultorio = servisConsul.CargarConsultorio("P101");
            AbrirFormulario(new FrmConsultorio(consultorio));
            OcultarSubmenu();
        }
    }
}
