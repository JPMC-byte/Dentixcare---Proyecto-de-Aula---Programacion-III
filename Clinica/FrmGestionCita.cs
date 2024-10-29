using BLL;
using ENTITY;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmGestionCita : Form
    {
        ServicioCita servicioCita = new ServicioCita();
        Persona UsuarioActual;
        Validaciones vali = new Validaciones();
        public FrmGestionCita(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
            CargarCitas();
        }
        private void CargarCitas(string estado = null, string cedulaPaciente = null)
        {
            var citas = servicioCita.GetAll();

            if (ValidarFiltroEstado(CBFiltrarEstado.Checked, estado))
            {
                citas = servicioCita.LoadByEstado(estado);
            }
            if (ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
            {
                citas = servicioCita.LoadByID(cedulaPaciente);
            }
            if (ValidarFiltroEstado(CBFiltrarEstado.Checked, estado) && ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
            {
                citas = servicioCita.LoadByFilters(estado,cedulaPaciente);
            }
            DGVCitas.DataSource = citas; 
        }
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !ValidarEstado())
            {
                return;
            }
            if (ConfirmarAsignacion())
            {
                AtenderCita();
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            string estadoSeleccionado = CBEstado.SelectedItem?.ToString();
            string cedulaPaciente = txtCedulaPaciente.Text != "CEDULA DEL PACIENTE" ? txtCedulaPaciente.Text : string.Empty;
            CargarCitas(estadoSeleccionado, cedulaPaciente);
            if (CBFiltrarPorPaciente.Checked && !ValidarFiltroPaciente(CBFiltrarPorPaciente.Checked, cedulaPaciente))
            {
                MessageBox.Show("La cédula del paciente no existe en los datos de las citas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        public Cita CitaSeleccionada()
        {
            var codigoCita = DGVCitas.SelectedRows[0].Cells["Codigo"].Value.ToString();

            Cita citaSeleccionada = servicioCita.GetByID(codigoCita);
            return citaSeleccionada;
        }
        bool Verificar()
        {
            if (DGVCitas.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cita de la lista para ver más información.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        bool ValidarEstado()
        {
            Cita cita = CitaSeleccionada();
            if (!vali.ValidarEstado(cita.Estado))
            {
                MessageBox.Show("Error - No es posible alterar una cita que ya ha sido atendida.");
                return false;
            }
            return true;
        }
        public bool ValidarFiltroEstado(bool activo, string texto)
        {
            return vali.ValidarFiltroEstado(activo,texto);
        }
        public bool ValidarFiltroPaciente(bool activo, string texto)
        {
            return vali.ValidarFiltroPaciente(activo,texto);
        }

        void AtenderCita()
        {
            Cita cita = CitaSeleccionada();
            servicioCita.UpdateAtendida(cita, UsuarioActual.Cedula, "Pendiente");
            MessageBox.Show("Proceso de asignación exitoso");
        }
        bool ConfirmarAsignacion()
        {
            if (MessageBox.Show("¿Esta seguro que desea atender dicha cita?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }
        private void CBFiltrarEstado_CheckedChanged(object sender, EventArgs e)
        {
            accionarFiltroPorEstado();
        }
        private void CBFiltrarPorPaciente_CheckedChanged(object sender, EventArgs e)
        {
            accionarFiltroPorPaciente();
        }
        void accionarFiltroPorEstado()
        {
            if (CBFiltrarEstado.Checked)
            {
                CBEstado.Enabled = true;
            }
            else 
            {
                CBEstado.Enabled = false;
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
        void cerrar()
        {
            this.Close();
        }
        private void txtCedulaPaciente_Enter(object sender, EventArgs e)
        {
            if (txtCedulaPaciente.Text == "CEDULA DEL PACIENTE")
            {
                txtCedulaPaciente.Text = "";
                txtCedulaPaciente.ForeColor = Color.Black;
            }
        }
        private void txtCedulaPaciente_Leave(object sender, EventArgs e)
        {
            if (txtCedulaPaciente.Text == "")
            {
                txtCedulaPaciente.Text = "CEDULA DEL PACIENTE";
                txtCedulaPaciente.ForeColor = Color.DimGray;
            }
        }
    }
}
