using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licores.Clases
{
    internal class Cliente
    {
        public void mostrarClientes(DataGridView tablaCliente)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "select id_Cliente, cedula_Cliente, nombre_Cliente, apellido_Cliente, correo_Cliente, telefono_Cliente from clientes where status_Cliente = 1";
                tablaCliente.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.Open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCliente.DataSource = dt;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }

        public void mostrarClientes(DataGridView tablaCliente, TextBox cedula)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "select id_Cliente, cedula_Cliente, nombre_Cliente, apellido_Cliente, correo_Cliente, telefono_Cliente from clientes where cedula_Cliente= '"+cedula.Text+"' and status_Cliente = 1";
                tablaCliente.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.Open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCliente.DataSource = dt;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }

        public void guardarClientes(TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "insert into clientes (cedula_Cliente, nombre_Cliente, apellido_Cliente, correo_Cliente, telefono_Cliente, status_Cliente)" +
                    " values('" + cedula.Text + "','" + nombre.Text + "','" + apellidos.Text + "','" + correo.Text + "','" + telefono.Text + "', '1');";

                MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardo al cliente Exitosamente.");
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona guardar clientes." + ex.ToString());
            }
        }

        public void seleccionarCliente(DataGridView tablaCliente, TextBox id, TextBox cedula, TextBox nombre, TextBox apellido, TextBox correo, TextBox telefono)
        {
            id.Text = tablaCliente.CurrentRow.Cells[0].Value.ToString();
            cedula.Text = tablaCliente.CurrentRow.Cells[1].Value.ToString();
            nombre.Text = tablaCliente.CurrentRow.Cells[2].Value.ToString();
            apellido.Text = tablaCliente.CurrentRow.Cells[3].Value.ToString();
            correo.Text = tablaCliente.CurrentRow.Cells[4].Value.ToString();
            telefono.Text = tablaCliente.CurrentRow.Cells[5].Value.ToString();
           
        }

        public void modificarClientes(TextBox id,TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {
            int numId = Convert.ToInt32(id.Text);
            try
            {
                Conexion conexion = new Conexion();

                string query = "update clientes set cedula_Cliente = '"+ cedula.Text + "', nombre_Cliente= '"+ nombre.Text + "', apellido_Cliente= '"+ apellidos.Text + "', correo_Cliente= '"+ correo.Text + "', telefono_Cliente= '" + telefono.Text + "' where id_Cliente = '"+ numId +"';";

                MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se Actualizo la informacion del cliente Exitosamente.");
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No funciona Actualizar clientes." + ex.ToString());
            }
        }

        public void eliminarClientes(TextBox id)
        {
            int numId = Convert.ToInt32(id.Text);
            try
            {
                Conexion conexion = new Conexion();

                string query = "update clientes set status_Cliente= '0' where  id_Cliente = '" + numId + "';";

                MySqlCommand myComand = new MySqlCommand(query, conexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se inactivado al cliente Exitosamente.");
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No funciona Eliminar clientes." + ex.ToString());
            }
        }
    }
}
