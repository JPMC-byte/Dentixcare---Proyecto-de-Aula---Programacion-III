using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace GUI
{
    public partial class FrmConsultorio : Form
    {
        Consultorio consultorioActual;
        public FrmConsultorio(Consultorio consultorio)
        {
            InitializeComponent();
            consultorioActual = consultorio;
            CargarDatos(consultorioActual);
        }

        void CargarDatos(Consultorio consultorio)
        {
            txtCodigo.Text = consultorio.Codigo;
            txtNombre.Text = consultorio.Nombre;
            txtTelefono.Text = consultorio.Telefono;
            txtBarrio.Text = consultorio.Barrio;
            txtEtapa.Text = consultorio.Etapa;
            txtManzana.Text = consultorio.Manzana;
            txtCalle.Text = consultorio.Calle;
            txtHoraApertura.Text = consultorio.Hora_Apertura.ToString();
            txtHoraCierre.Text = consultorio.Hora_Cierre.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }

        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(15);
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
