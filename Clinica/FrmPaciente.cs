using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPaciente : Form
    {
        ServicioConsultorio servisConsul = new ServicioConsultorio();
        Persona UsuarioActual = new Paciente();
        Form FormularioActivo = null;
        public FrmPaciente(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(6);
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
            AbrirFormulario(new FrmGestionFactura(UsuarioActual));
            OcultarSubmenu();
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPerfil(UsuarioActual));
            OcultarSubmenu();
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGestionAntecedentes(UsuarioActual));
            OcultarSubmenu();
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgendarCita(UsuarioActual));
            OcultarSubmenu();
        }
        private void btnRegistroCitas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistroCita(UsuarioActual));
            OcultarSubmenu();
        }
        private void btnDatosConsultorio_Click(object sender, EventArgs e)
        {
            Consultorio consultorio = servisConsul.CargarConsultorio("P101");
            AbrirFormulario(new FrmConsultorio(consultorio));
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
        void abrirManualUsuario(int pagina)
        {
            string tempPath = Path.GetTempPath();
            string pdfPath = Path.Combine(tempPath, "ManualDeUsuario.pdf");
            using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GUI.Recursos.ManualDeUsuario.pdf"))
            {
                if (resourceStream != null)
                {
                    using (var fileStream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo PDF incrustado.");
                    return;
                }
            }
            Process pdfProcess = new Process();
            pdfProcess.StartInfo.FileName = "Acrobat.exe";
            pdfProcess.StartInfo.Arguments = $"/A \"page={pagina}\" \"{pdfPath}\"";
            pdfProcess.Start();

            pdfProcess.Exited += (s, e) =>
            {
                if (File.Exists(pdfPath))
                {
                    File.Delete(pdfPath);
                }
            };
            pdfProcess.EnableRaisingEvents = true;
        }
    }
}
