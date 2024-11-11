namespace Clinica
{
    partial class FrmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatosConsultorio = new System.Windows.Forms.Button();
            this.btnGestionFacturas = new System.Windows.Forms.Button();
            this.PanelSubmenuCitas = new System.Windows.Forms.Panel();
            this.btnRegistroCitas = new System.Windows.Forms.Button();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.btnGestionCitas = new System.Windows.Forms.Button();
            this.PanelSubmenuDatos = new System.Windows.Forms.Panel();
            this.btnAntecedentes = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnDatosUsuario = new System.Windows.Forms.Button();
            this.Panellogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.PanelDia = new System.Windows.Forms.Panel();
            this.PanelHijo = new System.Windows.Forms.Panel();
            this.PCFondo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PanelSubmenuCitas.SuspendLayout();
            this.PanelSubmenuDatos.SuspendLayout();
            this.Panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnDatosConsultorio);
            this.panel1.Controls.Add(this.btnGestionFacturas);
            this.panel1.Controls.Add(this.PanelSubmenuCitas);
            this.panel1.Controls.Add(this.btnGestionCitas);
            this.panel1.Controls.Add(this.PanelSubmenuDatos);
            this.panel1.Controls.Add(this.btnDatosUsuario);
            this.panel1.Controls.Add(this.Panellogo);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 799);
            this.panel1.TabIndex = 33;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnDatosConsultorio
            // 
            this.btnDatosConsultorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosConsultorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosConsultorio.FlatAppearance.BorderSize = 0;
            this.btnDatosConsultorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosConsultorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosConsultorio.ForeColor = System.Drawing.Color.White;
            this.btnDatosConsultorio.Location = new System.Drawing.Point(0, 507);
            this.btnDatosConsultorio.Name = "btnDatosConsultorio";
            this.btnDatosConsultorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatosConsultorio.Size = new System.Drawing.Size(250, 41);
            this.btnDatosConsultorio.TabIndex = 39;
            this.btnDatosConsultorio.Text = "Datos de consultorio";
            this.btnDatosConsultorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosConsultorio.UseVisualStyleBackColor = false;
            this.btnDatosConsultorio.Click += new System.EventHandler(this.btnDatosConsultorio_Click);
            // 
            // btnGestionFacturas
            // 
            this.btnGestionFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionFacturas.FlatAppearance.BorderSize = 0;
            this.btnGestionFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionFacturas.ForeColor = System.Drawing.Color.White;
            this.btnGestionFacturas.Location = new System.Drawing.Point(0, 466);
            this.btnGestionFacturas.Name = "btnGestionFacturas";
            this.btnGestionFacturas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestionFacturas.Size = new System.Drawing.Size(250, 41);
            this.btnGestionFacturas.TabIndex = 37;
            this.btnGestionFacturas.Text = "Gestión de facturas";
            this.btnGestionFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionFacturas.UseVisualStyleBackColor = false;
            this.btnGestionFacturas.Click += new System.EventHandler(this.btnGestionPagos_Click);
            // 
            // PanelSubmenuCitas
            // 
            this.PanelSubmenuCitas.Controls.Add(this.btnRegistroCitas);
            this.PanelSubmenuCitas.Controls.Add(this.btnAgendarCita);
            this.PanelSubmenuCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubmenuCitas.Location = new System.Drawing.Point(0, 379);
            this.PanelSubmenuCitas.Name = "PanelSubmenuCitas";
            this.PanelSubmenuCitas.Size = new System.Drawing.Size(250, 87);
            this.PanelSubmenuCitas.TabIndex = 36;
            this.PanelSubmenuCitas.Visible = false;
            // 
            // btnRegistroCitas
            // 
            this.btnRegistroCitas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRegistroCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroCitas.FlatAppearance.BorderSize = 0;
            this.btnRegistroCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroCitas.ForeColor = System.Drawing.Color.Black;
            this.btnRegistroCitas.Location = new System.Drawing.Point(0, 40);
            this.btnRegistroCitas.Name = "btnRegistroCitas";
            this.btnRegistroCitas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRegistroCitas.Size = new System.Drawing.Size(250, 40);
            this.btnRegistroCitas.TabIndex = 35;
            this.btnRegistroCitas.Text = "Registro de citas";
            this.btnRegistroCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroCitas.UseVisualStyleBackColor = false;
            this.btnRegistroCitas.Click += new System.EventHandler(this.btnRegistroCitas_Click);
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgendarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendarCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendarCita.FlatAppearance.BorderSize = 0;
            this.btnAgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendarCita.ForeColor = System.Drawing.Color.Black;
            this.btnAgendarCita.Location = new System.Drawing.Point(0, 0);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgendarCita.Size = new System.Drawing.Size(250, 40);
            this.btnAgendarCita.TabIndex = 34;
            this.btnAgendarCita.Text = "Agendar cita";
            this.btnAgendarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendarCita.UseVisualStyleBackColor = false;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // btnGestionCitas
            // 
            this.btnGestionCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCitas.FlatAppearance.BorderSize = 0;
            this.btnGestionCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCitas.ForeColor = System.Drawing.Color.White;
            this.btnGestionCitas.Location = new System.Drawing.Point(0, 338);
            this.btnGestionCitas.Name = "btnGestionCitas";
            this.btnGestionCitas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestionCitas.Size = new System.Drawing.Size(250, 41);
            this.btnGestionCitas.TabIndex = 35;
            this.btnGestionCitas.Text = "Gestión de citas";
            this.btnGestionCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCitas.UseVisualStyleBackColor = false;
            this.btnGestionCitas.Click += new System.EventHandler(this.btnGestionCitas_Click);
            // 
            // PanelSubmenuDatos
            // 
            this.PanelSubmenuDatos.Controls.Add(this.btnAntecedentes);
            this.PanelSubmenuDatos.Controls.Add(this.btnPerfil);
            this.PanelSubmenuDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubmenuDatos.Location = new System.Drawing.Point(0, 252);
            this.PanelSubmenuDatos.Name = "PanelSubmenuDatos";
            this.PanelSubmenuDatos.Size = new System.Drawing.Size(250, 86);
            this.PanelSubmenuDatos.TabIndex = 34;
            this.PanelSubmenuDatos.Visible = false;
            // 
            // btnAntecedentes
            // 
            this.btnAntecedentes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAntecedentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntecedentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntecedentes.FlatAppearance.BorderSize = 0;
            this.btnAntecedentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntecedentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntecedentes.ForeColor = System.Drawing.Color.Black;
            this.btnAntecedentes.Location = new System.Drawing.Point(0, 40);
            this.btnAntecedentes.Name = "btnAntecedentes";
            this.btnAntecedentes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAntecedentes.Size = new System.Drawing.Size(250, 40);
            this.btnAntecedentes.TabIndex = 35;
            this.btnAntecedentes.Text = "Antecedentes";
            this.btnAntecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAntecedentes.UseVisualStyleBackColor = false;
            this.btnAntecedentes.Click += new System.EventHandler(this.btnAntecedentes_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerfil.Size = new System.Drawing.Size(250, 40);
            this.btnPerfil.TabIndex = 34;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnDatosUsuario
            // 
            this.btnDatosUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatosUsuario.FlatAppearance.BorderSize = 0;
            this.btnDatosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosUsuario.ForeColor = System.Drawing.Color.White;
            this.btnDatosUsuario.Location = new System.Drawing.Point(0, 211);
            this.btnDatosUsuario.Name = "btnDatosUsuario";
            this.btnDatosUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatosUsuario.Size = new System.Drawing.Size(250, 41);
            this.btnDatosUsuario.TabIndex = 5;
            this.btnDatosUsuario.Text = "Datos de usuario";
            this.btnDatosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatosUsuario.UseVisualStyleBackColor = false;
            this.btnDatosUsuario.Click += new System.EventHandler(this.btnDatosUsuario_Click);
            // 
            // Panellogo
            // 
            this.Panellogo.Controls.Add(this.panel2);
            this.Panellogo.Controls.Add(this.BtnMinimizar);
            this.Panellogo.Controls.Add(this.pictureBox1);
            this.Panellogo.Controls.Add(this.label4);
            this.Panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panellogo.Location = new System.Drawing.Point(0, 0);
            this.Panellogo.Name = "Panellogo";
            this.Panellogo.Size = new System.Drawing.Size(250, 211);
            this.Panellogo.TabIndex = 4;
            this.Panellogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panellogo_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(256, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 34;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Clinica.Properties.Resources.Minimizar;
            this.BtnMinimizar.Location = new System.Drawing.Point(12, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 7;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Clinica.Properties.Resources.IconDentixcare;
            this.pictureBox1.Location = new System.Drawing.Point(50, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "DentixCare";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Location = new System.Drawing.Point(18, 729);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(212, 41);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // PanelDia
            // 
            this.PanelDia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PanelDia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDia.Location = new System.Drawing.Point(250, 699);
            this.PanelDia.Name = "PanelDia";
            this.PanelDia.Size = new System.Drawing.Size(777, 100);
            this.PanelDia.TabIndex = 34;
            // 
            // PanelHijo
            // 
            this.PanelHijo.Controls.Add(this.PCFondo);
            this.PanelHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHijo.Location = new System.Drawing.Point(250, 0);
            this.PanelHijo.Name = "PanelHijo";
            this.PanelHijo.Size = new System.Drawing.Size(777, 699);
            this.PanelHijo.TabIndex = 35;
            // 
            // PCFondo
            // 
            this.PCFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCFondo.Image = global::Clinica.Properties.Resources.Fondo;
            this.PCFondo.Location = new System.Drawing.Point(0, 0);
            this.PCFondo.Name = "PCFondo";
            this.PCFondo.Size = new System.Drawing.Size(777, 699);
            this.PCFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCFondo.TabIndex = 0;
            this.PCFondo.TabStop = false;
            this.PCFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCFondo_MouseDown);
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1027, 799);
            this.Controls.Add(this.PanelHijo);
            this.Controls.Add(this.PanelDia);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            this.panel1.ResumeLayout(false);
            this.PanelSubmenuCitas.ResumeLayout(false);
            this.PanelSubmenuDatos.ResumeLayout(false);
            this.Panellogo.ResumeLayout(false);
            this.Panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.Panel Panellogo;
        private System.Windows.Forms.Button btnDatosUsuario;
        private System.Windows.Forms.Panel PanelSubmenuDatos;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAntecedentes;
        private System.Windows.Forms.Button btnGestionCitas;
        private System.Windows.Forms.Panel PanelSubmenuCitas;
        private System.Windows.Forms.Button btnRegistroCitas;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelDia;
        private System.Windows.Forms.Panel PanelHijo;
        private System.Windows.Forms.Button btnDatosConsultorio;
        private System.Windows.Forms.Button btnGestionFacturas;
        private System.Windows.Forms.PictureBox PCFondo;
    }
}