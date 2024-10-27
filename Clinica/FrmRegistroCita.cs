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
        private void CargarCitas()
        {
            DGVCitas.DataSource = servicioCita.LoadByID(UsuarioActual.Cedula);
        }
        public Cita CitaSeleccionada()
        {
            var codigoCita = DGVCitas.SelectedRows[0].Cells["Codigo"].Value.ToString();

            Cita citaSeleccionada = servicioCita.GetByID(codigoCita);
            return citaSeleccionada;
        }
        public Consultorio ConsultorioSeleccionado()
        {
            var codigoConsultorio = DGVCitas.SelectedRows[0].Cells["CodigoConsultorio"].Value.ToString();
            Consultorio Consultorio = servisconsulto.CargarConsultorio(codigoConsultorio);
            return Consultorio;
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            AbrirInformacion();
        }
        void AbrirInformacion()
        {
            Cita cita = CitaSeleccionada();
            Consultorio consultorio = ConsultorioSeleccionado();
            FrmInformacion F = new FrmInformacion(cita,consultorio);
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            AbrirActualizar();
        }
        void AbrirActualizar()
        {
            Cita cita = CitaSeleccionada();
            FrmActualizarCita F = new FrmActualizarCita(cita);
            F.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!Verificar())
            {
                return;
            }
            if (Confirmar())
            {
                CancelarCita();
            }
        }
        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea actualizar dicha cita?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        void CancelarCita()
        {
            Cita cita = CitaSeleccionada();
            servicioCita.Delete(cita);
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
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