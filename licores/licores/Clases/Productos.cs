using licores.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licorera.clases
{
    internal class Producto
    {
        public void mostrarProductos(DataGridView tablaProductos)
        {
            try
            {
                Conexion objetoConexion = new Conexion();

                String query = "select * from productos";
                tablaProductos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.Open());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProductos.DataSource = dt;
                objetoConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }

        public void guardarProductos(TextBox referencia, TextBox nombre, TextBox precio, TextBox iva, TextBox cantidad)
        {
            try
            {
                Conexion objetoConexion = new Conexion();

                String query = "insert into productos (referencia, nombre, precio, iva, cantidad)" +
                    "values ('" + referencia.Text + "','" + nombre.Text + "','" + precio.Text + "','" + iva.Text + "','" + cantidad.Text + "');";

                MySqlCommand myComand = new MySqlCommand(query, objetoConexion.Open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardó los registros exitosamente");

                while (reader.Read())
                {

                }
                objetoConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error: " + ex.ToString());
            }
        }
    }
}
