using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mascotas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private void txtpanelform2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            txthorario.Items.Add("8:00");
            txthorario.Items.Add("9:00");
            txthorario.Items.Add("10:00");
            txthorario.Items.Add("11:00");
            txthorario.Items.Add("12:00");
            txthorario.Items.Add("13:0");
            txthorario.Items.Add("14:00");
            txthorario.Items.Add("15:00");
            txthorario.Items.Add("16:00");
            txthorario.Items.Add("17:00");

            string connectionString = "server=localhost;user=root;database=clinica;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT iddoctor, nombre FROM doctor;";
                string sql2 = "SELECT idsede ,nombresede FROM sede;";
                string sql3 = "SELECT idpaciente ,nombre FROM `pacientes`";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);



                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idDoctor = reader.GetInt32("iddoctor");
                        string nombreDoctor = reader.GetString("nombre");
                        txtdoctor.Items.Add(idDoctor);

                    }
                }
                using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        string idsede = reader2.GetString("idsede");
                        txtconsultorios.Items.Add(idsede);
                    }
                }

                using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                {
                    while (reader3.Read())
                    {
                        int idpaciente = reader3.GetInt32("idpaciente");
                        string nombrepaciente = reader3.GetString("nombre");
                        txtnombre.Items.Add(idpaciente);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de la base de datos: " + ex.Message);
            }
        }

        private void btnreservar_Click(object sender, EventArgs e)
        {

            string nombre = txtnombre.Text;
            string raza = txtmostrar.Text;
            string doctor = txtdoctor.Text;
            string hora = txthorario.Text;
            DateTime horario1 = timexx.Value;




            string datosenlinea = "NOMBRE :" + nombre + "RAZA:  " + raza + "Doctor: " + doctor + "Horario:  " + hora + "Fecha: " + horario1;
            // Agregar el texto del TextBox al ListBox

            txtlista.Items.Add(datosenlinea);

            // Limpiar el TextBox después de agregar el nombre

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtconsultorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtconsultorios.SelectedItem != null)
{
    string selectedValue = txtconsultorios.SelectedItem.ToString();
    if (int.TryParse(selectedValue, out int selectedId))
    {
        string connectionString = "server=localhost;user=root;database=clinica;";
        MySqlConnection conn = new MySqlConnection(connectionString);

        string sql = "SELECT nombresede FROM sede WHERE idsede = @id;";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", selectedId);

        try
        {
            conn.Open();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string nombreSede = reader.GetString("nombresede");
        mostrarnombreconsultorio.Text = nombreSede; // Cambia el nombre en el Label
                }
}
        }
        catch (Exception ex)
        {
    MessageBox.Show("Error al obtener datos de la base de datos: " + ex.Message);
}
        finally
        {
    conn.Close();
}
    }
    else
{
    MessageBox.Show("Selecciona un valor válido.");
}
                }


}
            private void timexx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string idpaciente = txtnombre.Text;
            string iddoctor = txtdoctor.Text;
            string raza = txtraza.Text;
            string sede = txtconsultorios.Text;
            string hora = txthorario.Text;
            DateTime fecha = timexx.Value;

            string connectionString = "server=localhost;user=root;database=clinica;";

            // Crear la conexión
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    // Consulta SQL para insertar los datos en la tabla "citas"
                    string sql = "INSERT INTO `citas` (`idpaciente`, `iddoctor`, `idsede`, `fecha`, `raza`, `horario`) VALUES (@idpaciente, @iddoctor, @idsede, @fecha, @raza, @horario);";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idpaciente", idpaciente);
                    cmd.Parameters.AddWithValue("@iddoctor", iddoctor);
                    cmd.Parameters.AddWithValue("@idsede", sede);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@raza", raza);
                    cmd.Parameters.AddWithValue("@horario", hora);

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

        private void txtnombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtnombre.SelectedItem != null)
            {
                int selectedId = (int)txtnombre.SelectedItem;
                string connectionString = "server=localhost;user=root;database=clinica;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                string sql = "SELECT nombre FROM pacientes WHERE idpaciente = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedId);

                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreDoctor = reader.GetString("nombre");
                            mostrarnombredueño.Text = nombreDoctor; // Cambia el nombre en el Label
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de la base de datos: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        private void txtdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtdoctor.SelectedItem != null)
            {
                int selectedId = (int)txtdoctor.SelectedItem;
                string connectionString = "server=localhost;user=root;database=clinica;";
                MySqlConnection conn = new MySqlConnection(connectionString);

                string sql = "SELECT nombre FROM doctor WHERE iddoctor = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", selectedId);

                try
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombreDoctor = reader.GetString("nombre");
                            labelnombre.Text = nombreDoctor; // Cambia el nombre en el Label
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos de la base de datos: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }




        private void mostrarnombredueño_Click(object sender, EventArgs e)
        {


        }

        private void txthorario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

