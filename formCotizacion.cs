using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace VentaTortas
{
    public partial class formCotizacion : Form


    {
        private void formCotizacion_Load(object sender, EventArgs e)
        {
            // Agregar las columnas del DataGridView
            dgProductos.Columns.Add("Id", "Id");
            dgProductos.Columns.Add("Producto", "Producto");
            dgProductos.Columns.Add("Sabor", "Sabor");
            dgProductos.Columns.Add("Porciones", "No. de porciones");
            dgProductos.Columns.Add("Valor", "Valor unitario");
            dgProductos.Columns.Add("Cantidad", "Cantidad");


            // Agregar las filas de la tabla
            dgProductos.Rows.Add("1", "Torta1", "Naranja", "20", "$50,000", 1);
            dgProductos.Rows.Add("2", "Torta2", "Naranja", "10", "$30,000", 1);
            dgProductos.Rows.Add("3", "Torta3", "Chocolate", "10", "$35,000", 1);
            dgProductos.Rows.Add("4", "Torta4", "Chocolate", "20", "$70,000", 1);
            dgProductos.Rows.Add("5", "Torta5", "Red Velvet", "10", "$40,000", 1);
            dgProductos.Rows.Add("6", "Torta6", "Red Velvet", "20", "$80,000", 1);
        }

        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Sabor { get; set; }
            public string Porciones { get; set; }
            public decimal Valor { get; set; }
            public int Cantidad { get; set; }
        }
        // Declarar la lista de clientes
        List<Producto> listaProductosSeleccionados = new List<Producto>();

        public class Cliente
        {
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Ciudad { get; set; }
            public string Direccion { get; set; }
            public DateTime Hora_Fecha_Envio { get; set; }
            public string Precio_Total { get; set; }

        }

        // Declarar la lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();


        public formCotizacion(Button btnGuardar = null)
        {
            InitializeComponent();
            this.btnGuardar = btnGuardar;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje al usuario para preguntar qué producto desea agregar
            int id = 0;
            bool productoValido = false;
            while (!productoValido)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del producto que desea agregar:", "Agregar producto", "");
                if (string.IsNullOrWhiteSpace(input))
                {
                    // El usuario canceló la operación
                    return;
                }
                if (!int.TryParse(input, out id))
                {
                    // El usuario ingresó un valor no numérico
                    MessageBox.Show("Por favor ingrese un valor numérico para el ID del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Buscar el producto con el ID ingresado
                    DataGridViewRow row = dgProductos.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["Id"].Value.ToString() == id.ToString());
                    if ( row == null )
                    {
                        // No se encontró el producto con el ID ingresado
                        MessageBox.Show($"No se encontró ningún producto con el ID {id}. Por favor ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    else
                    {
                        // El producto con el ID ingresado fue encontrado
                        productoValido = true;
                    }
                }
            }

            // Obtener la cantidad seleccionada por el usuario
            DataGridViewRow productoRow = dgProductos.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["Id"].Value.ToString() == id.ToString());
            int cantidad = Convert.ToInt32(productoRow.Cells["Cantidad"].Value);

            // Si la cantidad es mayor a cero, agregar el producto a la lista de productos seleccionados
            if (cantidad > 0)
            {
                // Crear un objeto que represente el producto seleccionado
                Producto producto = new Producto();
                producto.Id = id;
                producto.Nombre = productoRow.Cells["Producto"].Value.ToString();
                producto.Sabor = productoRow.Cells["Sabor"].Value.ToString();
                producto.Porciones = productoRow.Cells["Porciones"].Value.ToString(); ;
                producto.Valor = Convert.ToDecimal(productoRow.Cells["Valor"].Value.ToString().Replace("$", "").Replace(",", ""));
                producto.Cantidad = cantidad;


                // Agregar el producto a la lista de productos seleccionados
                listaProductosSeleccionados.Add(producto);

                // Mostrar un mensaje al usuario confirmando que el producto fue agregado
                MessageBox.Show($"El producto {producto.Nombre} ({producto.Sabor}) con ID {producto.Id} y {producto.Porciones} porción(es) ha sido agregado.", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Mostrar la lista de productos seleccionados en el DataGridView
            dgSeleccionados.DataSource = null;
            dgSeleccionados.DataSource = listaProductosSeleccionados;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ciudad = cmbCiudad.SelectedItem.ToString();
            decimal costoEnvio = 0;

            if (ciudad == "Bogotá" || ciudad == "Medellín" || ciudad == "Cali" || ciudad == "Barranquilla" || ciudad == "Cartagena")
            {
                costoEnvio = 2000;
            }
            else if (ciudad == "Cúcuta" || ciudad == "Bucaramanga" || ciudad == "Pereira" || ciudad == "Santa Marta" || ciudad == "Manizales")
            {
                costoEnvio = 3000;
            }
            else if (ciudad == "Villavicencio" || ciudad == "Pasto" || ciudad == "Valledupar" || ciudad == "Montería" || ciudad == "Armenia")
            {
                costoEnvio = 4000;
            }
            else
            {
                costoEnvio = 5000;
            }

            // Calcular el precio total de los productos seleccionados
            decimal precioTotal = 0;
            foreach (Producto producto in listaProductosSeleccionados)
            {


                precioTotal += producto.Valor + costoEnvio;
            } 

            Cliente nuevoCliente = new Cliente();



            nuevoCliente.Nombres = txtNombre.Text;
            nuevoCliente.Apellidos = txtApellidos.Text;
            nuevoCliente.Telefono = txtTelefono.Text;
            nuevoCliente.Email = txtEmail.Text;
            nuevoCliente.Ciudad = cmbCiudad.SelectedItem.ToString();
            nuevoCliente.Direccion = txtDireccion.Text;
           
            nuevoCliente.Hora_Fecha_Envio = DateTime.ParseExact(mtHoraFecha.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            nuevoCliente.Precio_Total = "$ " + precioTotal.ToString("N0");



            // Mostrar el precio total en un MessageBox
            MessageBox.Show("Precio total: $" + precioTotal.ToString("N0"));

           
            listaClientes.Add(nuevoCliente);

            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbCiudad.SelectedIndex = -1;
            txtDireccion.Clear();
            mtHoraFecha.Clear();
            listaProductosSeleccionados.Clear();

            // Mostrar la lista de clientes en el DataGridView llamado dgPantalla
            dgPantalla.DataSource = null;
            dgPantalla.DataSource = listaClientes;

           
        }

       
    }
}
