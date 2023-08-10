using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombredueño = txtnombredueño.Text;
            string raza = txtrazadueño.Text;
            string especie = txtespecie.Text;
            string direcion =txtdirecion.Text;
             DateTime denacimiento = dateTimePicker2.Value;
            string telefono = txttelefono.Text; 



            string connectionString = "server=localhost;user=root;database=clinica;";

            // Crear la conexión
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    // Consulta SQL para insertar los datos en la tabla "citas"
                    string sql = "INSERT INTO `pacientes` (`nombre`, `raza`, `Especie`, `Fechadenacimiento`, `Dirección`, `Telefono`) VALUES (@nombre, @raza, @especie, @fechadenacimiento, @direccion, @telefono);";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombredueño);
                    cmd.Parameters.AddWithValue("@raza", raza);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@fechadenacimiento", denacimiento);
                    cmd.Parameters.AddWithValue("@direccion", direcion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);



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
            }
        }
    }
}
