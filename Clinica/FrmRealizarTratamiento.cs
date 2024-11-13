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

namespace GUI
{
    public partial class FrmRealizarTratamiento : Form
    {
        ServicioTratamiento servisTrat = new ServicioTratamiento();
        Validaciones vali = new Validaciones();
        public FrmRealizarTratamiento()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            if (!Verificar() ||!ValidarNumeros())
            {
                return;
            }
            Registrar();
        }
        void Registrar()
        {
            Tratamiento tratamiento = new Tratamiento();
            tratamiento.ID_Tratamiento = servisTrat.GenerarCodigo();
            tratamiento.Costo = Convert.ToDouble(txtCosto.Text);
            tratamiento.Duracion = txtDuracion.Text;
            tratamiento.Descripcion = txtDescripcion.Text;
            tratamiento.CodigoDiagnostico = null;
            tratamiento.CodigoFactura = null;
            servisTrat.Add(tratamiento);
            MessageBox.Show("Proceso de registro exitoso");
            Limpiar();
        }
        bool Verificar()
        {
            if (txtCosto.Text == "COSTO" || txtDuracion.Text == "DURACION" || txtDescripcion.Text == "DESCRIPCION")
            {
                MessageBox.Show("Por favor, rellene/complete los campos vacios");
                return false;
            }
            return true;
        }
        bool ValidarNumeros()
        {
            if (!vali.ValidarNumeros(txtCosto.Text))
            {
                MessageBox.Show("El costo solo puede incluir numeros");
                return false;
            }
            return true;
        }
        void cerrar()
        {
            this.Close();
        }
        void BaseTextbox(TextBox textBox, string nombre)
        {
            textBox.Text = nombre;
            textBox.ForeColor = Color.DimGray;
        }
        private void Limpiar()
        {
            BaseTextbox(txtCosto, "COSTO");
            BaseTextbox(txtDuracion, "DURACION");
            BaseTextbox(txtDescripcion, "DESCRIPCION");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void EventoEntrarTextbox(TextBox textBox, string nombre)
        {
            if (textBox.Text == nombre)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        void EventoDejarTextbox(TextBox textBox, string nombre)
        {
            if (textBox.Text == "")
            {
                textBox.Text = nombre;
                textBox.ForeColor = Color.DimGray;
            }
        }
        private void txtCosto_Enter(object sender, EventArgs e) { EventoEntrarTextbox(txtCosto, "COSTO"); }
        private void txtCosto_Leave(object sender, EventArgs e) { EventoDejarTextbox(txtCosto, "COSTO");  }
        private void txtDuracion_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtDuracion, "DURACION");
        private void txtDuracion_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtDuracion, "DURACION");
        private void txtDescripcion_Enter(object sender, EventArgs e) => EventoEntrarTextbox(txtDescripcion, "DESCRIPCION");
        private void txtDescripcion_Leave(object sender, EventArgs e) => EventoDejarTextbox(txtDescripcion, "DESCRIPCION");
    }
}
