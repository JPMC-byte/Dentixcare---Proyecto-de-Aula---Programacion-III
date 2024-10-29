namespace Clinica
{
    partial class FrmGestionCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBFiltro = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.DGVCitas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.CBFiltrarEstado = new System.Windows.Forms.CheckBox();
            this.CBFiltrarPorPaciente = new System.Windows.Forms.CheckBox();
            this.btnInformacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // LBFiltro
            // 
            this.LBFiltro.AutoSize = true;
            this.LBFiltro.BackColor = System.Drawing.Color.Transparent;
            this.LBFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiltro.ForeColor = System.Drawing.Color.Black;
            this.LBFiltro.Location = new System.Drawing.Point(306, 21);
            this.LBFiltro.Name = "LBFiltro";
            this.LBFiltro.Size = new System.Drawing.Size(137, 19);
            this.LBFiltro.TabIndex = 76;
            this.LBFiltro.Text = "Filtrar por estado";
            // 
            // CBEstado
            // 
            this.CBEstado.Enabled = false;
            this.CBEstado.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.ForeColor = System.Drawing.Color.DimGray;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "N/A",
            "Solicitada",
            "Pendiente",
            "Finalizada"});
            this.CBEstado.Location = new System.Drawing.Point(310, 43);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(121, 24);
            this.CBEstado.TabIndex = 75;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(547, 624);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 50);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.Text = "Actualizar registro";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDiagnostico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiagnostico.FlatAppearance.BorderSize = 0;
            this.btnDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostico.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.btnDiagnostico.Location = new System.Drawing.Point(379, 624);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(162, 50);
            this.btnDiagnostico.TabIndex = 72;
            this.btnDiagnostico.Text = "Realizar diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Clinica.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(745, 20);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 71;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.FlatAppearance.BorderSize = 0;
            this.btnAtender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtender.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.ForeColor = System.Drawing.Color.Black;
            this.btnAtender.Location = new System.Drawing.Point(211, 624);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(162, 50);
            this.btnAtender.TabIndex = 70;
            this.btnAtender.Text = "Atender cita";
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.ForeColor = System.Drawing.Color.Black;
            this.LBTitulo.Location = new System.Drawing.Point(12, 28);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(260, 39);
            this.LBTitulo.TabIndex = 68;
            this.LBTitulo.Text = "Registro de citas";
            // 
            // DGVCitas
            // 
            this.DGVCitas.AllowUserToAddRows = false;
            this.DGVCitas.AllowUserToDeleteRows = false;
            this.DGVCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVCitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCitas.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DGVCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVCitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVCitas.ColumnHeadersHeight = 30;
            this.DGVCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCitas.EnableHeadersVisualStyles = false;
            this.DGVCitas.Location = new System.Drawing.Point(19, 83);
            this.DGVCitas.Name = "DGVCitas";
            this.DGVCitas.ReadOnly = true;
            this.DGVCitas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGVCitas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVCitas.Size = new System.Drawing.Size(709, 535);
            this.DGVCitas.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(500, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "Filtrar por paciente";
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Enabled = false;
            this.txtCedulaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedulaPaciente.Location = new System.Drawing.Point(504, 46);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(147, 22);
            this.txtCedulaPaciente.TabIndex = 78;
            this.txtCedulaPaciente.Text = "CEDULA DEL PACIENTE";
            this.txtCedulaPaciente.Enter += new System.EventHandler(this.txtCedulaPaciente_Enter);
            this.txtCedulaPaciente.Leave += new System.EventHandler(this.txtCedulaPaciente_Leave);
            // 
            // CBFiltrarEstado
            // 
            this.CBFiltrarEstado.AutoSize = true;
            this.CBFiltrarEstado.Location = new System.Drawing.Point(285, 36);
            this.CBFiltrarEstado.Name = "CBFiltrarEstado";
            this.CBFiltrarEstado.Size = new System.Drawing.Size(15, 14);
            this.CBFiltrarEstado.TabIndex = 79;
            this.CBFiltrarEstado.UseVisualStyleBackColor = true;
            this.CBFiltrarEstado.CheckedChanged += new System.EventHandler(this.CBFiltrarEstado_CheckedChanged);
            // 
            // CBFiltrarPorPaciente
            // 
            this.CBFiltrarPorPaciente.AutoSize = true;
            this.CBFiltrarPorPaciente.Location = new System.Drawing.Point(479, 36);
            this.CBFiltrarPorPaciente.Name = "CBFiltrarPorPaciente";
            this.CBFiltrarPorPaciente.Size = new System.Drawing.Size(15, 14);
            this.CBFiltrarPorPaciente.TabIndex = 80;
            this.CBFiltrarPorPaciente.UseVisualStyleBackColor = true;
            this.CBFiltrarPorPaciente.CheckedChanged += new System.EventHandler(this.CBFiltrarPorPaciente_CheckedChanged);
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.Color.Black;
            this.btnInformacion.Location = new System.Drawing.Point(43, 624);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(162, 50);
            this.btnInformacion.TabIndex = 81;
            this.btnInformacion.Text = "Más información";
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // FrmGestionCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.CBFiltrarPorPaciente);
            this.Controls.Add(this.CBFiltrarEstado);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBFiltro);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.DGVCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionCita";
            this.Text = "FrmGestionCita";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBFiltro;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.DataGridView DGVCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.CheckBox CBFiltrarEstado;
        private System.Windows.Forms.CheckBox CBFiltrarPorPaciente;
        private System.Windows.Forms.Button btnInformacion;
    }
}