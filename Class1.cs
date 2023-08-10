using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mascotas
{
    internal class Class1
    {
        static void Mainbd(string[] args)
        {

            // Configurar la cadena de conexión
            string connectionString = "server=localhost;user=root;database=clinica;";

            // Crear la conexión
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                // Abrir la conexión
                conn.Open();

                Console.WriteLine("Conexión exitosa a la base de datos.");

                // Operaciones con la base de datos...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }

            // Esperar a que el usuario presione Enter para salir
            Console.WriteLine("Presiona Enter para salir.");
            Console.ReadLine();
        }
       


        }

    }

