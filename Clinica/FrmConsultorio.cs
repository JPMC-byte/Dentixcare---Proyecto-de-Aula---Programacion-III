﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace GUI
{
    public partial class FrmConsultorio : Form
    {
        Consultorio consultorioActual;
        public FrmConsultorio(Consultorio consultorio)
        {
            InitializeComponent();
            consultorioActual = consultorio;
            CargarDatos(consultorioActual);
        }

        void CargarDatos(Consultorio consultorio)
        {
            txtCodigo.Text = consultorio.Codigo;
            txtNombre.Text = consultorio.Nombre;
            txtTelefono.Text = consultorio.Telefono;
            txtBarrio.Text = consultorio.Barrio;
            txtEtapa.Text = consultorio.Etapa;
            txtManzana.Text = consultorio.Manzana;
            txtCalle.Text = consultorio.Calle;
            txtHoraApertura.Text = consultorio.Hora_Apertura.ToString();
            txtHoraCierre.Text = consultorio.Hora_Cierre.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        void cerrar()
        {
            this.Close();
        }

    }
}
