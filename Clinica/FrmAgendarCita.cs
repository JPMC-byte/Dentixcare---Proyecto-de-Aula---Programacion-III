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
    public partial class FrmAgendarCita : Form
    {
        Persona UsuarioActual;
        ServicioCita servisCita = new ServicioCita();
        public FrmAgendarCita(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {

        }
        private void Registrar()
        {
            if (!Verificar())
            {
                return;
            }
            Cita cita = new Cita();
            cita.CodigoPaciente = UsuarioActual.Cedula;
            cita.CodigoOrtodoncista = "No asignado";
            cita.Fecha_Cita = DTFecha_Nacimiento.Value.Date;
            cita.Fecha_Creacion = DateTime.Today.Date;
            cita.Hora_Cita = DTHora.Value.TimeOfDay;
            cita.Razon_Cita = txtRazonCita.Text;
            cita.Estado = "Solicitada/pendiente";
            servisCita.Add(cita);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtRazonCita.Text == "RAZON DE CITA")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
    }
}
