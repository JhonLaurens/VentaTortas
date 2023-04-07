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
            public DateTime Fecha { get; set; }
            public DateTime Hora { get; set; }
        }

        // Declarar la lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();


        public formCotizacion()
        {
            InitializeComponent();
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
            nuevoCliente.Fecha = dtFecha.Value;
            nuevoCliente.Hora = DateTime.ParseExact(mtHora.Text, "HH:mm", CultureInfo.InvariantCulture);
            // Obtener la hora a partir de la cadena del tiempo
            


            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbCiudad.SelectedIndex = -1;
            txtDireccion.Clear();
            dtFecha.Value = DateTime.Today;
            mtHora.Clear();

            // Mostrar la lista de clientes en el DataGridView llamado dgPantalla
            dgPantalla.DataSource = null;
            dgPantalla.DataSource = listaClientes;


        }



    }
}
