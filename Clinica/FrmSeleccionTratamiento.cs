using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmSeleccionTratamiento : Form
    {
        Diagnostico diagnosticoSeleccionado;
        ServicioTratamiento servistrat = new ServicioTratamiento();
        ServicioFactura servisFac = new ServicioFactura();
        Validaciones vali = new Validaciones();
        public FrmSeleccionTratamiento(Diagnostico diagnostico)
        {
            InitializeComponent();
            diagnosticoSeleccionado = diagnostico;
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
        private void FrmSeleccionTratamiento_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPestaña();
        }
        private void FrmSeleccionTratamiento_Load(object sender, EventArgs e)
        {
            CargarTratamientos();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
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
        public void CargarTratamientos()
        {
            var Tratamientos = servistrat.GetAll();
            DGVTratamiento.DataSource = Tratamientos;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ConfirmarAsignacion() && ValidarTratamientoAsignado()) ConfirmarSeleccion();
        }
        bool ConfirmarAsignacion()
        {
            if (MessageBox.Show("¿Esta seguro de su elección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }

        void ConfirmarSeleccion()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();

            if (!ValidarExistenteFactura())
            {
                Factura factura = new Factura();
                factura.ID_Factura = servisFac.GenerarCodigo();
                factura.Fecha_Emision = DateTime.Now.Date;
                factura.Estado = "Pendiente";
                factura.Total = tratamiento.Costo;
                factura.Total_Pagado = 0;
                factura.Cambio = 0;
                servisFac.Add(factura);

                servistrat.UpdateFKDiagnostico(tratamiento, diagnosticoSeleccionado.Codigo);
                servistrat.UpdateFKFactura(tratamiento,factura.ID_Factura);
                MessageBox.Show("Una nueva factura ha sido registrada con exito");
            }
            else
            {
                string CodigoFactura = servistrat.obtenerFacturaRelacionada(diagnosticoSeleccionado.Codigo);
                Factura factura = servisFac.GetByID(CodigoFactura);

                servistrat.UpdateFKDiagnostico(tratamiento, diagnosticoSeleccionado.Codigo);
                servistrat.UpdateFKFactura(tratamiento, factura.ID_Factura);
                servisFac.SumarMonto(factura,tratamiento.Costo);
                MessageBox.Show("Se ha anexado un elemento a una factura existente");
            }
            cerrar();
        }
        bool ValidarExistenteFactura()
        {
            if (!vali.ValidarExistenteFactura(diagnosticoSeleccionado.Codigo))
            {
                return false;
            }
            return true;
        }
        bool ValidarTratamientoAsignado()
        {
            Tratamiento tratamiento = TratamientoSeleccionado();
            if (vali.ValidarTratamientoAsignado(tratamiento))
            {
                MessageBox.Show("Error - Este tratamiento ya ha sido asignado a un diagnostico", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
            return true;
        }

        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(13);
        }
        void abrirManualUsuario(int pagina)
        {
            string tempPath = Path.GetTempPath();
            string pdfPath = Path.Combine(tempPath, "ManualDeUsuario.pdf");
            using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GUI.Recursos.ManualDeUsuario.pdf"))
            {
                if (resourceStream != null)
                {
                    using (var fileStream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo PDF incrustado.");
                    return;
                }
            }
            Process pdfProcess = new Process();
            pdfProcess.StartInfo.FileName = "Acrobat.exe";
            pdfProcess.StartInfo.Arguments = $"/A \"page={pagina}\" \"{pdfPath}\"";
            pdfProcess.Start();

            pdfProcess.Exited += (s, e) =>
            {
                if (File.Exists(pdfPath))
                {
                    File.Delete(pdfPath);
                }
            };
            pdfProcess.EnableRaisingEvents = true;
        }
    }
}
