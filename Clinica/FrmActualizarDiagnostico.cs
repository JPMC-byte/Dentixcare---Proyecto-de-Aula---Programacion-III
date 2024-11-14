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
    public partial class FrmActualizarDiagnostico : Form
    {
        Persona pacienteActual;
        Cita citaActual;
        Diagnostico diagnosticoActual;
        ServicioDiagnostico servisDiag = new ServicioDiagnostico();
        public FrmActualizarDiagnostico(Cita cita, Persona persona, Diagnostico diagnostico)
        {
            InitializeComponent();
            citaActual = cita;
            pacienteActual = persona;
            diagnosticoActual = diagnostico;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmActualizarDiagnostico_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        private void FrmActualizarDiagnostico_Load(object sender, EventArgs e)
        {
            CargarDatos(citaActual, pacienteActual);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            if (Confirmar())
            {
                Actualizar();
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void txtDescripcionDiag_Enter(object sender, EventArgs e)
        {
            EventoEntrar();
        }
        private void txtDescripcionDiag_Leave(object sender, EventArgs e)
        {
            EventoSalir();
        }
        private void CargarDatos(Cita cita, Persona paciente)
        {
            txtCodigo.Text = servisDiag.GenerarCodigo();
            txtFecha.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            txtCodigoCita.Text = cita.Codigo;
            txtCedula.Text = paciente.Cedula;
        }
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea actualizar dicho registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
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
        private void Limpiar()
        {
            BaseTextbox(txtDescripcionDiag, "DESCRIPCION");
        }
        void BaseTextbox(TextBox textBox, string nombre)
        {
            textBox.Text = nombre;
            textBox.ForeColor = Color.DimGray;
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void cerrar()
        {
            this.Close();
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
        void Actualizar()
        {
            string nuevaDescripcion = txtDescripcionDiag.Text;
            servisDiag.Update(diagnosticoActual, nuevaDescripcion);
            MessageBox.Show("Proceso de modificación exitoso");
            Limpiar();
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
