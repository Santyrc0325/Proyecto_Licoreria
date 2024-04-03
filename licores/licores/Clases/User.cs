using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licores.Clases
{
    internal class User
    {
        public bool Login(TextBox user, TextBox pass)
        {
            Conexion conexion = new Conexion();

            string query = "select * from users where cedula_User ='" + user.Text + "' and contraseña ='" + pass.Text + "';";
            MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
            MySqlDataReader reader = myComand.ExecuteReader();

            if (reader.HasRows)
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }

        }


        public void mostrarUsuarios(DataGridView tablaUsuarios)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "select * from Users";
                tablaUsuarios.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.Open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuarios.DataSource = dt;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }

        public void mostrarUsuarios(DataGridView tablaUsuarios, TextBox txtBuscarUsuario)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "select * from Users WHERE cedula_User='"+txtBuscarUsuario.Text+"';";
                tablaUsuarios.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.Open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuarios.DataSource = dt;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }

        public void guardarUsuarios(TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {


            try
            {
                Conexion conexion = new Conexion();

                string query = "insert into users (cedula_User, nombre_User, apellido_User, correo_User, telefono_User, status_User)" + "values ('" + cedula.Text + "', '" + nombre.Text + "', '" + apellidos.Text + "', '" + correo.Text + "', '" + telefono.Text + "', '1');";


                MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardo al usuario Exitosamente.");
                while (reader.Read())
                {

                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se guardo: " + ex.ToString());
            }


        }

        public void seleccionarUsuario(DataGridView tablaUsuarios,TextBox idUser, TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {
            try
            {
                idUser.Text = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                cedula.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                cedula.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                nombre.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                apellidos.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                correo.Text = tablaUsuarios.CurrentRow.Cells[4].Value.ToString();
                telefono.Text = tablaUsuarios.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar los campos registrados, error: " + ex.ToString());
            }
        }

        public void modificarUsuarios(TextBox idUser, TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {
            int numidUser = Convert.ToInt32(idUser.Text);

            try
            {
                Conexion conexion = new Conexion();

                string query = "update users set cedula_User = '" + cedula.Text + "', nombre_User= '" + nombre.Text + "', apellido_User= '" + apellidos.Text + "', correo_User= '" + correo.Text + "', telefono_User= '" + telefono.Text + "' where id_User = '" + numidUser + "';";


                MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se Actualizo la informacion del usuario Exitosamente.");
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No funciona Actualizar Usuarios." + ex.ToString());
            }


        }

        public void eliminarUsuarios(TextBox idUser)
        {
            int numidUser = Convert.ToInt32(idUser.Text);

            try
            {
                Conexion conexion = new Conexion();

                string query = "DELETE FROM users WHERE id_User='" + numidUser + "';";

                MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se Elimino al usuario Exitosamente.");
                while (reader.Read())
                {

                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se Elimino: " + ex.ToString());
            }


        }
    }
}
