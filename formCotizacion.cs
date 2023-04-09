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
        double precio = 0;

        private void formCotizacion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("D");
            lblPrecio.Text = (0).ToString("C");
        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            string producto = cboProducto.Text;

            if (producto.Equals("Torta de Naranja de 20 porciones")) precio = 50000;
            if (producto.Equals("Torta de Naranja de 10 porciones")) precio = 30000;
            if (producto.Equals("Torta de Chocolate de 10 porciones")) precio = 35000;
            if (producto.Equals("Torta de Chocolate de 20 porciones")) precio = 70000;
            if (producto.Equals("Torta de Red Velvet de 10 porciones")) precio = 40000;
            if (producto.Equals("Torta de Red Velvet de 20 porciones")) precio = 80000;

            lblPrecio.Text = precio.ToString("C");

        }


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



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Costos de envio 
            string ciudad = cmbCiudad.SelectedItem.ToString();
            double costoEnvio = 0;

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

            lblPrecioEnvio.Text=costoEnvio.ToString("C");

            //Validar

            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto ...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad ...!!!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar tipo ...!!!");
            else
            {
                //Capturar datos 
                /*
                public string Nombres 
                public string Apellidos 
                public string Telefono 
                public string Email 
                public string Ciudad 
                public string Direccion
                public DateTime Hora_Fecha_Envio 
                */

                string Nombre = txtNombre.Text;
                string Apellidos = txtApellidos.Text;
                string Telefono = txtTelefono.Text;
                string Email = txtEmail.Text;
                string Ciudad = cmbCiudad.Text;
                string Direccion = txtDireccion.Text;
                DateTime Hora_Fecha_Envio = DateTime.ParseExact(mtHoraFecha.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                string producto = cboProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;


                // Proceso de Cotización
                double subTotal = cantidad * precio;
                double descuento = 0, recargo = 0;
                if (tipo.Equals("Efectivo"))
                    descuento = 0.05 * subTotal;
                else
                    recargo =0.1 * subTotal;
                double precioTotal = subTotal - descuento + recargo + costoEnvio;


                //Mostrar resultados
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(Nombre.ToString());
                fila.SubItems.Add(Apellidos.ToString());
                fila.SubItems.Add(Telefono.ToString());
                fila.SubItems.Add(Email.ToString());
                fila.SubItems.Add(Ciudad.ToString());
                fila.SubItems.Add(Direccion.ToString());
                fila.SubItems.Add(Hora_Fecha_Envio.ToString());
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(costoEnvio.ToString());
                fila.SubItems.Add(precioTotal.ToString());

                lvVenta.Items.Add(fila);

                

            }


            MessageBox.Show("Su Pedido se ha registrado con exito ..!!");


           

            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbCiudad.SelectedIndex = -1;
            txtDireccion.Clear();
            mtHoraFecha.Clear();
            cboProducto.SelectedIndex= -1;
            cboTipo.SelectedIndex= -1;
            txtCantidad.Clear();



            // Mostrar la lista de clientes en el DataGridView llamado dgPantalla
            //dgPantalla.DataSource = null;
            //dgPantalla.DataSource = listaClientes;


        }


    }
}
