using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_subasta
{
    internal class Conexion
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Database=subasta;Uid=usuario;Pwd=;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa a la base de datos.");

                // Realiza las operaciones que necesites en la base de datos

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada.");
            }
        }
    }
}
