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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmGestionFactura : Form
    {
        Persona usuarioActual = new Paciente();
        ServicioFactura servisFactu = new ServicioFactura();
        Validaciones vali = new Validaciones();
        public FrmGestionFactura(Persona persona)
        {
            InitializeComponent();
            usuarioActual = persona;
        }
        private void FrmGestionFactura_Load(object sender, EventArgs e)
        {
            cargarFacturas();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            cargarFacturas();
        }
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            abrirMasInformacion();
        }
        private void btnTratamientosRelacionados_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            verTratamientosRelacionados();
        }
        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            abrirGestionPagos();
        }
        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            if (!Verificar() || !validarFacturaPagada())
            {
                return;
            }
            AbrirRealizarPago();
        }
        void cerrar()
        {
            this.Close();
        }
        void cargarFacturas()
        {
            var Facturas = servisFactu.GetAll();
            DGVFacturas.DataSource = Facturas;
        }
        bool Verificar()
        {
            if (DGVFacturas.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una factura de la lista para realizar dicha acción", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public Factura FacturaSeleccionada()
        {
            var IDFactura = DGVFacturas.SelectedRows[0].Cells["ID_Factura"].Value.ToString();

            Factura facturaSeleccionada = servisFactu.GetByID(IDFactura);
            return facturaSeleccionada;
        }
        void abrirMasInformacion()
        {
            Factura factura = FacturaSeleccionada();
            FrmInfoFactura F = new FrmInfoFactura(factura);
            F.Show();
        }
        void verTratamientosRelacionados()
        {
            Factura factura = FacturaSeleccionada();
            FrmGestionTratamientos F = new FrmGestionTratamientos(factura);
            F.Show();
        }
        bool validarFacturaPagada()
        {
            Factura factura = FacturaSeleccionada();
            if (vali.ValidarFacturaPagada(factura))
            {
                MessageBox.Show("Error - Dicha factura ya ha sido pagada", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        void AbrirRealizarPago()
        {
            Factura facturaSeleccionada = FacturaSeleccionada();
            FrmRealizarPago F = new FrmRealizarPago(facturaSeleccionada, usuarioActual);
            F.Show();
        }
        void abrirGestionPagos()
        {
            Factura factura = FacturaSeleccionada();
            FrmGestionPago F = new FrmGestionPago(factura);
            F.Show();
        }

        private void IconDudas_Click(object sender, EventArgs e)
        {
            abrirManualUsuario(10);
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
