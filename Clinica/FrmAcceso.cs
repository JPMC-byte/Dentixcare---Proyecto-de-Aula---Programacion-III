﻿using System;
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
    public partial class FrmAcceso : Form
    {
        FrmRegistrar frmRegistrar = new FrmRegistrar();
        FrmContraseña frmContraseña = new FrmContraseña();
        public FrmAcceso()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMedico_Click(object sender, EventArgs e)
        {
            IngresoMedico();
        }

        private void IngresoMedico()
        {
            frmContraseña.Show();
            this.Close();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            IngresoPaciente();
        }

        private void IngresoPaciente()
        {
            frmRegistrar.Show();
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var f = new FrmIngreso();
            f.Show();
            this.Close();
        }

        private void FrmAcceso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
