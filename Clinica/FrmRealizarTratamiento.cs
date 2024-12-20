﻿using BLL;
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
            if (!Verificar() || !validarMonto())
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
        bool ValidarNumeros(KeyPressEventArgs e)
        {
            if (!vali.ValidarNumeros(e))
            {
                return false;
            }
            return true;
        }
        bool validarMonto()
        {
            double monto = Convert.ToDouble(txtCosto.Text);
            if (!vali.ValidarMonto(monto))
            {
                MessageBox.Show("Error - El monto asignado no es valido", "Acción no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e) { if (!ValidarNumeros(e)) e.Handled = true; }

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
