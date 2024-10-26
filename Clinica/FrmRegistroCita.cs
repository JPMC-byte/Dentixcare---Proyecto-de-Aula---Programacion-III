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

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            VerInformacion();
        }
        void VerInformacion()
        {
            if (!Verificar())
            {
                return;
            }
            var codigoCita = DGVCitas.SelectedRows[0].Cells["Codigo"].Value.ToString();
            var codigoConsultorio = DGVCitas.SelectedRows[0].Cells["CodigoConsultorio"].Value.ToString();

            Consultorio Consultorio = servisconsulto.CargarConsultorio(codigoConsultorio);
            Cita citaSeleccionada = servicioCita.GetByID(codigoCita);
            AbrirInformacion(citaSeleccionada, Consultorio);
        }
        void AbrirInformacion(Cita cita, Consultorio consultorio)
        {
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
             ActualizarCita(); 
        }
        void ActualizarCita()
        {
            if (!Verificar())
            {
                return;
            }
            var codigoCita = DGVCitas.SelectedRows[0].Cells["Codigo"].Value.ToString();

            Cita citaSeleccionada = servicioCita.GetByID(codigoCita);
            AbrirActualizar(citaSeleccionada);
        }

        void AbrirActualizar(Cita cita)
        {
            FrmActualizarCita F = new FrmActualizarCita(cita);
            F.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            CargarCitas();
        }
    }
}