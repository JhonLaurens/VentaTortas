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
            this.lbnFechaEnvio = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lbnHoraEnvio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgPantalla = new System.Windows.Forms.DataGridView();
            this.mtHora = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPantalla)).BeginInit();
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
            this.lbnNombres.Location = new System.Drawing.Point(12, 18);
            this.lbnNombres.Name = "lbnNombres";
            this.lbnNombres.Size = new System.Drawing.Size(77, 20);
            this.lbnNombres.TabIndex = 7;
            this.lbnNombres.Text = "&Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(125, 56);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(142, 20);
            this.txtApellidos.TabIndex = 10;
            // 
            // lbnApellidos
            // 
            this.lbnApellidos.AutoSize = true;
            this.lbnApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnApellidos.Location = new System.Drawing.Point(12, 51);
            this.lbnApellidos.Name = "lbnApellidos";
            this.lbnApellidos.Size = new System.Drawing.Size(77, 20);
            this.lbnApellidos.TabIndex = 9;
            this.lbnApellidos.Text = "&Apellidos:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // lbnEmail
            // 
            this.lbnEmail.AutoSize = true;
            this.lbnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnEmail.Location = new System.Drawing.Point(12, 120);
            this.lbnEmail.Name = "lbnEmail";
            this.lbnEmail.Size = new System.Drawing.Size(52, 20);
            this.lbnEmail.TabIndex = 13;
            this.lbnEmail.Text = "&Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 94);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // lbnTelefono
            // 
            this.lbnTelefono.AutoSize = true;
            this.lbnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnTelefono.Location = new System.Drawing.Point(12, 87);
            this.lbnTelefono.Name = "lbnTelefono";
            this.lbnTelefono.Size = new System.Drawing.Size(75, 20);
            this.lbnTelefono.TabIndex = 11;
            this.lbnTelefono.Text = "&Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(125, 209);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // lbnDireccion
            // 
            this.lbnDireccion.AutoSize = true;
            this.lbnDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnDireccion.Location = new System.Drawing.Point(12, 206);
            this.lbnDireccion.Name = "lbnDireccion";
            this.lbnDireccion.Size = new System.Drawing.Size(79, 20);
            this.lbnDireccion.TabIndex = 15;
            this.lbnDireccion.Text = "&Dirección:";
            // 
            // lbnCiudad
            // 
            this.lbnCiudad.AutoSize = true;
            this.lbnCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnCiudad.Location = new System.Drawing.Point(12, 159);
            this.lbnCiudad.Name = "lbnCiudad";
            this.lbnCiudad.Size = new System.Drawing.Size(63, 20);
            this.lbnCiudad.TabIndex = 17;
            this.lbnCiudad.Text = "&Ciudad:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
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
            this.cmbCiudad.Location = new System.Drawing.Point(125, 170);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(142, 21);
            this.cmbCiudad.TabIndex = 18;
            // 
            // lbnFechaEnvio
            // 
            this.lbnFechaEnvio.AutoSize = true;
            this.lbnFechaEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnFechaEnvio.Location = new System.Drawing.Point(12, 252);
            this.lbnFechaEnvio.Name = "lbnFechaEnvio";
            this.lbnFechaEnvio.Size = new System.Drawing.Size(106, 20);
            this.lbnFechaEnvio.TabIndex = 19;
            this.lbnFechaEnvio.Text = "&Fecha_Envio:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(124, 251);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(142, 20);
            this.dtFecha.TabIndex = 20;
            // 
            // lbnHoraEnvio
            // 
            this.lbnHoraEnvio.AutoSize = true;
            this.lbnHoraEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnHoraEnvio.Location = new System.Drawing.Point(12, 291);
            this.lbnHoraEnvio.Name = "lbnHoraEnvio";
            this.lbnHoraEnvio.Size = new System.Drawing.Size(96, 20);
            this.lbnHoraEnvio.TabIndex = 21;
            this.lbnHoraEnvio.Text = "&Hora_Envio:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(57, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 43);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgPantalla
            // 
            this.dgPantalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPantalla.Location = new System.Drawing.Point(356, 39);
            this.dgPantalla.Name = "dgPantalla";
            this.dgPantalla.Size = new System.Drawing.Size(422, 231);
            this.dgPantalla.TabIndex = 24;
            // 
            // mtHora
            // 
            this.mtHora.Location = new System.Drawing.Point(118, 293);
            this.mtHora.Mask = "00:00";
            this.mtHora.Name = "mtHora";
            this.mtHora.Size = new System.Drawing.Size(148, 20);
            this.mtHora.TabIndex = 25;
            this.mtHora.ValidatingType = typeof(System.DateTime);
            // 
            // formCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir2;
            this.ClientSize = new System.Drawing.Size(816, 384);
            this.Controls.Add(this.mtHora);
            this.Controls.Add(this.dgPantalla);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbnHoraEnvio);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lbnFechaEnvio);
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
        private System.Windows.Forms.Label lbnFechaEnvio;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lbnHoraEnvio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgPantalla;
        private System.Windows.Forms.MaskedTextBox mtHora;
    }
}