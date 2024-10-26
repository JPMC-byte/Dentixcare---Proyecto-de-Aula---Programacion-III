namespace Clinica
{
    partial class FrmAgendarCita
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
            this.txtRazonCita = new System.Windows.Forms.TextBox();
            this.DTFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.DTHora = new System.Windows.Forms.DateTimePicker();
            this.LBHoraEstimada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrado = new System.Windows.Forms.Button();
            this.GPAgendarCita = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPAgendarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(6, 16);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(268, 39);
            this.LBTitulo.TabIndex = 6;
            this.LBTitulo.Text = "Agendar una cita";
            // 
            // txtRazonCita
            // 
            this.txtRazonCita.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonCita.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonCita.ForeColor = System.Drawing.Color.DimGray;
            this.txtRazonCita.Location = new System.Drawing.Point(13, 172);
            this.txtRazonCita.Multiline = true;
            this.txtRazonCita.Name = "txtRazonCita";
            this.txtRazonCita.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRazonCita.Size = new System.Drawing.Size(441, 240);
            this.txtRazonCita.TabIndex = 32;
            this.txtRazonCita.Text = "RAZON DE CITA";
            this.txtRazonCita.Enter += new System.EventHandler(this.txtRazonCita_Enter);
            this.txtRazonCita.Leave += new System.EventHandler(this.txtRazonCita_Leave);
            // 
            // DTFecha_Nacimiento
            // 
            this.DTFecha_Nacimiento.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFecha_Nacimiento.Location = new System.Drawing.Point(254, 100);
            this.DTFecha_Nacimiento.Name = "DTFecha_Nacimiento";
            this.DTFecha_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.DTFecha_Nacimiento.TabIndex = 34;
            this.DTFecha_Nacimiento.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // DTHora
            // 
            this.DTHora.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHora.Location = new System.Drawing.Point(13, 100);
            this.DTHora.Name = "DTHora";
            this.DTHora.ShowUpDown = true;
            this.DTHora.Size = new System.Drawing.Size(200, 20);
            this.DTHora.TabIndex = 35;
            this.DTHora.Value = new System.DateTime(2024, 10, 15, 0, 0, 0, 0);
            // 
            // LBHoraEstimada
            // 
            this.LBHoraEstimada.AutoSize = true;
            this.LBHoraEstimada.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBHoraEstimada.Location = new System.Drawing.Point(9, 78);
            this.LBHoraEstimada.Name = "LBHoraEstimada";
            this.LBHoraEstimada.Size = new System.Drawing.Size(119, 19);
            this.LBHoraEstimada.TabIndex = 36;
            this.LBHoraEstimada.Text = "Hora estimada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha estimada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Razon de cita";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.Properties.Resources.IconPapeles;
            this.pictureBox1.Location = new System.Drawing.Point(492, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 440);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(204, 50);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrado
            // 
            this.btnRegistrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrado.FlatAppearance.BorderSize = 0;
            this.btnRegistrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrado.Location = new System.Drawing.Point(254, 440);
            this.btnRegistrado.Name = "btnRegistrado";
            this.btnRegistrado.Size = new System.Drawing.Size(213, 50);
            this.btnRegistrado.TabIndex = 40;
            this.btnRegistrado.Text = "Registrar";
            this.btnRegistrado.UseVisualStyleBackColor = false;
            this.btnRegistrado.Click += new System.EventHandler(this.btnRegistrado_Click);
            // 
            // GPAgendarCita
            // 
            this.GPAgendarCita.BackColor = System.Drawing.Color.Transparent;
            this.GPAgendarCita.Controls.Add(this.LBTitulo);
            this.GPAgendarCita.Controls.Add(this.btnLimpiar);
            this.GPAgendarCita.Controls.Add(this.pictureBox1);
            this.GPAgendarCita.Controls.Add(this.btnRegistrado);
            this.GPAgendarCita.Controls.Add(this.txtRazonCita);
            this.GPAgendarCita.Controls.Add(this.label2);
            this.GPAgendarCita.Controls.Add(this.DTFecha_Nacimiento);
            this.GPAgendarCita.Controls.Add(this.label1);
            this.GPAgendarCita.Controls.Add(this.DTHora);
            this.GPAgendarCita.Controls.Add(this.LBHoraEstimada);
            this.GPAgendarCita.Location = new System.Drawing.Point(12, 91);
            this.GPAgendarCita.Name = "GPAgendarCita";
            this.GPAgendarCita.Size = new System.Drawing.Size(753, 505);
            this.GPAgendarCita.TabIndex = 42;
            this.GPAgendarCita.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Clinica.Properties.Resources.Fondo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(777, 699);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.GPAgendarCita);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgendarCita";
            this.Text = "FrmAgendarCita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPAgendarCita.ResumeLayout(false);
            this.GPAgendarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRazonCita;
        private System.Windows.Forms.DateTimePicker DTFecha_Nacimiento;
        private System.Windows.Forms.DateTimePicker DTHora;
        private System.Windows.Forms.Label LBHoraEstimada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrado;
        private System.Windows.Forms.GroupBox GPAgendarCita;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}