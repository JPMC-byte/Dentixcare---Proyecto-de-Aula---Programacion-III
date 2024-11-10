namespace Clinica
{
    partial class FrmRealizarDiagnostico
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
            this.LBTitulo = new System.Windows.Forms.Label();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.btnRegistrado = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.LBFechaDiagnostico = new System.Windows.Forms.Label();
            this.txtDescripcionDiag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCodigoCita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(12, 42);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(376, 39);
            this.LBTitulo.TabIndex = 62;
            this.LBTitulo.Text = "Registrar un diagnostico";
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCodigo.Location = new System.Drawing.Point(15, 109);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(63, 19);
            this.LBCodigo.TabIndex = 67;
            this.LBCodigo.Text = "Codigo";
            // 
            // btnRegistrado
            // 
            this.btnRegistrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrado.FlatAppearance.BorderSize = 0;
            this.btnRegistrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrado.Location = new System.Drawing.Point(260, 559);
            this.btnRegistrado.Name = "btnRegistrado";
            this.btnRegistrado.Size = new System.Drawing.Size(213, 50);
            this.btnRegistrado.TabIndex = 70;
            this.btnRegistrado.Text = "Registrar";
            this.btnRegistrado.UseVisualStyleBackColor = false;
            this.btnRegistrado.Click += new System.EventHandler(this.btnRegistrado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 559);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(204, 50);
            this.btnLimpiar.TabIndex = 71;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // LBFechaDiagnostico
            // 
            this.LBFechaDiagnostico.AutoSize = true;
            this.LBFechaDiagnostico.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFechaDiagnostico.Location = new System.Drawing.Point(227, 109);
            this.LBFechaDiagnostico.Name = "LBFechaDiagnostico";
            this.LBFechaDiagnostico.Size = new System.Drawing.Size(161, 19);
            this.LBFechaDiagnostico.TabIndex = 68;
            this.LBFechaDiagnostico.Text = "Fecha de realización";
            // 
            // txtDescripcionDiag
            // 
            this.txtDescripcionDiag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionDiag.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDiag.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcionDiag.Location = new System.Drawing.Point(19, 291);
            this.txtDescripcionDiag.Multiline = true;
            this.txtDescripcionDiag.Name = "txtDescripcionDiag";
            this.txtDescripcionDiag.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcionDiag.Size = new System.Drawing.Size(441, 240);
            this.txtDescripcionDiag.TabIndex = 64;
            this.txtDescripcionDiag.Text = "DESCRIPCION";
            this.txtDescripcionDiag.Enter += new System.EventHandler(this.txtDescripcionDiag_Enter);
            this.txtDescripcionDiag.Leave += new System.EventHandler(this.txtDescripcionDiag_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(19, 134);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 22);
            this.txtCodigo.TabIndex = 73;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(231, 134);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(157, 22);
            this.txtFecha.TabIndex = 74;
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(231, 212);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(157, 22);
            this.txtCedula.TabIndex = 78;
            // 
            // txtCodigoCita
            // 
            this.txtCodigoCita.Enabled = false;
            this.txtCodigoCita.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCita.Location = new System.Drawing.Point(19, 212);
            this.txtCodigoCita.Name = "txtCodigoCita";
            this.txtCodigoCita.Size = new System.Drawing.Size(118, 22);
            this.txtCodigoCita.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Codigo de la cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Cedula del paciente";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Clinica.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(745, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 72;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.Properties.Resources.IconDiagnostico;
            this.pictureBox1.Location = new System.Drawing.Point(480, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Clinica.Properties.Resources.Minimizar;
            this.BtnMinimizar.Location = new System.Drawing.Point(719, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 79;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // FrmRealizarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCodigoCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.LBCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.LBFechaDiagnostico);
            this.Controls.Add(this.txtDescripcionDiag);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRealizarDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRealizarDiagnostico";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRealizarDiagnostico_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label LBFechaDiagnostico;
        private System.Windows.Forms.TextBox txtDescripcionDiag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCodigoCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BtnMinimizar;
    }
}