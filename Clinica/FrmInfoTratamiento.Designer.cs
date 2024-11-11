namespace Clinica
{
    partial class FrmInfoTratamiento
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.LBRazon = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.LBPerfil = new System.Windows.Forms.Label();
            this.LBCedulaPaciente = new System.Windows.Forms.Label();
            this.txtCodigoDiag = new System.Windows.Forms.TextBox();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.Properties.Resources.IconTratamiento;
            this.pictureBox1.Location = new System.Drawing.Point(11, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(314, 417);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(452, 237);
            this.txtDescripcion.TabIndex = 88;
            this.txtDescripcion.Text = "DESCRIPCION";
            // 
            // LBRazon
            // 
            this.LBRazon.AutoSize = true;
            this.LBRazon.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRazon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBRazon.Location = new System.Drawing.Point(304, 395);
            this.LBRazon.Name = "LBRazon";
            this.LBRazon.Size = new System.Drawing.Size(97, 19);
            this.LBRazon.TabIndex = 87;
            this.LBRazon.Text = "Descripcion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracion.Enabled = false;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDuracion.Location = new System.Drawing.Point(308, 331);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(199, 20);
            this.txtDuracion.TabIndex = 86;
            this.txtDuracion.Text = "DURACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(304, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Duración";
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Clinica.Properties.Resources.Minimizar;
            this.BtnMinimizar.Location = new System.Drawing.Point(718, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 84;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Clinica.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(744, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 83;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // LBPerfil
            // 
            this.LBPerfil.AutoSize = true;
            this.LBPerfil.BackColor = System.Drawing.Color.Transparent;
            this.LBPerfil.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBPerfil.Location = new System.Drawing.Point(3, 60);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(433, 39);
            this.LBPerfil.TabIndex = 82;
            this.LBPerfil.Text = "Información del tratamiento";
            // 
            // LBCedulaPaciente
            // 
            this.LBCedulaPaciente.AutoSize = true;
            this.LBCedulaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCedulaPaciente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBCedulaPaciente.Location = new System.Drawing.Point(564, 148);
            this.LBCedulaPaciente.Name = "LBCedulaPaciente";
            this.LBCedulaPaciente.Size = new System.Drawing.Size(178, 19);
            this.LBCedulaPaciente.TabIndex = 78;
            this.LBCedulaPaciente.Text = "Codigo de diagnostico";
            // 
            // txtCodigoDiag
            // 
            this.txtCodigoDiag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoDiag.Enabled = false;
            this.txtCodigoDiag.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDiag.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoDiag.Location = new System.Drawing.Point(568, 170);
            this.txtCodigoDiag.Name = "txtCodigoDiag";
            this.txtCodigoDiag.Size = new System.Drawing.Size(198, 20);
            this.txtCodigoDiag.TabIndex = 79;
            this.txtCodigoDiag.Text = "CODIGO DEL DIAGNOSTICO";
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCodigo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBCodigo.Location = new System.Drawing.Point(304, 148);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(63, 19);
            this.LBCodigo.TabIndex = 76;
            this.LBCodigo.Text = "Codigo";
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoFactura.Enabled = false;
            this.txtCodigoFactura.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFactura.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoFactura.Location = new System.Drawing.Point(434, 252);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(199, 20);
            this.txtCodigoFactura.TabIndex = 81;
            this.txtCodigoFactura.Text = "CODIGO DE FACTURA";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTelefono.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBTelefono.Location = new System.Drawing.Point(430, 230);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(144, 19);
            this.LBTelefono.TabIndex = 80;
            this.LBTelefono.Text = "Codigo de factura";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(308, 170);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 77;
            this.txtCodigo.Text = "CODIGO";
            // 
            // txtCosto
            // 
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.DimGray;
            this.txtCosto.Location = new System.Drawing.Point(568, 331);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(199, 20);
            this.txtCosto.TabIndex = 91;
            this.txtCosto.Text = "COSTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(564, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = "Costo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Clinica.Properties.Resources.IconDolar;
            this.pictureBox2.Location = new System.Drawing.Point(538, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // FrmInfoTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.LBRazon);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.LBPerfil);
            this.Controls.Add(this.LBCedulaPaciente);
            this.Controls.Add(this.txtCodigoDiag);
            this.Controls.Add(this.LBCodigo);
            this.Controls.Add(this.txtCodigoFactura);
            this.Controls.Add(this.LBTelefono);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInfoTratamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInfoTratamiento";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmInfoTratamiento_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label LBRazon;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label LBPerfil;
        private System.Windows.Forms.Label LBCedulaPaciente;
        private System.Windows.Forms.TextBox txtCodigoDiag;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}