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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPerfil : Form
    {
        Persona UsuarioActual;
        public FrmPerfil(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
        }
        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            CargarDatos(UsuarioActual);
        }
        private void CargarDatos(Persona persona)
        {
            txtPrimerNombre.Text = persona.PrimerNombre;
            txtSegundoNombre.Text = persona.SegundoNombre;
            txtPrimerApellido.Text = persona.PrimerApellido;
            txtSegundoApellido.Text = persona.SegundoNombre;
            txtTelefono.Text = persona.Telefono;
            txtCedula.Text = persona.Cedula;
            txtEdad.Text = persona.CalcularEdad(persona.Fecha_De_Nacimiento);
            txtIDConsultorio.Text = persona.CodigoConsultorio;
            txtFechaNacimiento.Text = persona.Fecha_De_Nacimiento.ToString("dd/MM/yyyy");

            if (persona is Paciente) 
            {
                txtCategoria.Text = "Paciente";
            }
            else
            {
                txtCategoria.Text = "Ortodoncista";
            }
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
            abrirManualUsuario(6);
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
