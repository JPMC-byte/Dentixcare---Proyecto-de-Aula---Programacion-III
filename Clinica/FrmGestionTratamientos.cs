using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class FrmGestionTratamientos : Form
    {
        Diagnostico diagnosticoActual;
        ServicioTratamiento servistrat = new ServicioTratamiento();
        public FrmGestionTratamientos(Diagnostico diagnostico = null)
        {
            InitializeComponent();
            diagnosticoActual = diagnostico;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MoverPestaña()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void determinarIndependencia()
        {
            if (this.Parent == null)
            {
                btnInformacion.Enabled = false;
                btnActualizarRegistro.Enabled = false;
                btnEliminar.Enabled = false;
                btnActualizarTratamiento.Enabled = false;
                btnFacturaRelacionada.Enabled = false;
            }
        }
        private void FrmGestionTratamientos_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Parent == null) MoverPestaña();
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
            determinarIndependencia();
            CargarTratamientos();
        }

        public void CargarTratamientos()
        { 
            var Tratamientos = servistrat.GetAll();
            if (this.Parent == null) Tratamientos = servistrat.LoadByDiagnostico(diagnosticoActual.Codigo);
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
            Tratamiento tratamiento = TratamientoSeleccionado();
            FrmInfoTratamiento F = new FrmInfoTratamiento(tratamiento);
            F.Show();
        }
    }
}
