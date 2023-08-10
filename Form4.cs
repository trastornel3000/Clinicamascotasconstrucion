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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnguardardoctor_Click(object sender, EventArgs e)
        {
            string nombresedelasede = nombresede.Text;
            string direcion =direcionsede.Text;
            string telefonositio = telefonosede.Text;
            string correoeletronico =correosede.Text;   




            string connectionString = "server=localhost;user=root;database=clinica;";

            // Crear la conexión
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para insertar los datos en la tabla "doctores"
                string sql = "INSERT INTO `sede` (`idsede`, `nombresede`, `direcion`, `telefono`, `CORREOSEDE`) " +
                 "VALUES (NULL, @nombresede, @direccion, @telefono, @correoSede)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nombresede", nombresedelasede);
                cmd.Parameters.AddWithValue("@direccion", direcion);
                cmd.Parameters.AddWithValue("@telefono", telefonositio);
                cmd.Parameters.AddWithValue("@correoSede", correoeletronico);



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

