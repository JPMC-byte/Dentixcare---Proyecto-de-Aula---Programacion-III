using BLL;
using ENTITY;
using Logica;
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
    public partial class FrmGestionPaciente : Form
    {
        ServicioPaciente servisPaciente = new ServicioPaciente();
        Validaciones vali = new Validaciones();
        public FrmGestionPaciente()
        {
            InitializeComponent();
        }

        private void FrmGestionPaciente_Load(object sender, EventArgs e)
        {
            cargarPacientes();
        }
        void cargarPacientes(string cedulaPaciente = null)
        {
            var Pacientes = servisPaciente.GetAll();

            if (ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
            {
                Pacientes = servisPaciente.LoadByID(cedulaPaciente);
            }
            DGVPaciente.DataSource = Pacientes;
        }
        public Paciente PacienteSeleccionado()
        {
            var cedulaPaciente = DGVPaciente.SelectedRows[0].Cells["Cedula"].Value.ToString();

            Paciente pacienteSeleccionado = servisPaciente.GetByID(cedulaPaciente);
            return pacienteSeleccionado;
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            AbrirInformacion();
        }
        bool Verificar()
        {
            if (DGVPaciente.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un paciente de la lista para realizar dicha acción", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        void AbrirInformacion()
        {
            Paciente paciente = PacienteSeleccionado();
            FrmPerfil F = new FrmPerfil(paciente);
            F.Show();
        }
        public bool ValidarFiltroPaciente(bool activo, string texto)
        {
            return vali.ValidarFiltroPaciente(activo, texto);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }
        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            if (!Verificar()) {  return; }
            MostrarAntecedentes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            string cedulaPaciente = txtCedulaPaciente.Text != "CEDULA DEL PACIENTE" ? txtCedulaPaciente.Text : string.Empty;
            cargarPacientes(cedulaPaciente);
            if (CBFiltrarPorPaciente.Checked && !ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
            {
                MessageBox.Show("La cédula del paciente no existe en el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CBFiltrarPorPaciente_CheckedChanged(object sender, EventArgs e)
        {
            accionarFiltroPorPaciente();
        }
        void accionarFiltroPorPaciente()
        {
            if (CBFiltrarPorPaciente.Checked)
            {
                txtCedulaPaciente.Enabled = true;
            }
            else
            {
                txtCedulaPaciente.Enabled = false;
            }
        }
        private void txtCedulaPaciente_Leave(object sender, EventArgs e)
        {
            eventoSalir();
        }

        private void txtCedulaPaciente_Enter(object sender, EventArgs e)
        {
            eventoEntrar();
        }

        void eventoEntrar()
        {
            if (txtCedulaPaciente.Text == "CEDULA DEL PACIENTE")
            {
                txtCedulaPaciente.Text = "";
                txtCedulaPaciente.ForeColor = Color.Black;
            }
        }
        void eventoSalir()
        {
            if (txtCedulaPaciente.Text == "")
            {
                txtCedulaPaciente.Text = "CEDULA DEL PACIENTE";
                txtCedulaPaciente.ForeColor = Color.DimGray;
            }
        }
        void MostrarAntecedentes()
        {
            Paciente paciente = PacienteSeleccionado();
            FrmGestionAntecedentes F = new FrmGestionAntecedentes(paciente);
            F.Show();
        }

        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(14);
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
