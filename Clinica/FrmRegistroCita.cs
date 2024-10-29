using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmRegistroCita : Form
    {
        ServicioCita servicioCita = new ServicioCita();
        ServicioConsultorio servisconsulto = new ServicioConsultorio();
        Validaciones vali = new Validaciones();
        Persona UsuarioActual;
        public FrmRegistroCita(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
        }
        private void FrmRegistroCita_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }
        private void CargarCitas(string estado = null)
        {
            var citas = servicioCita.LoadByID(UsuarioActual.Cedula);

            if (ValidarFiltroEstado(CBFiltrarEstado.Checked, estado))
            {
                citas = servicioCita.LoadByFilters(estado, UsuarioActual.Cedula);
            }
            DGVCitas.DataSource = citas;
        }
        public Cita CitaSeleccionada()
        {
            var codigoCita = DGVCitas.SelectedRows[0].Cells["Codigo"].Value.ToString();

            Cita citaSeleccionada = servicioCita.GetByID(codigoCita);
            return citaSeleccionada;
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            AbrirInformacion();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !ValidarEstado())
            {
                return;
            }
            AbrirActualizar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !ValidarEstado())
            {
                return;
            }
            if (Confirmar())
            {
                CancelarCita();
            }
        }
        void AbrirInformacion()
        {
            Cita cita = CitaSeleccionada();
            FrmInformacion F = new FrmInformacion(cita);
            F.Show();
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
            return vali.ValidarFiltroEstado(activo, texto);
        }
        void AbrirActualizar()
        {
            Cita cita = CitaSeleccionada();
            FrmActualizarCita F = new FrmActualizarCita(cita);
            F.Show();
        }

        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea eliminar dicha cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        void CancelarCita()
        {
            Cita cita = CitaSeleccionada();
            servicioCita.Delete(cita);
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            string estadoSeleccionado = CBEstado.SelectedItem?.ToString();
            CargarCitas(estadoSeleccionado);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
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
    }
}