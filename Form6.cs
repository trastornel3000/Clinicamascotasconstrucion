using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mascotas
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreproducto = txtnombreproducto.Text;
            string descripcion = txtdescripcion.Text;
            string preciodecosto = txtpreciocosto.Text;
            string preciodeventa = txtprecioventa.Text;
            string stock = txtstock.Text;


            string connectionString = "server=localhost;user=root;database=clinica;";

            // Crear la conexión
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Abrir la conexión
                conn.Open();

                string sql = "INSERT INTO `productos` (`nombreproducto`, `descripsion`, `preciocosto`, `stock`, `precioventa`)  VALUES (@nombreproducto, @descripcion, @preciocosto, @stock, @precioventa)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombreproducto", nombreproducto);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@preciocosto", preciodecosto); // Nombre del parámetro corregido
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@precioventa", preciodeventa); // Nombre del parámetro corregido



                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Datos guardados en la base de datos.");
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos en la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}

