namespace Clinica
{
    partial class FrmPaciente
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
            this.lbnTitulo = new System.Windows.Forms.Label();
            this.btnCerrar1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnTitulo
            // 
            this.lbnTitulo.AutoSize = true;
            this.lbnTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbnTitulo.Location = new System.Drawing.Point(126, 28);
            this.lbnTitulo.Name = "lbnTitulo";
            this.lbnTitulo.Size = new System.Drawing.Size(166, 36);
            this.lbnTitulo.TabIndex = 8;
            this.lbnTitulo.Text = "DentixCare";
            // 
            // btnCerrar1
            // 
            this.btnCerrar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar1.Location = new System.Drawing.Point(325, 166);
            this.btnCerrar1.Name = "btnCerrar1";
            this.btnCerrar1.Size = new System.Drawing.Size(131, 36);
            this.btnCerrar1.TabIndex = 0;
            this.btnCerrar1.Text = "Cerrar";
            this.btnCerrar1.UseVisualStyleBackColor = false;
            this.btnCerrar1.Click += new System.EventHandler(this.btnCerrar1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCerrar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 225);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Mantenimiento";
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(672, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbnTitulo);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbnTitulo;
        private System.Windows.Forms.Button btnCerrar1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}