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
    public partial class FrmGestionTratamientos : Form
    {
        ServicioTratamiento servistrat = new ServicioTratamiento();
        public FrmGestionTratamientos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }

        private void FrmGestionTratamientos_Load(object sender, EventArgs e)
        {
            CargarTratamientos();
        }

        public void CargarTratamientos()
        {
            var Tratamientos = servistrat.GetAll();
            DGVTratamiento.DataSource = Tratamientos;
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            CargarTratamientos();
        }
        void Actualizar()
        {
            CargarTratamientos();
        }
        public Tratamiento TratamientoSeleccionado()
        {
            var IDTratamiento = DGVTratamiento.SelectedRows[0].Cells["ID_Tratamiento"].Value.ToString();

            Tratamiento tratamientoSeleccionado = servistrat.GetByID(IDTratamiento);
            return tratamientoSeleccionado;
        }
        bool Verificar()
        {
            if (DGVTratamiento.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tratamiento de la lista para realizar dicha acción", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            AbrirInformacion();
        }
        void AbrirInformacion()
        {

        }
    }
}
