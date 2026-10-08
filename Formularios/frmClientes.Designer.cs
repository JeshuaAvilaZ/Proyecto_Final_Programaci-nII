namespace Proyecto_Final_ProgramaciónII
{
    partial class frmClientes
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
            this.lblMantenimientoClientes = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoClientes = new System.Windows.Forms.TextBox();
            this.lblNombreRazon = new System.Windows.Forms.Label();
            this.txtNombreRazónClientes = new System.Windows.Forms.TextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rdbActivoCliente = new System.Windows.Forms.RadioButton();
            this.rdbInactivoCliente = new System.Windows.Forms.RadioButton();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.dgbMantenimientoCliente = new System.Windows.Forms.DataGridView();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMantenimientoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMantenimientoClientes
            // 
            this.lblMantenimientoClientes.AutoSize = true;
            this.lblMantenimientoClientes.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimientoClientes.Location = new System.Drawing.Point(27, 72);
            this.lblMantenimientoClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimientoClientes.Name = "lblMantenimientoClientes";
            this.lblMantenimientoClientes.Size = new System.Drawing.Size(266, 33);
            this.lblMantenimientoClientes.TabIndex = 0;
            this.lblMantenimientoClientes.Text = "Mantenimiento Clientes";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 136);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigoClientes
            // 
            this.txtCodigoClientes.Location = new System.Drawing.Point(73, 136);
            this.txtCodigoClientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoClientes.Name = "txtCodigoClientes";
            this.txtCodigoClientes.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoClientes.TabIndex = 9;
            this.txtCodigoClientes.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblNombreRazon
            // 
            this.lblNombreRazon.AutoSize = true;
            this.lblNombreRazon.Location = new System.Drawing.Point(30, 177);
            this.lblNombreRazon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreRazon.Name = "lblNombreRazon";
            this.lblNombreRazon.Size = new System.Drawing.Size(80, 13);
            this.lblNombreRazon.TabIndex = 10;
            this.lblNombreRazon.Text = "Nombre/Razón";
            // 
            // txtNombreRazónClientes
            // 
            this.txtNombreRazónClientes.Location = new System.Drawing.Point(109, 175);
            this.txtNombreRazónClientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreRazónClientes.Name = "txtNombreRazónClientes";
            this.txtNombreRazónClientes.Size = new System.Drawing.Size(147, 20);
            this.txtNombreRazónClientes.TabIndex = 11;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(30, 207);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(68, 13);
            this.lblTipoCliente.TabIndex = 12;
            this.lblTipoCliente.Text = "Tipo Clientes";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(99, 205);
            this.cmbTipoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(91, 21);
            this.cmbTipoCliente.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 241);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // rdbActivoCliente
            // 
            this.rdbActivoCliente.AutoSize = true;
            this.rdbActivoCliente.Location = new System.Drawing.Point(73, 240);
            this.rdbActivoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActivoCliente.Name = "rdbActivoCliente";
            this.rdbActivoCliente.Size = new System.Drawing.Size(55, 17);
            this.rdbActivoCliente.TabIndex = 15;
            this.rdbActivoCliente.TabStop = true;
            this.rdbActivoCliente.Text = "Activo";
            this.rdbActivoCliente.UseVisualStyleBackColor = true;
            // 
            // rdbInactivoCliente
            // 
            this.rdbInactivoCliente.AutoSize = true;
            this.rdbInactivoCliente.Location = new System.Drawing.Point(126, 238);
            this.rdbInactivoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInactivoCliente.Name = "rdbInactivoCliente";
            this.rdbInactivoCliente.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivoCliente.TabIndex = 16;
            this.rdbInactivoCliente.TabStop = true;
            this.rdbInactivoCliente.Text = "Inactivo";
            this.rdbInactivoCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(34, 277);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 24);
            this.btnAgregarCliente.TabIndex = 17;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(126, 277);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(75, 24);
            this.btnModificarCliente.TabIndex = 18;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(218, 277);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 24);
            this.btnEliminarCliente.TabIndex = 19;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(310, 277);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(75, 24);
            this.btnLimpiarCliente.TabIndex = 20;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            // 
            // dgbMantenimientoCliente
            // 
            this.dgbMantenimientoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMantenimientoCliente.Location = new System.Drawing.Point(6, 318);
            this.dgbMantenimientoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgbMantenimientoCliente.Name = "dgbMantenimientoCliente";
            this.dgbMantenimientoCliente.RowHeadersWidth = 51;
            this.dgbMantenimientoCliente.RowTemplate.Height = 24;
            this.dgbMantenimientoCliente.Size = new System.Drawing.Size(587, 128);
            this.dgbMantenimientoCliente.TabIndex = 21;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(32, 45);
            this.lblTitulo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(81, 26);
            this.lblTitulo1.TabIndex = 22;
            this.lblTitulo1.Text = "Eventia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_ProgramaciónII.Properties.Resources.ChatGPT_Image_4_oct_2026__01_39_20_p_m_;
            this.pictureBox1.Location = new System.Drawing.Point(434, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.dgbMantenimientoCliente);
            this.Controls.Add(this.btnLimpiarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.rdbInactivoCliente);
            this.Controls.Add(this.rdbActivoCliente);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.txtNombreRazónClientes);
            this.Controls.Add(this.lblNombreRazon);
            this.Controls.Add(this.txtCodigoClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblMantenimientoClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClientes";
            this.Text = "Gestion Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMantenimientoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMantenimientoClientes;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCodigoClientes;
        private System.Windows.Forms.Label lblNombreRazon;
        private System.Windows.Forms.TextBox txtNombreRazónClientes;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rdbActivoCliente;
        private System.Windows.Forms.RadioButton rdbInactivoCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.DataGridView dgbMantenimientoCliente;
        private System.Windows.Forms.Label lblTitulo1;
    }
}