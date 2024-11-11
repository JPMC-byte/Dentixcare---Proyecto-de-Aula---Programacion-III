﻿using BLL;
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
    public partial class FrmGestionFactura : Form
    {
        ServicioFactura servisFactu = new ServicioFactura();
        public FrmGestionFactura()
        {
            InitializeComponent();
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

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (!Verificar()) { return; }
            abrirMasInformacion();
        }
        void abrirMasInformacion()
        {
            Factura factura = FacturaSeleccionada();
            FrmInfoFactura F = new FrmInfoFactura(factura);
            F.Show();

        }
    }
}