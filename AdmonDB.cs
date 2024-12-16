using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsFinalProyect
{
    public class AdmonDB
    {
        private MySqlConnection connection;

        public void Connect()
        {
            string cadena = "Server=localhost; Database=cine; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public AdmonDB()
        {
            this.Connect();
        }

        public void insertarProducto(int idp, string name, string about, float precio, int stock)
        {
            string query = "";
            try
            {
                query = "INSERT INTO products (id,name,about,precio,stock) VALUES ("
                  + "'" + idp + "',"
                  + "'" + name + "',"
                  + "'" + about + "',"
                  + "'" + precio + "', "
                  + "'" + stock + "')";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nClave duplicada" + ex.Message);
                this.Disconnect();
            }
        }

        public void eliminarProducto(int idp)
        {
            string query = "";
            try
            {
                query = "DELETE FROM prendas WHERE id=" + idp + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }

        public List<Products> consultaProductos()
        {
            List<Products> data = new List<Products>();
            Products item;

            int id;
            string name;
            string about;
            float precio;
            int stock;

            try
            {
                string query = "SELECT * FROM products";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["producto"]) ?? "";
                    about = Convert.ToString(reader["about"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    stock = Convert.ToInt32(reader["stock"]);

                    item = new Products(id, name, about, precio, stock);
                    data.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }

        public List<Users> consultaUsuarios()
        {
            List<Users> data = new List<Users>();
            Users item;

            int id;
            string cuenta;
            string nombre;
            string pword;
            float monto;

            try
            {
                string query = "SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    pword = Convert.ToString(reader["pword"]) ?? "";
                    monto = Convert.ToSingle(reader["monto"]);

                    item = new Users(id, cuenta, nombre, pword, monto);
                    data.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return data;
        }
    }
}
