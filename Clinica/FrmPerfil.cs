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
            Sobreponer();
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
        private void Sobreponer()
        {
            LBPerfil.BringToFront();
            LBNombre.BringToFront();
            LBApellido.BringToFront();
            LBTelefono.BringToFront();
            LBCedula.BringToFront();
            LBFecha.BringToFront();
            LBEdad.BringToFront();
            LBCategoria.BringToFront();
            LBID.BringToFront();
            IconPerson.BringToFront();
            txtNombre.BringToFront();
            txtApellido.BringToFront();
            txtTelefono.BringToFront();
            txtCedula.BringToFront();
            txtEdad.BringToFront();
            txtFechaNacimiento.BringToFront();
            txtEdad.BringToFront();
            txtCategoria.BringToFront();
            txtIDConsultorio.BringToFront();

        }
    }
}
