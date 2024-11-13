﻿using ENTITY;
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
    public partial class FrmInfoFactura : Form
    {
        Factura facturaActual;
        public FrmInfoFactura(Factura factura)
        {
            InitializeComponent();
            facturaActual = factura;
            cargarDatos(facturaActual);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FrmInfoFactura_MouseDown(object sender, MouseEventArgs e)
        {
            moverCursor();
        }
        public void cargarDatos(Factura factura)
        {
            txtCodigo.Text = factura.ID_Factura;
            txtFecha.Text = factura.Fecha_Emision.ToString("dd-MM-yyyy");
            txtEstado.Text = factura.Estado;
            txtMontoTotal.Text = factura.Total.ToString();
            txtTotalPagado.Text = factura.Total_Pagado.ToString();
            txtCambio.Text = factura.Cambio.ToString();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void cerrar()
        {
            this.Close();
        }
        void moverCursor()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
