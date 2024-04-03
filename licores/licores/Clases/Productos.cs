using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licores.Clases
{
    internal class Producto
    {
        public void MostrarProductos(DataGridView tablaProductos, string filtro = "")
        {
            try
            {
                Conexion conexion = new Conexion();
                string query = "SELECT id_producto, referencia_Producto, nombre_producto, cantidad_Inven_Producto, status_producto, precio, iva_producto FROM productos";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE nombre_producto LIKE '%" + filtro + "%' AND status_producto = 1";
                }
                else
                {
                    query += " WHERE status_producto = 1";
                }

                tablaProductos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.Open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaProductos.DataSource = dt;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.ToString());
            }
        }

        public void GuardarProducto(string referencia, string nombre, int cantidad, int precio, int iva)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = $"INSERT INTO productos (referencia_Producto, nombre_producto, cantidad_Inven_Producto, status_producto, precio, iva_producto) VALUES ('{referencia}', '{nombre}', {cantidad}, 1, {precio}, {iva});";

                MySqlCommand command = new MySqlCommand(query, conexion.Open());
                command.ExecuteNonQuery();
                MessageBox.Show("Producto guardado exitosamente.");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar producto: " + ex.ToString());
            }
        }

        public void SeleccionarProducto(DataGridView tablaProductos, TextBox idProducto, TextBox refProducto, TextBox nombreProducto, TextBox cantProducto, TextBox precioProducto, TextBox ivaProducto)
        {
            try
            {

                idProducto.Text = tablaProductos.CurrentRow.Cells[0].Value.ToString(); // id_producto
                refProducto.Text = tablaProductos.CurrentRow.Cells[1].Value.ToString(); // referencia_Producto
                nombreProducto.Text = tablaProductos.CurrentRow.Cells[2].Value.ToString(); // nombre_producto
                cantProducto.Text = tablaProductos.CurrentRow.Cells[3].Value.ToString(); // cantidad_Inven_Producto
                precioProducto.Text = tablaProductos.CurrentRow.Cells[5].Value.ToString(); // precio
                ivaProducto.Text = tablaProductos.CurrentRow.Cells[6].Value.ToString(); // iva_producto
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar los campos registrados, error: " + ex.ToString());
            }
        }


        public void ModificarProducto(int id, string referencia, string nombre, int cantidad, int precio, int iva)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = $"UPDATE productos SET referencia_Producto = '{referencia}', nombre_producto = '{nombre}', cantidad_Inven_Producto = {cantidad}, precio = {precio}, iva_producto = {iva} WHERE id_producto = {id};";

                MySqlCommand command = new MySqlCommand(query, conexion.Open());
                command.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado exitosamente.");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.ToString());
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = $"UPDATE productos SET status_producto = 0 WHERE id_producto = {id};";

                MySqlCommand command = new MySqlCommand(query, conexion.Open());
                command.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado (inactivado) exitosamente.");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.ToString());
            }
        }
    }
}