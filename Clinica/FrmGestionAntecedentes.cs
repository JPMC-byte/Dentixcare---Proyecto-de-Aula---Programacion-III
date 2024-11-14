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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmGestionAntecedentes : Form
    {
        Persona UsuarioActual;
        ServicioDiagnostico servisDiag = new ServicioDiagnostico();
        ServicioCita servisCita = new ServicioCita();
        ServicioPaciente servisPaciente = new ServicioPaciente();
        Validaciones vali = new Validaciones();
        public FrmGestionAntecedentes(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
            determinarUsuario(UsuarioActual);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void moverCursor()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FrmGestionAntecedentes_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Parent == null)
            {
                moverCursor();
            }
        }
        private void FrmGestionAntecedentes_Load(object sender, EventArgs e)
        {
            CargarDiagnosticos();
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            AbrirInformacion();
        }
        private void btnAsignarTratamiento_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            AsignarTratamiento();
        }
        private void btnTratamientosRelacion_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            verTratamientosRelacionados();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarExistenteRelacion())
            {
                return;
            }
            if (Confirmar())
            {
                CancelarDiagnostico();
            }
        }
        private void btnActualizarDiagnostico_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarExistenteRelacion())
            {
                return;
            }
            actualizarDiagnostico();
        }
        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void CBFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            accionarFiltroPorFecha();
        }

        private void CBFiltrarPorPaciente_CheckedChanged(object sender, EventArgs e)
        {
            accionarFiltroPorPaciente();
        }
        private void txtCedulaPaciente_Enter(object sender, EventArgs e)
        {
            eventoEntrar();
        }
        private void txtCedulaPaciente_Leave(object sender, EventArgs e)
        {
            eventoSalir();
        }
        private void CargarDiagnosticos(DateTime? Fecha = null, string cedulaPaciente = null)
        {
            List<Diagnostico> diagnosticos = new List<Diagnostico>();

            if (UsuarioActual is Paciente)
            {
                cedulaPaciente = UsuarioActual.Cedula;
                diagnosticos = servisDiag.LoadByCedula(cedulaPaciente);

                if (Fecha.HasValue && ValidarFiltroFecha(CBFiltrarFecha.Checked, Fecha.Value))
                {
                    diagnosticos = servisDiag.LoadByFecha(Fecha.Value);
                }
            }
            else 
            {
                diagnosticos = servisDiag.GetAll();

                if (Fecha.HasValue && ValidarFiltroFecha(CBFiltrarFecha.Checked, Fecha.Value))
                {
                    diagnosticos = servisDiag.LoadByFecha(Fecha.Value);
                }
                if (ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
                {
                    diagnosticos = servisDiag.LoadByCedula(cedulaPaciente);
                }
                if(Fecha.HasValue && ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente) && ValidarFiltroFecha(CBFiltrarFecha.Checked, Fecha.Value))
                {
                    diagnosticos = servisDiag.LoadByFilters(Fecha.Value, cedulaPaciente);
                }
            }
            DGVDiagnostico.DataSource = diagnosticos;
        }
        public void determinarUsuario(Persona persona)
        {
            if (UsuarioActual is Paciente)
            {
                CBFiltrarPorPaciente.Enabled = false;
                txtCedulaPaciente.Enabled = false;
                btnEliminar.Enabled = false;
                btnActualizarDiagnostico.Enabled = false;
                btnAsignarTratamiento.Enabled = false;
                LBFiltrarPorPaciente.Enabled = false;
            }
        }
        bool Verificar()
        {
            if (DGVDiagnostico.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un diagnostico de la lista para realizar dicha acción", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool ValidarFiltroFecha(bool activo, DateTime fecha)
        {
            return vali.ValidarFiltroFecha(activo, fecha);
        }
        public bool ValidarFiltroPaciente(bool activo, string texto)
        {
            return vali.ValidarFiltroPaciente(activo, texto);
        }
        void Actualizar()
        {
            DateTime? fechaSeleccionada = CBFiltrarFecha.Checked ? (DateTime?)DTFiltroFecha.Value.Date : null;
            string cedulaPaciente = txtCedulaPaciente.Text != "CEDULA DEL PACIENTE" ? txtCedulaPaciente.Text : null;

            CargarDiagnosticos(fechaSeleccionada, cedulaPaciente);

            if (CBFiltrarPorPaciente.Checked && !ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
            {
                MessageBox.Show("La cédula del paciente no existe en el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CBFiltrarFecha.Checked && !ValidarFiltroFecha(CBFiltrarFecha.Checked, DTFiltroFecha.Value.Date))
            {
                MessageBox.Show("No es posible filtrar por una fecha futura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void accionarFiltroPorFecha()
        {
            if (CBFiltrarFecha.Checked)
            {
                DTFiltroFecha.Enabled = true;
            }
            else
            {
                DTFiltroFecha.Enabled = false;
            }
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
        public Paciente PacienteSeleccionado()
        {
            var cedulaPaciente = DGVDiagnostico.SelectedRows[0].Cells["CedulaPaciente"].Value.ToString();

            Paciente pacienteSeleccionado = servisPaciente.GetByID(cedulaPaciente);
            return pacienteSeleccionado;
        }
        public Cita CitaSeleccionada()
        {
            var codigoCita = DGVDiagnostico.SelectedRows[0].Cells["CodigoCita"].Value.ToString();

            Cita citaSeleccionada = servisCita.GetByID(codigoCita);
            return citaSeleccionada;
        }
        public Diagnostico DiagnosticoSeleccionado()
        {
            var codigoDiag = DGVDiagnostico.SelectedRows[0].Cells["Codigo"].Value.ToString();
            Diagnostico diagnosticoSeleccionado = servisDiag.GetByID(codigoDiag);
            return diagnosticoSeleccionado;
        }
        void AbrirInformacion()
        {
            Diagnostico diagnostico = DiagnosticoSeleccionado();
            FrmInfoDiagnostico F = new FrmInfoDiagnostico(diagnostico);
            F.Show();
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
        void cerrar()
        {
            this.Close();
        }
        void AsignarTratamiento()
        {
            Diagnostico diagnosticoSeleccionado = DiagnosticoSeleccionado();
            FrmSeleccionTratamiento F = new FrmSeleccionTratamiento(diagnosticoSeleccionado);
            F.Show();
        }
        void verTratamientosRelacionados()
        {
            Diagnostico diagnosticoSeleccionado = DiagnosticoSeleccionado();
            FrmGestionTratamientos F = new FrmGestionTratamientos(diagnosticoSeleccionado);
            F.Show();
        }
        void CancelarDiagnostico()
        {
            Diagnostico diagnosticoSeleccionado = DiagnosticoSeleccionado();
            servisDiag.Delete(diagnosticoSeleccionado);
            MessageBox.Show("Registro eliminado con exito");
        }
        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea eliminar dicho registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        bool validarExistenteRelacion()
        {
            Diagnostico diagnosticoSeleccionado = DiagnosticoSeleccionado();
            if (vali.ValidarExistenteFactura(diagnosticoSeleccionado.Codigo))
            {
                MessageBox.Show("Error - No es posible alterar un diagnostico con tratamientos asignados", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        void actualizarDiagnostico()
        {
            Paciente pacienteSeleccionado = PacienteSeleccionado();
            Cita citaSeleccionada = CitaSeleccionada();
            Diagnostico diagnosticoSeleccionado = DiagnosticoSeleccionado();
            FrmActualizarDiagnostico F = new FrmActualizarDiagnostico(citaSeleccionada, pacienteSeleccionado, diagnosticoSeleccionado);
            F.Show();
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
