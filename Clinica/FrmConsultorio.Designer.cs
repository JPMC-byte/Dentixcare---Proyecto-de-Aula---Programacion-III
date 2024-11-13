namespace GUI
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
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.LBBarrio = new System.Windows.Forms.Label();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.LBNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtHoraCierre = new System.Windows.Forms.TextBox();
            this.txtHoraApertura = new System.Windows.Forms.TextBox();
            this.LBHoraCierre = new System.Windows.Forms.Label();
            this.LBHoraApertura = new System.Windows.Forms.Label();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtManzana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.LBPerfil.Location = new System.Drawing.Point(22, 59);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(425, 39);
            this.LBPerfil.TabIndex = 65;
            this.LBPerfil.Text = "Información del consultorio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.IconConsultorio;
            this.pictureBox1.Location = new System.Drawing.Point(491, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::GUI.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(745, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 63;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.BackColor = System.Drawing.Color.White;
            this.txtBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.ForeColor = System.Drawing.Color.DimGray;
            this.txtBarrio.Location = new System.Drawing.Point(29, 316);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(198, 20);
            this.txtBarrio.TabIndex = 73;
            this.txtBarrio.Text = "BARRIO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(29, 238);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 20);
            this.txtTelefono.TabIndex = 71;
            this.txtTelefono.Text = "TELEFONO";
            // 
            // LBBarrio
            // 
            this.LBBarrio.AutoSize = true;
            this.LBBarrio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBarrio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBBarrio.Location = new System.Drawing.Point(25, 294);
            this.LBBarrio.Name = "LBBarrio";
            this.LBBarrio.Size = new System.Drawing.Size(54, 19);
            this.LBBarrio.TabIndex = 72;
            this.LBBarrio.Text = "Barrio";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTelefono.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBTelefono.Location = new System.Drawing.Point(25, 216);
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
            this.LBNombre.Location = new System.Drawing.Point(267, 216);
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
            this.txtNombre.Location = new System.Drawing.Point(271, 238);
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
            this.LBCodigo.Location = new System.Drawing.Point(25, 146);
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
            this.txtCodigo.Location = new System.Drawing.Point(29, 168);
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
            this.txtHoraCierre.Location = new System.Drawing.Point(271, 485);
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
            this.txtHoraApertura.Location = new System.Drawing.Point(29, 485);
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
            this.LBHoraCierre.Location = new System.Drawing.Point(267, 463);
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
            this.LBHoraApertura.Location = new System.Drawing.Point(25, 463);
            this.LBHoraApertura.Name = "LBHoraApertura";
            this.LBHoraApertura.Size = new System.Drawing.Size(138, 19);
            this.LBHoraApertura.TabIndex = 74;
            this.LBHoraApertura.Text = "Hora de apertura";
            // 
            // txtEtapa
            // 
            this.txtEtapa.BackColor = System.Drawing.Color.White;
            this.txtEtapa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEtapa.Enabled = false;
            this.txtEtapa.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtapa.ForeColor = System.Drawing.Color.DimGray;
            this.txtEtapa.Location = new System.Drawing.Point(29, 399);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.Size = new System.Drawing.Size(198, 20);
            this.txtEtapa.TabIndex = 79;
            this.txtEtapa.Text = "ETAPA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(25, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Etapa";
            // 
            // txtManzana
            // 
            this.txtManzana.BackColor = System.Drawing.Color.White;
            this.txtManzana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManzana.Enabled = false;
            this.txtManzana.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManzana.ForeColor = System.Drawing.Color.DimGray;
            this.txtManzana.Location = new System.Drawing.Point(271, 316);
            this.txtManzana.Name = "txtManzana";
            this.txtManzana.Size = new System.Drawing.Size(198, 20);
            this.txtManzana.TabIndex = 81;
            this.txtManzana.Text = "MANZANA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(267, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Manzana";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Enabled = false;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.ForeColor = System.Drawing.Color.DimGray;
            this.txtCalle.Location = new System.Drawing.Point(271, 399);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(198, 20);
            this.txtCalle.TabIndex = 83;
            this.txtCalle.Text = "CALLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(267, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 82;
            this.label3.Text = "Calle";
            // 
            // FrmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManzana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEtapa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoraCierre);
            this.Controls.Add(this.txtHoraApertura);
            this.Controls.Add(this.LBHoraCierre);
            this.Controls.Add(this.LBHoraApertura);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.LBBarrio);
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
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label LBBarrio;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtHoraCierre;
        private System.Windows.Forms.TextBox txtHoraApertura;
        private System.Windows.Forms.Label LBHoraCierre;
        private System.Windows.Forms.Label LBHoraApertura;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtManzana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label3;
    }
}