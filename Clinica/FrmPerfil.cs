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
    public partial class FrmPerfil : Form
    {
        Persona UsuarioActual;
        public FrmPerfil(Persona persona)
        {
            InitializeComponent();
            UsuarioActual = persona;
            CargarDatos(UsuarioActual);
        }
        private void CargarDatos(Persona persona)
        {
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtTelefono.Text = persona.Telefono;
            txtCedula.Text = persona.Cedula;
            txtEdad.Text = persona.Edad.ToString();
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
    }
}
