using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaTortas
{
    public partial class formInicioSesion : Form
    {
        public formInicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "12345678")
            {

                this.Hide();
                formCotizacion fC = new formCotizacion();
                fC.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   
}
