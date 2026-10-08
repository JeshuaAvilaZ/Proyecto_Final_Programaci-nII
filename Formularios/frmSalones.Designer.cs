namespace Proyecto_Final_ProgramaciónII
{
    partial class frmSalones
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
            this.dgvMantenimientoSalones = new System.Windows.Forms.DataGridView();
            this.btnLimpiarSalones = new System.Windows.Forms.Button();
            this.btnEliminarSalones = new System.Windows.Forms.Button();
            this.btnModificarSalones = new System.Windows.Forms.Button();
            this.btnAgregarSalones = new System.Windows.Forms.Button();
            this.rdOcupadoSalones = new System.Windows.Forms.RadioButton();
            this.rdbDisponibleSalones = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.txtNombreSalones = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigoSalones = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMantenimientosSalones = new System.Windows.Forms.Label();
            this.txtUbicacionSalones = new System.Windows.Forms.TextBox();
            this.lblUbicación = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCapacidadSalones = new System.Windows.Forms.TextBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientoSalones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMantenimientoSalones
            // 
            this.dgvMantenimientoSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimientoSalones.Location = new System.Drawing.Point(9, 297);
            this.dgvMantenimientoSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMantenimientoSalones.Name = "dgvMantenimientoSalones";
            this.dgvMantenimientoSalones.RowHeadersWidth = 51;
            this.dgvMantenimientoSalones.RowTemplate.Height = 24;
            this.dgvMantenimientoSalones.Size = new System.Drawing.Size(587, 128);
            this.dgvMantenimientoSalones.TabIndex = 38;
            // 
            // btnLimpiarSalones
            // 
            this.btnLimpiarSalones.Location = new System.Drawing.Point(314, 256);
            this.btnLimpiarSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarSalones.Name = "btnLimpiarSalones";
            this.btnLimpiarSalones.Size = new System.Drawing.Size(75, 24);
            this.btnLimpiarSalones.TabIndex = 37;
            this.btnLimpiarSalones.Text = "Limpiar";
            this.btnLimpiarSalones.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSalones
            // 
            this.btnEliminarSalones.Location = new System.Drawing.Point(223, 256);
            this.btnEliminarSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarSalones.Name = "btnEliminarSalones";
            this.btnEliminarSalones.Size = new System.Drawing.Size(75, 24);
            this.btnEliminarSalones.TabIndex = 36;
            this.btnEliminarSalones.Text = "Eliminar";
            this.btnEliminarSalones.UseVisualStyleBackColor = true;
            // 
            // btnModificarSalones
            // 
            this.btnModificarSalones.Location = new System.Drawing.Point(130, 256);
            this.btnModificarSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarSalones.Name = "btnModificarSalones";
            this.btnModificarSalones.Size = new System.Drawing.Size(75, 24);
            this.btnModificarSalones.TabIndex = 35;
            this.btnModificarSalones.Text = "Modificar";
            this.btnModificarSalones.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSalones
            // 
            this.btnAgregarSalones.Location = new System.Drawing.Point(37, 256);
            this.btnAgregarSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarSalones.Name = "btnAgregarSalones";
            this.btnAgregarSalones.Size = new System.Drawing.Size(75, 24);
            this.btnAgregarSalones.TabIndex = 34;
            this.btnAgregarSalones.Text = "Agregar";
            this.btnAgregarSalones.UseVisualStyleBackColor = true;
            // 
            // rdOcupadoSalones
            // 
            this.rdOcupadoSalones.AutoSize = true;
            this.rdOcupadoSalones.Location = new System.Drawing.Point(152, 220);
            this.rdOcupadoSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdOcupadoSalones.Name = "rdOcupadoSalones";
            this.rdOcupadoSalones.Size = new System.Drawing.Size(69, 17);
            this.rdOcupadoSalones.TabIndex = 33;
            this.rdOcupadoSalones.TabStop = true;
            this.rdOcupadoSalones.Text = "Ocupado";
            this.rdOcupadoSalones.UseVisualStyleBackColor = true;
            this.rdOcupadoSalones.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // rdbDisponibleSalones
            // 
            this.rdbDisponibleSalones.AutoSize = true;
            this.rdbDisponibleSalones.Location = new System.Drawing.Point(77, 219);
            this.rdbDisponibleSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDisponibleSalones.Name = "rdbDisponibleSalones";
            this.rdbDisponibleSalones.Size = new System.Drawing.Size(74, 17);
            this.rdbDisponibleSalones.TabIndex = 32;
            this.rdbDisponibleSalones.TabStop = true;
            this.rdbDisponibleSalones.Text = "Disponible";
            this.rdbDisponibleSalones.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(34, 220);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(34, 186);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 29;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // txtNombreSalones
            // 
            this.txtNombreSalones.Location = new System.Drawing.Point(90, 141);
            this.txtNombreSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreSalones.Name = "txtNombreSalones";
            this.txtNombreSalones.Size = new System.Drawing.Size(147, 20);
            this.txtNombreSalones.TabIndex = 28;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 143);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigoSalones
            // 
            this.txtCodigoSalones.Location = new System.Drawing.Point(77, 115);
            this.txtCodigoSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoSalones.Name = "txtCodigoSalones";
            this.txtCodigoSalones.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoSalones.TabIndex = 26;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(34, 115);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblMantenimientosSalones
            // 
            this.lblMantenimientosSalones.AutoSize = true;
            this.lblMantenimientosSalones.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimientosSalones.Location = new System.Drawing.Point(36, 51);
            this.lblMantenimientosSalones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimientosSalones.Name = "lblMantenimientosSalones";
            this.lblMantenimientosSalones.Size = new System.Drawing.Size(290, 33);
            this.lblMantenimientosSalones.TabIndex = 23;
            this.lblMantenimientosSalones.Text = "Mantenimiento de Salones";
            // 
            // txtUbicacionSalones
            // 
            this.txtUbicacionSalones.Location = new System.Drawing.Point(90, 163);
            this.txtUbicacionSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUbicacionSalones.Name = "txtUbicacionSalones";
            this.txtUbicacionSalones.Size = new System.Drawing.Size(147, 20);
            this.txtUbicacionSalones.TabIndex = 41;
            // 
            // lblUbicación
            // 
            this.lblUbicación.AutoSize = true;
            this.lblUbicación.Location = new System.Drawing.Point(34, 166);
            this.lblUbicación.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUbicación.Name = "lblUbicación";
            this.lblUbicación.Size = new System.Drawing.Size(55, 13);
            this.lblUbicación.TabIndex = 40;
            this.lblUbicación.Text = "Ubicación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_ProgramaciónII.Properties.Resources.ChatGPT_Image_4_oct_2026__01_39_20_p_m_;
            this.pictureBox1.Location = new System.Drawing.Point(438, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txtCapacidadSalones
            // 
            this.txtCapacidadSalones.Location = new System.Drawing.Point(94, 186);
            this.txtCapacidadSalones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCapacidadSalones.Name = "txtCapacidadSalones";
            this.txtCapacidadSalones.Size = new System.Drawing.Size(143, 20);
            this.txtCapacidadSalones.TabIndex = 42;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(37, 24);
            this.lblTitulo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(81, 26);
            this.lblTitulo1.TabIndex = 43;
            this.lblTitulo1.Text = "Eventia";
            // 
            // frmSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 431);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.txtCapacidadSalones);
            this.Controls.Add(this.txtUbicacionSalones);
            this.Controls.Add(this.lblUbicación);
            this.Controls.Add(this.dgvMantenimientoSalones);
            this.Controls.Add(this.btnLimpiarSalones);
            this.Controls.Add(this.btnEliminarSalones);
            this.Controls.Add(this.btnModificarSalones);
            this.Controls.Add(this.btnAgregarSalones);
            this.Controls.Add(this.rdOcupadoSalones);
            this.Controls.Add(this.rdbDisponibleSalones);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.txtNombreSalones);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigoSalones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblMantenimientosSalones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSalones";
            this.Text = "frmSalones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientoSalones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMantenimientoSalones;
        private System.Windows.Forms.Button btnLimpiarSalones;
        private System.Windows.Forms.Button btnEliminarSalones;
        private System.Windows.Forms.Button btnModificarSalones;
        private System.Windows.Forms.Button btnAgregarSalones;
        private System.Windows.Forms.RadioButton rdOcupadoSalones;
        private System.Windows.Forms.RadioButton rdbDisponibleSalones;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox txtNombreSalones;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigoSalones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMantenimientosSalones;
        private System.Windows.Forms.TextBox txtUbicacionSalones;
        private System.Windows.Forms.Label lblUbicación;
        private System.Windows.Forms.TextBox txtCapacidadSalones;
        private System.Windows.Forms.Label lblTitulo1;
    }
}