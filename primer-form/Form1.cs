using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_form
{
    public partial class frDatosPersonales : Form
    {
        public frDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtNombre.Text == "" || txtEdad.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Faltan datos para completar");
                txtApellido.BackColor = Color.IndianRed;
                txtNombre.BackColor = Color.IndianRed;
                txtEdad.BackColor = Color.IndianRed;
                txtDireccion.BackColor = Color.IndianRed;
            }
            else
            {
                listView.Items.Add("Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text);
                listView.Items.Add("Edad: " + txtEdad.Text);
                listView.Items.Add("Direccion: " + txtDireccion.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
