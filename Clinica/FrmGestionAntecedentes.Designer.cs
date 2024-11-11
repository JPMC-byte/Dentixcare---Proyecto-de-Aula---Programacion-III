﻿namespace Clinica
{
    partial class FrmGestionAntecedentes
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
            this.btnInformacion = new System.Windows.Forms.Button();
            this.CBFiltrarPorPaciente = new System.Windows.Forms.CheckBox();
            this.CBFiltrarFecha = new System.Windows.Forms.CheckBox();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.LBFiltrarPorPaciente = new System.Windows.Forms.Label();
            this.LBFiltro = new System.Windows.Forms.Label();
            this.btnActualizarDiagnostico = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.DGVDiagnostico = new System.Windows.Forms.DataGridView();
            this.DTFiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.btnAsignarTratamiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.Color.Black;
            this.btnInformacion.Location = new System.Drawing.Point(4, 626);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(147, 50);
            this.btnInformacion.TabIndex = 94;
            this.btnInformacion.Text = "Más información";
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // CBFiltrarPorPaciente
            // 
            this.CBFiltrarPorPaciente.AutoSize = true;
            this.CBFiltrarPorPaciente.Location = new System.Drawing.Point(479, 38);
            this.CBFiltrarPorPaciente.Name = "CBFiltrarPorPaciente";
            this.CBFiltrarPorPaciente.Size = new System.Drawing.Size(15, 14);
            this.CBFiltrarPorPaciente.TabIndex = 93;
            this.CBFiltrarPorPaciente.UseVisualStyleBackColor = true;
            this.CBFiltrarPorPaciente.CheckedChanged += new System.EventHandler(this.CBFiltrarPorPaciente_CheckedChanged);
            // 
            // CBFiltrarFecha
            // 
            this.CBFiltrarFecha.AutoSize = true;
            this.CBFiltrarFecha.Location = new System.Drawing.Point(285, 38);
            this.CBFiltrarFecha.Name = "CBFiltrarFecha";
            this.CBFiltrarFecha.Size = new System.Drawing.Size(15, 14);
            this.CBFiltrarFecha.TabIndex = 92;
            this.CBFiltrarFecha.UseVisualStyleBackColor = true;
            this.CBFiltrarFecha.CheckedChanged += new System.EventHandler(this.CBFiltrarFecha_CheckedChanged);
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Enabled = false;
            this.txtCedulaPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedulaPaciente.Location = new System.Drawing.Point(504, 48);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(147, 22);
            this.txtCedulaPaciente.TabIndex = 91;
            this.txtCedulaPaciente.Text = "CEDULA DEL PACIENTE";
            this.txtCedulaPaciente.Enter += new System.EventHandler(this.txtCedulaPaciente_Enter);
            this.txtCedulaPaciente.Leave += new System.EventHandler(this.txtCedulaPaciente_Leave);
            // 
            // LBFiltrarPorPaciente
            // 
            this.LBFiltrarPorPaciente.AutoSize = true;
            this.LBFiltrarPorPaciente.BackColor = System.Drawing.Color.Transparent;
            this.LBFiltrarPorPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiltrarPorPaciente.ForeColor = System.Drawing.Color.Black;
            this.LBFiltrarPorPaciente.Location = new System.Drawing.Point(500, 23);
            this.LBFiltrarPorPaciente.Name = "LBFiltrarPorPaciente";
            this.LBFiltrarPorPaciente.Size = new System.Drawing.Size(151, 19);
            this.LBFiltrarPorPaciente.TabIndex = 90;
            this.LBFiltrarPorPaciente.Text = "Filtrar por paciente";
            // 
            // LBFiltro
            // 
            this.LBFiltro.AutoSize = true;
            this.LBFiltro.BackColor = System.Drawing.Color.Transparent;
            this.LBFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFiltro.ForeColor = System.Drawing.Color.Black;
            this.LBFiltro.Location = new System.Drawing.Point(306, 23);
            this.LBFiltro.Name = "LBFiltro";
            this.LBFiltro.Size = new System.Drawing.Size(128, 19);
            this.LBFiltro.TabIndex = 89;
            this.LBFiltro.Text = "Filtrar por fecha";
            // 
            // btnActualizarDiagnostico
            // 
            this.btnActualizarDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizarDiagnostico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarDiagnostico.FlatAppearance.BorderSize = 0;
            this.btnActualizarDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDiagnostico.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarDiagnostico.Location = new System.Drawing.Point(310, 626);
            this.btnActualizarDiagnostico.Name = "btnActualizarDiagnostico";
            this.btnActualizarDiagnostico.Size = new System.Drawing.Size(147, 50);
            this.btnActualizarDiagnostico.TabIndex = 87;
            this.btnActualizarDiagnostico.Text = "Actualizar diagnostico";
            this.btnActualizarDiagnostico.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(157, 626);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 50);
            this.btnEliminar.TabIndex = 84;
            this.btnEliminar.Text = "Eliminar diagnostico";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.ForeColor = System.Drawing.Color.Black;
            this.LBTitulo.Location = new System.Drawing.Point(12, 30);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(217, 39);
            this.LBTitulo.TabIndex = 82;
            this.LBTitulo.Text = "Antecedentes";
            // 
            // DGVDiagnostico
            // 
            this.DGVDiagnostico.AllowUserToAddRows = false;
            this.DGVDiagnostico.AllowUserToDeleteRows = false;
            this.DGVDiagnostico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVDiagnostico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVDiagnostico.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DGVDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDiagnostico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDiagnostico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDiagnostico.ColumnHeadersHeight = 30;
            this.DGVDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVDiagnostico.EnableHeadersVisualStyles = false;
            this.DGVDiagnostico.Location = new System.Drawing.Point(19, 85);
            this.DGVDiagnostico.Name = "DGVDiagnostico";
            this.DGVDiagnostico.ReadOnly = true;
            this.DGVDiagnostico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDiagnostico.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGVDiagnostico.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVDiagnostico.Size = new System.Drawing.Size(709, 535);
            this.DGVDiagnostico.TabIndex = 83;
            // 
            // DTFiltroFecha
            // 
            this.DTFiltroFecha.Enabled = false;
            this.DTFiltroFecha.Location = new System.Drawing.Point(310, 46);
            this.DTFiltroFecha.Name = "DTFiltroFecha";
            this.DTFiltroFecha.Size = new System.Drawing.Size(150, 20);
            this.DTFiltroFecha.TabIndex = 95;
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
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarRegistro.FlatAppearance.BorderSize = 0;
            this.btnActualizarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRegistro.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarRegistro.Location = new System.Drawing.Point(463, 626);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(147, 50);
            this.btnActualizarRegistro.TabIndex = 96;
            this.btnActualizarRegistro.Text = "Actualizar registro";
            this.btnActualizarRegistro.UseVisualStyleBackColor = false;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // btnAsignarTratamiento
            // 
            this.btnAsignarTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAsignarTratamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarTratamiento.FlatAppearance.BorderSize = 0;
            this.btnAsignarTratamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTratamiento.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTratamiento.ForeColor = System.Drawing.Color.Black;
            this.btnAsignarTratamiento.Location = new System.Drawing.Point(616, 626);
            this.btnAsignarTratamiento.Name = "btnAsignarTratamiento";
            this.btnAsignarTratamiento.Size = new System.Drawing.Size(147, 50);
            this.btnAsignarTratamiento.TabIndex = 97;
            this.btnAsignarTratamiento.Text = "Asignar un tratamiento";
            this.btnAsignarTratamiento.UseVisualStyleBackColor = false;
            // 
            // FrmGestionAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.btnAsignarTratamiento);
            this.Controls.Add(this.btnActualizarRegistro);
            this.Controls.Add(this.DTFiltroFecha);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.CBFiltrarPorPaciente);
            this.Controls.Add(this.CBFiltrarFecha);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.LBFiltrarPorPaciente);
            this.Controls.Add(this.LBFiltro);
            this.Controls.Add(this.btnActualizarDiagnostico);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.DGVDiagnostico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionAntecedentes";
            this.Text = "FrmGestionAntecedentes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.CheckBox CBFiltrarPorPaciente;
        private System.Windows.Forms.CheckBox CBFiltrarFecha;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Label LBFiltrarPorPaciente;
        private System.Windows.Forms.Label LBFiltro;
        private System.Windows.Forms.Button btnActualizarDiagnostico;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.DataGridView DGVDiagnostico;
        private System.Windows.Forms.DateTimePicker DTFiltroFecha;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private System.Windows.Forms.Button btnAsignarTratamiento;
    }
}