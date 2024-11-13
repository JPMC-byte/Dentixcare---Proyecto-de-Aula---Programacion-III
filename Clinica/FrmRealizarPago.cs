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

namespace GUI
{
    public partial class FrmRealizarPago : Form
    {
        Factura factura;
        public FrmRealizarPago()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }
        void cerrar()
        {
            this.Close();
        }
        void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
