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
    public partial class FrmMedico : Form
    {
        ServicioConsultorio servisConsul = new ServicioConsultorio();
        Persona personaActual = new Ortodoncista();
        Form FormularioActivo = null;
        public FrmMedico(Persona persona)
        {
            InitializeComponent();
            personaActual = persona;
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
            AbrirFormulario(new FrmPerfil(personaActual));
            OcultarSubmenu();
        }
        private void btnGestionTratamientos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(PanelSubmenuTratamientos);
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
        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btnDatosConsultorio_Click(object sender, EventArgs e)
        {
            VerConsultorio();
        }
        private void btnGestionCitas_Click(object sender, EventArgs e)
        {
            VerGestionCita();
        }

        private void btnGestionPaciente_Click(object sender, EventArgs e)
        {
            VerGestionPaciente();
        }
        private void btnGestionDiagnostico_Click(object sender, EventArgs e)
        {
            VerGestionDiagnosticos();
        }
        private void btnRealizarTratamiento_Click(object sender, EventArgs e)
        {
            VerAgendarTratamiento();
        }
        private void btnRegistroTratamientos_Click(object sender, EventArgs e)
        {
            VerGestionTratamientos();
        }
        void VerConsultorio()
        {
            Consultorio consultorio = servisConsul.CargarConsultorio("P101");
            AbrirFormulario(new FrmConsultorio(consultorio));
            OcultarSubmenu();
        }
        void VerGestionCita()
        {
            AbrirFormulario(new FrmGestionCita(personaActual));
            OcultarSubmenu();
        }
        void VerGestionPaciente()
        {
            AbrirFormulario(new FrmGestionPaciente());
            OcultarSubmenu();
        }
        void VerGestionDiagnosticos()
        {
            AbrirFormulario(new FrmGestionAntecedentes(personaActual));
            OcultarSubmenu();
        }
        void VerAgendarTratamiento()
        {
            AbrirFormulario(new FrmRealizarTratamiento());
            OcultarSubmenu();
        }
        void VerGestionTratamientos()
        {
            AbrirFormulario(new FrmGestionTratamientos());
            OcultarSubmenu();
        }

        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(11);
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
