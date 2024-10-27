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
    public partial class FrmMedico : Form
    {
        Persona ortodoncista = new Ortodoncista();
        Form FormularioActivo = null;
        public FrmMedico(Persona persona)
        {
            InitializeComponent();
            ortodoncista = persona;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void Panellogo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnDatosUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPerfil(ortodoncista));
            OcultarSubmenu();
        }
        private void OcultarSubmenu()
        {
            if (PanelSubmenuTratamientos.Visible == true)
                PanelSubmenuTratamientos.Visible = false;
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
    }
}
