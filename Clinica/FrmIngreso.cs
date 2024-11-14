using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace GUI
{
   
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnResgistrar_Click(object sender, EventArgs e)
        {
            EntrarAlRegistro();
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Ingreso();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (cerrarPrograma())
            {
                cerrar();
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            minimizar();
        }
        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(4);
        }
        private void EntrarAlRegistro()
        {
            var F = new FrmAcceso();
            F.Show();
            this.Hide();
        }
        private void Ingreso()
        {
            var F = new FrmInicioSesion();
            F.Show();
            this.Hide();
        }
        bool cerrarPrograma()
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar el programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                return true;
            return false;
        }
        void cerrar()
        {
            Application.Exit();
        }

        void minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmIngreso_MouseDown(object sender, MouseEventArgs e)
        {
            moverVentana();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moverVentana();
        }
        void moverVentana()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
