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
    public partial class FrmRealizarDiagnostico : Form
    {
        Persona pacienteActual;
        Cita citaActual;
        ServicioDiagnostico servisDiag = new ServicioDiagnostico();
        public FrmRealizarDiagnostico(Cita cita, Persona paciente)
        {
            InitializeComponent();
            pacienteActual = paciente;
            citaActual = cita;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmRealizarDiagnostico_Load(object sender, EventArgs e)
        {
            CargarDatos(citaActual, pacienteActual);
        }
        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            Registrar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void txtDescripcionDiag_Enter(object sender, EventArgs e)
        {
            EventoEntrar();
        }
        private void txtDescripcionDiag_Leave(object sender, EventArgs e)
        {
            EventoSalir();
        }
        private void FrmRealizarDiagnostico_MouseDown(object sender, MouseEventArgs e)
        {
            moverMouse();
        }
        private void CargarDatos(Cita cita, Persona paciente)
        {
            txtCodigo.Text = servisDiag.GenerarCodigo();
            txtFecha.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            txtCodigoCita.Text = cita.Codigo;
            txtCedula.Text = paciente.Cedula;
        }
        public void Registrar()
        {
            Diagnostico diagnostico = new Diagnostico();
            diagnostico.Codigo = txtCodigo.Text;
            diagnostico.Fecha_Diagnostico = DateTime.Today.Date;
            diagnostico.CodigoCita = citaActual.Codigo;
            diagnostico.CedulaPaciente = pacienteActual.Cedula;
            diagnostico.Descripcion = txtDescripcionDiag.Text;
            servisDiag.Add(diagnostico);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtDescripcionDiag.Text == "DESCRIPCION")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        void cerrar()
        {
            this.Close();
        }
        private void Limpiar()
        {
            BaseTextbox(txtDescripcionDiag, "DESCRIPCION");
        }
        void EventoEntrar()
        {
            if (txtDescripcionDiag.Text == "DESCRIPCION")
            {
                txtDescripcionDiag.Text = "";
                txtDescripcionDiag.ForeColor = Color.Black;
            }
        }
        void EventoSalir()
        {
            if (txtDescripcionDiag.Text == "")
            {
                txtDescripcionDiag.Text = "DESCRIPCION";
                txtDescripcionDiag.ForeColor = Color.DimGray;
            }
        }
        void moverMouse()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void BaseTextbox(TextBox textBox, string nombre)
        {
            textBox.Text = nombre;
            textBox.ForeColor = Color.DimGray;
        }

        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(12);
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
