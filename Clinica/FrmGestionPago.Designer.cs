namespace GUI
{
    partial class FrmGestionPago
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
            this.LBTitulo = new System.Windows.Forms.Label();
            this.DGVPagos = new System.Windows.Forms.DataGridView();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.IconDudas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconDudas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::GUI.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(745, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 117;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.ForeColor = System.Drawing.Color.Black;
            this.LBTitulo.Location = new System.Drawing.Point(12, 23);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(476, 39);
            this.LBTitulo.TabIndex = 115;
            this.LBTitulo.Text = "Registro de pagos relacionados";
            // 
            // DGVPagos
            // 
            this.DGVPagos.AllowUserToAddRows = false;
            this.DGVPagos.AllowUserToDeleteRows = false;
            this.DGVPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVPagos.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DGVPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPagos.ColumnHeadersHeight = 30;
            this.DGVPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVPagos.EnableHeadersVisualStyles = false;
            this.DGVPagos.Location = new System.Drawing.Point(19, 78);
            this.DGVPagos.Name = "DGVPagos";
            this.DGVPagos.ReadOnly = true;
            this.DGVPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGVPagos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPagos.Size = new System.Drawing.Size(709, 535);
            this.DGVPagos.TabIndex = 116;
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerInfo.FlatAppearance.BorderSize = 0;
            this.btnVerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerInfo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.ForeColor = System.Drawing.Color.Black;
            this.btnVerInfo.Location = new System.Drawing.Point(290, 637);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(198, 50);
            this.btnVerInfo.TabIndex = 118;
            this.btnVerInfo.Text = "Ver más información";
            this.btnVerInfo.UseVisualStyleBackColor = false;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // IconDudas
            // 
            this.IconDudas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconDudas.Image = global::GUI.Properties.Resources.IconQuestion;
            this.IconDudas.Location = new System.Drawing.Point(719, 15);
            this.IconDudas.Name = "IconDudas";
            this.IconDudas.Size = new System.Drawing.Size(20, 20);
            this.IconDudas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconDudas.TabIndex = 119;
            this.IconDudas.TabStop = false;
            this.IconDudas.Click += new System.EventHandler(this.IconDudas_Click);
            // 
            // FrmGestionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.IconDudas);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.DGVPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionPago";
            this.Load += new System.EventHandler(this.FrmGestionPago_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmGestionPago_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconDudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.DataGridView DGVPagos;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.PictureBox IconDudas;
    }
}