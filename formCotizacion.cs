using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace VentaTortas
{
    public partial class formCotizacion : Form


    {


        public class Cliente
        {
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Ciudad { get; set; }
            public string Direccion { get; set; }
            public DateTime Hora_Fecha_Envio { get; set; }
        }

        // Declarar la lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();


        public formCotizacion(Button btnGuardar = null)
        {
            InitializeComponent();
            this.btnGuardar = btnGuardar;
        }

        private void formCotizacion_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente nuevoCliente = new Cliente();

            nuevoCliente.Nombres = txtNombre.Text;
            nuevoCliente.Apellidos = txtApellidos.Text;
            nuevoCliente.Telefono = txtTelefono.Text;
            nuevoCliente.Email = txtEmail.Text;
            nuevoCliente.Ciudad = cmbCiudad.SelectedItem.ToString();
            nuevoCliente.Direccion = txtDireccion.Text;
            nuevoCliente.Hora_Fecha_Envio = DateTime.ParseExact(mtHoraFecha.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            // Obtener la hora a partir de
            //
            // la cadena del tiempo

            listaClientes.Add(nuevoCliente);

            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbCiudad.SelectedIndex = -1;
            txtDireccion.Clear();
            mtHoraFecha.Clear();

            // Mostrar la lista de clientes en el DataGridView llamado dgPantalla
            dgPantalla.DataSource = null;
            dgPantalla.DataSource = listaClientes;


        }



    }
}
