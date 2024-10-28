namespace Clinica
{
    partial class FrmConsultorio
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
            this.LBPerfil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.LBDireccion = new System.Windows.Forms.Label();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.LBNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtHoraCierre = new System.Windows.Forms.TextBox();
            this.txtHoraApertura = new System.Windows.Forms.TextBox();
            this.LBHoraCierre = new System.Windows.Forms.Label();
            this.LBHoraApertura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // LBPerfil
            // 
            this.LBPerfil.AutoSize = true;
            this.LBPerfil.BackColor = System.Drawing.Color.Transparent;
            this.LBPerfil.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBPerfil.Location = new System.Drawing.Point(19, 63);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(425, 39);
            this.LBPerfil.TabIndex = 65;
            this.LBPerfil.Text = "Información del consultorio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.Properties.Resources.IconConsultorio;
            this.pictureBox1.Location = new System.Drawing.Point(492, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Clinica.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(745, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 63;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDireccion.Location = new System.Drawing.Point(268, 324);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(198, 52);
            this.txtDireccion.TabIndex = 73;
            this.txtDireccion.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(26, 324);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 20);
            this.txtTelefono.TabIndex = 71;
            this.txtTelefono.Text = "TELEFONO";
            // 
            // LBDireccion
            // 
            this.LBDireccion.AutoSize = true;
            this.LBDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDireccion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBDireccion.Location = new System.Drawing.Point(264, 302);
            this.LBDireccion.Name = "LBDireccion";
            this.LBDireccion.Size = new System.Drawing.Size(80, 19);
            this.LBDireccion.TabIndex = 72;
            this.LBDireccion.Text = "Dirección";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTelefono.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBTelefono.Location = new System.Drawing.Point(22, 302);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(76, 19);
            this.LBTelefono.TabIndex = 70;
            this.LBTelefono.Text = "Telefono";
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBNombre.Location = new System.Drawing.Point(264, 180);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(72, 19);
            this.LBNombre.TabIndex = 68;
            this.LBNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(268, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 69;
            this.txtNombre.Text = "NOMBRE";
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCodigo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBCodigo.Location = new System.Drawing.Point(22, 180);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(63, 19);
            this.LBCodigo.TabIndex = 66;
            this.LBCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(26, 202);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 67;
            this.txtCodigo.Text = "CODIGO";
            // 
            // txtHoraCierre
            // 
            this.txtHoraCierre.BackColor = System.Drawing.Color.White;
            this.txtHoraCierre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraCierre.Enabled = false;
            this.txtHoraCierre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraCierre.ForeColor = System.Drawing.Color.DimGray;
            this.txtHoraCierre.Location = new System.Drawing.Point(268, 473);
            this.txtHoraCierre.Name = "txtHoraCierre";
            this.txtHoraCierre.Size = new System.Drawing.Size(198, 20);
            this.txtHoraCierre.TabIndex = 77;
            this.txtHoraCierre.Text = "HORA DE CIERRE";
            // 
            // txtHoraApertura
            // 
            this.txtHoraApertura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraApertura.Enabled = false;
            this.txtHoraApertura.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraApertura.ForeColor = System.Drawing.Color.DimGray;
            this.txtHoraApertura.Location = new System.Drawing.Point(26, 473);
            this.txtHoraApertura.Name = "txtHoraApertura";
            this.txtHoraApertura.Size = new System.Drawing.Size(199, 20);
            this.txtHoraApertura.TabIndex = 75;
            this.txtHoraApertura.Text = "HORA DE APERTURA";
            // 
            // LBHoraCierre
            // 
            this.LBHoraCierre.AutoSize = true;
            this.LBHoraCierre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHoraCierre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBHoraCierre.Location = new System.Drawing.Point(264, 451);
            this.LBHoraCierre.Name = "LBHoraCierre";
            this.LBHoraCierre.Size = new System.Drawing.Size(115, 19);
            this.LBHoraCierre.TabIndex = 76;
            this.LBHoraCierre.Text = "Hora de cierre";
            // 
            // LBHoraApertura
            // 
            this.LBHoraApertura.AutoSize = true;
            this.LBHoraApertura.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHoraApertura.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBHoraApertura.Location = new System.Drawing.Point(22, 451);
            this.LBHoraApertura.Name = "LBHoraApertura";
            this.LBHoraApertura.Size = new System.Drawing.Size(138, 19);
            this.LBHoraApertura.TabIndex = 74;
            this.LBHoraApertura.Text = "Hora de apertura";
            // 
            // FrmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.txtHoraCierre);
            this.Controls.Add(this.txtHoraApertura);
            this.Controls.Add(this.LBHoraCierre);
            this.Controls.Add(this.LBHoraApertura);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.LBDireccion);
            this.Controls.Add(this.LBTelefono);
            this.Controls.Add(this.LBNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.LBCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.LBPerfil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultorio";
            this.Text = "FrmConsultorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBPerfil;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label LBDireccion;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtHoraCierre;
        private System.Windows.Forms.TextBox txtHoraApertura;
        private System.Windows.Forms.Label LBHoraCierre;
        private System.Windows.Forms.Label LBHoraApertura;
    }
}