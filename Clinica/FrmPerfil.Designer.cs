namespace Clinica
{
    partial class FrmPerfil
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
            this.IconPerson = new System.Windows.Forms.PictureBox();
            this.LBPerfil = new System.Windows.Forms.Label();
            this.LBNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LBApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.LBTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.LBCedula = new System.Windows.Forms.Label();
            this.LBFecha = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.LBEdad = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.LBCategoria = new System.Windows.Forms.Label();
            this.LBID = new System.Windows.Forms.Label();
            this.txtIDConsultorio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBPerfil = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconPerson
            // 
            this.IconPerson.BackColor = System.Drawing.Color.Transparent;
            this.IconPerson.Image = global::Clinica.Properties.Resources.IconPerson;
            this.IconPerson.Location = new System.Drawing.Point(13, 71);
            this.IconPerson.Name = "IconPerson";
            this.IconPerson.Size = new System.Drawing.Size(251, 329);
            this.IconPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPerson.TabIndex = 0;
            this.IconPerson.TabStop = false;
            // 
            // LBPerfil
            // 
            this.LBPerfil.AutoSize = true;
            this.LBPerfil.BackColor = System.Drawing.Color.Transparent;
            this.LBPerfil.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPerfil.Location = new System.Drawing.Point(6, 16);
            this.LBPerfil.Name = "LBPerfil";
            this.LBPerfil.Size = new System.Drawing.Size(258, 39);
            this.LBPerfil.TabIndex = 5;
            this.LBPerfil.Text = "Perfil de usuario";
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBNombre.Location = new System.Drawing.Point(291, 71);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(72, 19);
            this.LBNombre.TabIndex = 6;
            this.LBNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(295, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.Text = "NOMBRE";
            // 
            // LBApellido
            // 
            this.LBApellido.AutoSize = true;
            this.LBApellido.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBApellido.Location = new System.Drawing.Point(530, 71);
            this.LBApellido.Name = "LBApellido";
            this.LBApellido.Size = new System.Drawing.Size(71, 19);
            this.LBApellido.TabIndex = 20;
            this.LBApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(534, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(198, 20);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.Text = "APELLIDO";
            // 
            // LBTelefono
            // 
            this.LBTelefono.AutoSize = true;
            this.LBTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTelefono.Location = new System.Drawing.Point(291, 176);
            this.LBTelefono.Name = "LBTelefono";
            this.LBTelefono.Size = new System.Drawing.Size(76, 19);
            this.LBTelefono.TabIndex = 22;
            this.LBTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(295, 198);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 20);
            this.txtTelefono.TabIndex = 31;
            this.txtTelefono.Text = "TELEFONO";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.DimGray;
            this.txtCedula.Location = new System.Drawing.Point(534, 198);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(173, 20);
            this.txtCedula.TabIndex = 32;
            this.txtCedula.Text = "CEDULA";
            // 
            // LBCedula
            // 
            this.LBCedula.AutoSize = true;
            this.LBCedula.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCedula.Location = new System.Drawing.Point(530, 176);
            this.LBCedula.Name = "LBCedula";
            this.LBCedula.Size = new System.Drawing.Size(61, 19);
            this.LBCedula.TabIndex = 33;
            this.LBCedula.Text = "Cedula";
            // 
            // LBFecha
            // 
            this.LBFecha.AutoSize = true;
            this.LBFecha.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFecha.Location = new System.Drawing.Point(530, 272);
            this.LBFecha.Name = "LBFecha";
            this.LBFecha.Size = new System.Drawing.Size(165, 19);
            this.LBFecha.TabIndex = 34;
            this.LBFecha.Text = "Fecha de nacimiento";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(534, 294);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(199, 20);
            this.txtFechaNacimiento.TabIndex = 35;
            this.txtFechaNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.Location = new System.Drawing.Point(295, 294);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(199, 20);
            this.txtEdad.TabIndex = 37;
            this.txtEdad.Text = "EDAD";
            // 
            // LBEdad
            // 
            this.LBEdad.AutoSize = true;
            this.LBEdad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEdad.Location = new System.Drawing.Point(291, 272);
            this.LBEdad.Name = "LBEdad";
            this.LBEdad.Size = new System.Drawing.Size(47, 19);
            this.LBEdad.TabIndex = 36;
            this.LBEdad.Text = "Edad";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategoria.Location = new System.Drawing.Point(295, 380);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(198, 20);
            this.txtCategoria.TabIndex = 39;
            this.txtCategoria.Text = "CATEGORIA";
            // 
            // LBCategoria
            // 
            this.LBCategoria.AutoSize = true;
            this.LBCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCategoria.Location = new System.Drawing.Point(291, 358);
            this.LBCategoria.Name = "LBCategoria";
            this.LBCategoria.Size = new System.Drawing.Size(82, 19);
            this.LBCategoria.TabIndex = 38;
            this.LBCategoria.Text = "Categoria";
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBID.Location = new System.Drawing.Point(530, 358);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(138, 19);
            this.LBID.TabIndex = 40;
            this.LBID.Text = "ID de consultorio";
            // 
            // txtIDConsultorio
            // 
            this.txtIDConsultorio.BackColor = System.Drawing.Color.White;
            this.txtIDConsultorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDConsultorio.Enabled = false;
            this.txtIDConsultorio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDConsultorio.ForeColor = System.Drawing.Color.DimGray;
            this.txtIDConsultorio.Location = new System.Drawing.Point(534, 380);
            this.txtIDConsultorio.Name = "txtIDConsultorio";
            this.txtIDConsultorio.Size = new System.Drawing.Size(198, 20);
            this.txtIDConsultorio.TabIndex = 41;
            this.txtIDConsultorio.Text = "ID DE CONSULTORIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Clinica.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // GBPerfil
            // 
            this.GBPerfil.BackColor = System.Drawing.Color.Transparent;
            this.GBPerfil.Controls.Add(this.txtIDConsultorio);
            this.GBPerfil.Controls.Add(this.txtFechaNacimiento);
            this.GBPerfil.Controls.Add(this.LBID);
            this.GBPerfil.Controls.Add(this.LBApellido);
            this.GBPerfil.Controls.Add(this.txtApellido);
            this.GBPerfil.Controls.Add(this.txtCategoria);
            this.GBPerfil.Controls.Add(this.LBEdad);
            this.GBPerfil.Controls.Add(this.LBFecha);
            this.GBPerfil.Controls.Add(this.txtCedula);
            this.GBPerfil.Controls.Add(this.txtNombre);
            this.GBPerfil.Controls.Add(this.LBCategoria);
            this.GBPerfil.Controls.Add(this.LBTelefono);
            this.GBPerfil.Controls.Add(this.txtTelefono);
            this.GBPerfil.Controls.Add(this.txtEdad);
            this.GBPerfil.Controls.Add(this.LBNombre);
            this.GBPerfil.Controls.Add(this.LBCedula);
            this.GBPerfil.Controls.Add(this.IconPerson);
            this.GBPerfil.Controls.Add(this.LBPerfil);
            this.GBPerfil.Location = new System.Drawing.Point(12, 130);
            this.GBPerfil.Name = "GBPerfil";
            this.GBPerfil.Size = new System.Drawing.Size(753, 423);
            this.GBPerfil.TabIndex = 42;
            this.GBPerfil.TabStop = false;
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(777, 699);
            this.Controls.Add(this.GBPerfil);
            this.Controls.Add(this.pictureBox1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPerfil";
            this.Text = "FrmPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.IconPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBPerfil.ResumeLayout(false);
            this.GBPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPerson;
        private System.Windows.Forms.Label LBPerfil;
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LBApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label LBTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label LBCedula;
        private System.Windows.Forms.Label LBFecha;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label LBEdad;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label LBCategoria;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.TextBox txtIDConsultorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBPerfil;
    }
}