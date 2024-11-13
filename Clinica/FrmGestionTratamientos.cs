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

namespace GUI
{
    public partial class FrmGestionTratamientos : Form
    {
        Diagnostico diagnosticoActual;
        Factura facturaActual;
        ServicioTratamiento servistrat = new ServicioTratamiento();
        ServicioFactura servisFactu = new ServicioFactura();
        Validaciones vali = new Validaciones();
        public FrmGestionTratamientos()
        {
            InitializeComponent();
        }
        public FrmGestionTratamientos(Diagnostico diagnostico = null)
        {
            InitializeComponent();
            diagnosticoActual = diagnostico;
        }
        public FrmGestionTratamientos(Factura factura = null)
        {
            InitializeComponent();
            facturaActual = factura;
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
        private void FrmGestionTratamientos_Load(object sender, EventArgs e)
        {
            determinarIndependencia();
            CargarTratamientos();
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            CargarTratamientos();
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            AbrirInformacion();
        }
        private void btnFacturaRelacionada_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarTratamientoAsignado())
            {
                return;
            }
            abrirInfoFactura();
        }
        private void btnActualizarTratamiento_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarExistenteRelacion()) { return; }
            AbrirActualizar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarExistenteRelacion())
            {
                return;
            }
            if (Confirmar())
            {
                eliminarTratamiento();
            }
        }
        public void CargarTratamientos()
        {
            var Tratamientos = servistrat.GetAll();
            if (diagnosticoActual != null)
            {
                Tratamientos = servistrat.LoadByDiagnostico(diagnosticoActual.Codigo);
            }
            else if (facturaActual != null)
            {
                Tratamientos = servistrat.LoadByFactura(facturaActual.ID_Factura);
            }
            DGVTratamiento.DataSource = Tratamientos;
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
        public Factura FacturaRelacionada()
        {
            var IDFactura = DGVTratamiento.SelectedRows[0].Cells["CodigoFactura"].Value.ToString();

            Factura facturaSeleccionada = servisFactu.GetByID(IDFactura);
            return facturaSeleccionada;
        }
        bool Verificar()
        {
            if (DGVTratamiento.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento de la lista para realizar dicha acción", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        bool validarTratamientoAsignado()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();
            if (!vali.ValidarTratamientoAsignado(tratamiento))
            {
                MessageBox.Show("Error - Este tratamiento no presenta una factura relacionada", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        bool validarExistenteRelacion()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();
            if (vali.ValidarTratamientoAsignado(tratamiento))
            {
                MessageBox.Show("Error - No es posible alterar un tratamiento con diagnostico/factura asignada", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        bool Confirmar()
        {
            return MessageBox.Show("¿Está seguro que desea eliminar dicho registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
        void AbrirInformacion()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();
            FrmInfoTratamiento F = new FrmInfoTratamiento(tratamiento);
            F.Show();
        }
        void AbrirActualizar()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();
            FrmActualizarTratamiento F = new FrmActualizarTratamiento(tratamiento);
            F.Show();
        }

        void abrirInfoFactura()
        {
            Factura factura = FacturaRelacionada();
            FrmInfoFactura F = new FrmInfoFactura(factura);
            F.Show();
        }

        void eliminarTratamiento()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();
            servistrat.Delete(tratamiento);
            MessageBox.Show("Registro eliminado con exito");
        }
        void cerrar()
        {
            this.Close();
        }
    }
}
