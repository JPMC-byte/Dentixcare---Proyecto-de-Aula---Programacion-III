namespace Clinica
{
    partial class FrmGestionPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnAntecedentes = new System.Windows.Forms.Button();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.DGVPaciente = new System.Windows.Forms.DataGridView();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.CBFiltrarPorPaciente = new System.Windows.Forms.CheckBox();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Clinica.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(745, 22);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 85;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAntecedentes
            // 
            this.btnAntecedentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAntecedentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntecedentes.FlatAppearance.BorderSize = 0;
            this.btnAntecedentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntecedentes.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntecedentes.ForeColor = System.Drawing.Color.Black;
            this.btnAntecedentes.Location = new System.Drawing.Point(272, 626);
            this.btnAntecedentes.Name = "btnAntecedentes";
            this.btnAntecedentes.Size = new System.Drawing.Size(196, 50);
            this.btnAntecedentes.TabIndex = 84;
            this.btnAntecedentes.Text = "Antecedentes";
            this.btnAntecedentes.UseVisualStyleBackColor = false;
            this.btnAntecedentes.Click += new System.EventHandler(this.btnAntecedentes_Click);
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.ForeColor = System.Drawing.Color.Black;
            this.LBTitulo.Location = new System.Drawing.Point(12, 30);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(332, 39);
            this.LBTitulo.TabIndex = 82;
            this.LBTitulo.Text = "Registro de pacientes";
            // 
            // DGVPaciente
            // 
            this.DGVPaciente.AllowUserToAddRows = false;
            this.DGVPaciente.AllowUserToDeleteRows = false;
            this.DGVPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPaciente.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DGVPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPaciente.ColumnHeadersHeight = 30;
            this.DGVPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVPaciente.EnableHeadersVisualStyles = false;
            this.DGVPaciente.Location = new System.Drawing.Point(19, 85);
            this.DGVPaciente.Name = "DGVPaciente";
            this.DGVPaciente.ReadOnly = true;
            this.DGVPaciente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGVPaciente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPaciente.Size = new System.Drawing.Size(709, 535);
            this.DGVPaciente.TabIndex = 83;
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.Color.Black;
            this.btnInformacion.Location = new System.Drawing.Point(70, 626);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(196, 50);
            this.btnInformacion.TabIndex = 94;
            this.btnInformacion.Text = "Más información";
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(474, 626);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(196, 50);
            this.btnActualizar.TabIndex = 95;
            this.btnActualizar.Text = "Actualizar registro";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // CBFiltrarPorPaciente
            // 
            this.CBFiltrarPorPaciente.AutoSize = true;
            this.CBFiltrarPorPaciente.Location = new System.Drawing.Point(498, 38);
            this.CBFiltrarPorPaciente.Name = "CBFiltrarPorPaciente";
            this.CBFiltrarPorPaciente.Size = new System.Drawing.Size(15, 14);
            this.CBFiltrarPorPaciente.TabIndex = 98;
            this.CBFiltrarPorPaciente.UseVisualStyleBackColor = true;
            this.CBFiltrarPorPaciente.CheckedChanged += new System.EventHandler(this.CBFiltrarPorPaciente_CheckedChanged);
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Enabled = false;
            this.txtCedulaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedulaPaciente.Location = new System.Drawing.Point(523, 48);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(147, 22);
            this.txtCedulaPaciente.TabIndex = 97;
            this.txtCedulaPaciente.Text = "CEDULA DEL PACIENTE";
            this.txtCedulaPaciente.Enter += new System.EventHandler(this.txtCedulaPaciente_Enter);
            this.txtCedulaPaciente.Leave += new System.EventHandler(this.txtCedulaPaciente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(519, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Filtrar por paciente";
            // 
            // FrmGestionPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.CBFiltrarPorPaciente);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAntecedentes);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.DGVPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionPaciente";
            this.Text = "FrmGestionPaciente";
            this.Load += new System.EventHandler(this.FrmGestionPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAntecedentes;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.DataGridView DGVPaciente;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox CBFiltrarPorPaciente;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Label label1;
    }
}