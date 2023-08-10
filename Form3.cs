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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mascotas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctornombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardardoctor_Click(object sender, EventArgs e)
        {

            string nombredoctor = doctornombre.Text;
            string identificacion = doctorcedula.Text;
            string tarjetaprofesional = doctortarejta.Text;
            string fechadenacimiento = doctornacimiento.Text;
            string telefono = telefonodoctor.Text;

            string connectionString = "server=localhost;user=root;database=clinica;";

            // Crear la conexión
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para insertar los datos en la tabla "doctores"
                string sql = "INSERT INTO `doctor` (`IDdoctor`, `Nombre`, `Númerodelicencia`, `Teléfono`, `identificacion`, `fechadenacimiento`) " +
              "VALUES (NULL, @nombre, @numerodelicencia, @telefono, @identificacion, @fechadenacimiento)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
          
                cmd.Parameters.AddWithValue("@nombre", nombredoctor);
                cmd.Parameters.AddWithValue("@NumeroDeLicencia", tarjetaprofesional);
                cmd.Parameters.AddWithValue("@identificacion", identificacion);
                cmd.Parameters.AddWithValue("@fechadenacimiento", fechadenacimiento);
                cmd.Parameters.AddWithValue("@Telefono", telefono);


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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
