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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            InicioPaciente();
        }

        public void InicioPaciente()
        {
            var F = new FrmLogin();
            F.Show();
            this.Close();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            InicioOrtodoncista();
        }

        public void InicioOrtodoncista()
        {
            var F = new FrmLoginOrtodoncista();
            F.Show();
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
        void Volver()
        {
            var f = new FrmIngreso();
            f.Show();
            this.Close();
        }
        private void FrmInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            moverMouse();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moverMouse();
        }
        void moverMouse()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
