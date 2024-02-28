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

                string query = "select * from clientes";
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
            int numCedula = (int)Convert.ToInt64(cedula.Text);
            int numTelefono = (int)Convert.ToInt64(telefono.Text);
            try
            {
                Conexion conexion = new Conexion();

                string query = "insert into clientes (cedula_Cliente, nombre_Cliente, apellido_Cliente, correo_Cliente, telefono_Cliente, status_Cliente)" +
                    " values('" + numCedula + "','" + nombre.Text + "','" + apellidos.Text + "','" + correo.Text + "','" + numTelefono + "', '1');";

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
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }
    }
}
