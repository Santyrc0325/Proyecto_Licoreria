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
    public partial class FormsUsuario : Form
    {
        public FormsUsuario()
        {
            InitializeComponent();
            User user = new User();
            user.mostrarUsuarios(dgvTablaUsers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.guardarUsuarios(txtCedulaUser, txtNombreUser, txtApellidoUser, txtCorreoUser, txtTelefonoUser);
            users.mostrarUsuarios(dgvTablaUsers);
        }

        private void FormsUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            User users = new User();
            users.guardarUsuarios(txtCedulaUser, txtNombreUser, txtApellidoUser, txtCorreoUser, txtTelefonoUser);
            users.mostrarUsuarios(dgvTablaUsers);
        }

        private void dgvTablaUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            User users = new User();
            users.seleccionarUsuario(dgvTablaUsers, txtidUser, txtCedulaUser, txtNombreUser, txtApellidoUser, txtCorreoUser, txtTelefonoUser);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            User users = new User();
            users.modificarUsuarios(txtidUser, txtCedulaUser, txtNombreUser, txtApellidoUser, txtCorreoUser, txtTelefonoUser);
            users.mostrarUsuarios(dgvTablaUsers);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            User users = new User();
            users.eliminarUsuarios(txtidUser);
            users.mostrarUsuarios(dgvTablaUsers);
        }
    }
}
