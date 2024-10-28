using BLL;
using ENTITY;
using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmGestionCita : Form
    {
        ServicioCita servicioCita = new ServicioCita();
        Persona UsuarioActual;
        public FrmGestionCita(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
            CargarCitas();
        }
        private void CargarCitas()
        {
            DGVCitas.DataSource = servicioCita.GetAll();
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
        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            if (ConfirmarAsignacion())
            {
                AtenderCita();
            }
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarCitas();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }
    }
}
