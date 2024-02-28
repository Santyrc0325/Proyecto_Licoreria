using licores.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licores
{
    public partial class FormsCliente : Form
    {
        public FormsCliente()
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            cliente.mostrarClientes(dgvTablaCliente);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarClient_Click(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.guardarClientes(txtCedulaClient, txtNombreClient, txtApellidoClient, txtCorreoClient, txtTelefonoClient);
            client.mostrarClientes(dgvTablaCliente);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
