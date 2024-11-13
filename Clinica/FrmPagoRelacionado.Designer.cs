namespace GUI
{
    partial class FrmPagoRelacionado
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
            this.LBCedulaPaciente = new System.Windows.Forms.Label();
            this.LBFechaCreacion = new System.Windows.Forms.Label();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.txtFechaPago = new System.Windows.Forms.TextBox();
            this.LBFechaCita = new System.Windows.Forms.Label();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBPerfil
            // 
            this.LBPerfil.AutoSize = true;
            this.LBPerfil.BackColor = System.Drawing.Color.Transparent;
            this.LBPerfil.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBPerfil.Location = new System.Drawing.Point(12, 117);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(324, 39);
            this.LBPerfil.TabIndex = 69;
            this.LBPerfil.Text = "Información de pago";
            // 
            // LBCedulaPaciente
            // 
            this.LBCedulaPaciente.AutoSize = true;
            this.LBCedulaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCedulaPaciente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBCedulaPaciente.Location = new System.Drawing.Point(539, 418);
            this.LBCedulaPaciente.Name = "LBCedulaPaciente";
            this.LBCedulaPaciente.Size = new System.Drawing.Size(157, 19);
            this.LBCedulaPaciente.TabIndex = 61;
            this.LBCedulaPaciente.Text = "Cedula del paciente";
            // 
            // LBFechaCreacion
            // 
            this.LBFechaCreacion.AutoSize = true;
            this.LBFechaCreacion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFechaCreacion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBFechaCreacion.Location = new System.Drawing.Point(285, 325);
            this.LBFechaCreacion.Name = "LBFechaCreacion";
            this.LBFechaCreacion.Size = new System.Drawing.Size(135, 19);
            this.LBFechaCreacion.TabIndex = 66;
            this.LBFechaCreacion.Text = "Metodo de pago";
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaPaciente.Enabled = false;
            this.txtCedulaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedulaPaciente.Location = new System.Drawing.Point(543, 440);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(198, 20);
            this.txtCedulaPaciente.TabIndex = 62;
            this.txtCedulaPaciente.Text = "CEDULA DEL PACIENTE";
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCodigo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBCodigo.Location = new System.Drawing.Point(285, 228);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(63, 19);
            this.LBCodigo.TabIndex = 59;
            this.LBCodigo.Text = "Codigo";
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaPago.Enabled = false;
            this.txtFechaPago.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPago.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaPago.Location = new System.Drawing.Point(543, 250);
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(199, 20);
            this.txtFechaPago.TabIndex = 68;
            this.txtFechaPago.Text = "FECHA DE PAGO";
            // 
            // LBFechaCita
            // 
            this.LBFechaCita.AutoSize = true;
            this.LBFechaCita.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFechaCita.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBFechaCita.Location = new System.Drawing.Point(539, 228);
            this.LBFechaCita.Name = "LBFechaCita";
            this.LBFechaCita.Size = new System.Drawing.Size(119, 19);
            this.LBFechaCita.TabIndex = 67;
            this.LBFechaCita.Text = "Fecha de pago";
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoFactura.Enabled = false;
            this.txtCodigoFactura.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoFactura.Location = new System.Drawing.Point(289, 440);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(199, 20);
            this.txtCodigoFactura.TabIndex = 64;
            this.txtCodigoFactura.Text = "CODIGO DE FACTURA";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTelefono.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBTelefono.Location = new System.Drawing.Point(285, 418);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(144, 19);
            this.LBTelefono.TabIndex = 63;
            this.LBTelefono.Text = "Codigo de factura";
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetodoPago.Enabled = false;
            this.txtMetodoPago.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodoPago.ForeColor = System.Drawing.Color.DimGray;
            this.txtMetodoPago.Location = new System.Drawing.Point(289, 347);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(198, 20);
            this.txtMetodoPago.TabIndex = 65;
            this.txtMetodoPago.Text = "METODO DE PAGO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(289, 250);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 60;
            this.txtCodigo.Text = "CODIGO";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::GUI.Properties.Resources.Minimizar;
            this.BtnMinimizar.Location = new System.Drawing.Point(722, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 71;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::GUI.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(748, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 70;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(539, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.DimGray;
            this.txtMonto.Location = new System.Drawing.Point(543, 347);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(198, 20);
            this.txtMonto.TabIndex = 73;
            this.txtMonto.Text = "MONTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.IconPago;
            this.pictureBox1.Location = new System.Drawing.Point(12, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 128;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPagoRelacionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.LBPerfil);
            this.Controls.Add(this.LBCedulaPaciente);
            this.Controls.Add(this.LBFechaCreacion);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.LBCodigo);
            this.Controls.Add(this.txtFechaPago);
            this.Controls.Add(this.LBFechaCita);
            this.Controls.Add(this.txtCodigoFactura);
            this.Controls.Add(this.LBTelefono);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagoRelacionado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagoRelacionado";
            this.Load += new System.EventHandler(this.FrmPagoRelacionado_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPagoRelacionado_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBPerfil;
        private System.Windows.Forms.Label LBCedulaPaciente;
        private System.Windows.Forms.Label LBFechaCreacion;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.TextBox txtFechaPago;
        private System.Windows.Forms.Label LBFechaCita;
        private System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}