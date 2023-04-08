namespace VentaTortas
{
    partial class formCotizacion
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
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.lbnNombres = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbnApellidos = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbnEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbnTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbnDireccion = new System.Windows.Forms.Label();
            this.lbnCiudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lbnHoraFechaEnvio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgPantalla = new System.Windows.Forms.DataGridView();
            this.mtHoraFecha = new System.Windows.Forms.MaskedTextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.dgSeleccionados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.White;
            this.btnSalir2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSalir2.Location = new System.Drawing.Point(778, 2);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(37, 32);
            this.btnSalir2.TabIndex = 6;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbnNombres
            // 
            this.lbnNombres.AutoSize = true;
            this.lbnNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnNombres.Location = new System.Drawing.Point(13, 58);
            this.lbnNombres.Name = "lbnNombres";
            this.lbnNombres.Size = new System.Drawing.Size(77, 20);
            this.lbnNombres.TabIndex = 7;
            this.lbnNombres.Text = "&Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(169, 87);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(142, 20);
            this.txtApellidos.TabIndex = 9;
            // 
            // lbnApellidos
            // 
            this.lbnApellidos.AutoSize = true;
            this.lbnApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnApellidos.Location = new System.Drawing.Point(13, 91);
            this.lbnApellidos.Name = "lbnApellidos";
            this.lbnApellidos.Size = new System.Drawing.Size(77, 20);
            this.lbnApellidos.TabIndex = 9;
            this.lbnApellidos.Text = "&Apellidos:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(169, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lbnEmail
            // 
            this.lbnEmail.AutoSize = true;
            this.lbnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnEmail.Location = new System.Drawing.Point(13, 160);
            this.lbnEmail.Name = "lbnEmail";
            this.lbnEmail.Size = new System.Drawing.Size(52, 20);
            this.lbnEmail.TabIndex = 13;
            this.lbnEmail.Text = "&Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(169, 125);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // lbnTelefono
            // 
            this.lbnTelefono.AutoSize = true;
            this.lbnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTelefono.Location = new System.Drawing.Point(13, 127);
            this.lbnTelefono.Name = "lbnTelefono";
            this.lbnTelefono.Size = new System.Drawing.Size(75, 20);
            this.lbnTelefono.TabIndex = 11;
            this.lbnTelefono.Text = "&Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(169, 240);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // lbnDireccion
            // 
            this.lbnDireccion.AutoSize = true;
            this.lbnDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnDireccion.Location = new System.Drawing.Point(13, 246);
            this.lbnDireccion.Name = "lbnDireccion";
            this.lbnDireccion.Size = new System.Drawing.Size(79, 20);
            this.lbnDireccion.TabIndex = 15;
            this.lbnDireccion.Text = "&Dirección:";
            // 
            // lbnCiudad
            // 
            this.lbnCiudad.AutoSize = true;
            this.lbnCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnCiudad.Location = new System.Drawing.Point(13, 199);
            this.lbnCiudad.Name = "lbnCiudad";
            this.lbnCiudad.Size = new System.Drawing.Size(63, 20);
            this.lbnCiudad.TabIndex = 17;
            this.lbnCiudad.Text = "&Ciudad:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.ItemHeight = 13;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Cali",
            "Barranquilla",
            "Cartagena",
            "Cúcuta",
            "Bucaramanga",
            "Pereira",
            "Santa Marta",
            "Manizales",
            "Villavicencio",
            "Pasto",
            "Valledupar",
            "Montería",
            "Armenia",
            "Ibagué",
            "Neiva",
            "Popayán",
            "Sincelejo",
            "Tunja",
            "Riohacha",
            "Florencia",
            "Quibdó",
            "Mocoa"});
            this.cmbCiudad.Location = new System.Drawing.Point(169, 201);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(142, 21);
            this.cmbCiudad.TabIndex = 18;
            // 
            // lbnHoraFechaEnvio
            // 
            this.lbnHoraFechaEnvio.AutoSize = true;
            this.lbnHoraFechaEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnHoraFechaEnvio.Location = new System.Drawing.Point(12, 291);
            this.lbnHoraFechaEnvio.Name = "lbnHoraFechaEnvio";
            this.lbnHoraFechaEnvio.Size = new System.Drawing.Size(150, 20);
            this.lbnHoraFechaEnvio.TabIndex = 21;
            this.lbnHoraFechaEnvio.Text = "&Hora_Fecha_Envio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(57, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 43);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgPantalla
            // 
            this.dgPantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPantalla.Location = new System.Drawing.Point(333, 40);
            this.dgPantalla.Name = "dgPantalla";
            this.dgPantalla.ShowCellErrors = false;
            this.dgPantalla.ShowRowErrors = false;
            this.dgPantalla.Size = new System.Drawing.Size(446, 105);
            this.dgPantalla.TabIndex = 24;
            // 
            // mtHoraFecha
            // 
            this.mtHoraFecha.Location = new System.Drawing.Point(168, 291);
            this.mtHoraFecha.Mask = "00/00/0000 00:00";
            this.mtHoraFecha.Name = "mtHoraFecha";
            this.mtHoraFecha.Size = new System.Drawing.Size(148, 20);
            this.mtHoraFecha.TabIndex = 14;
            this.mtHoraFecha.ValidatingType = typeof(System.DateTime);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(333, 160);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ShowCellErrors = false;
            this.dgProductos.ShowRowErrors = false;
            this.dgProductos.Size = new System.Drawing.Size(446, 183);
            this.dgProductos.TabIndex = 25;
            // 
            // dgSeleccionados
            // 
            this.dgSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeleccionados.Location = new System.Drawing.Point(333, 400);
            this.dgSeleccionados.Name = "dgSeleccionados";
            this.dgSeleccionados.ShowCellErrors = false;
            this.dgSeleccionados.ShowRowErrors = false;
            this.dgSeleccionados.Size = new System.Drawing.Size(450, 158);
            this.dgSeleccionados.TabIndex = 26;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(333, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // formCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir2;
            this.ClientSize = new System.Drawing.Size(821, 598);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgSeleccionados);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.mtHoraFecha);
            this.Controls.Add(this.dgPantalla);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbnHoraFechaEnvio);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lbnCiudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbnDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbnEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbnTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lbnApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbnNombres);
            this.Controls.Add(this.btnSalir2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.formCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Label lbnNombres;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbnApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbnEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbnTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbnDireccion;
        private System.Windows.Forms.Label lbnCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lbnHoraFechaEnvio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgPantalla;
        private System.Windows.Forms.MaskedTextBox mtHoraFecha;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridView dgSeleccionados;
        private System.Windows.Forms.Button btnAgregar;
    }
}