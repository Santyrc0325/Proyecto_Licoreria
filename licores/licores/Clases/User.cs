﻿using MySql.Data.MySqlClient;
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

        public void GuardarUsuarios(TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {

            long numCedula = (int)Convert.ToInt64(cedula.Text);
            long numTelefono = (long)(Int128)Convert.ToInt64(telefono.Text);

            try
            {
                Conexion conexion = new Conexion();

                string query = "insert into users (cedula_User, nombre_User, apellido_User, correo_User, telefono_User, status_User)" + "values ('" + numCedula + "', '" + nombre.Text + "', '" + apellidos.Text + "', '" + correo.Text + "', '" + numTelefono + "', '1');";


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
                MessageBox.Show("Error no se guardo: " + ex.ToString());
            }


        }

        public void SeleccionarUsuario(DataGridView tablaUsuarios, TextBox cedula, TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {
            try
            {
                cedula.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                nombre.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                apellidos.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                correo.Text = tablaUsuarios.CurrentRow.Cells[4].Value.ToString();
                telefono.Text = tablaUsuarios.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logor seleccionar los campos registrados, error: " + ex.ToString());
            }
        }
    }
}
