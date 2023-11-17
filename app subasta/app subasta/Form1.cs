using MySql.Data.MySqlClient;

namespace app_subasta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private string connectionString = "server=localhost; database=subasta; user=root; password="

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
               
          string query = "SELECT COUN(*) FROM login WHERE Username = @Usuario AND Password = @Contraseña"; 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", Username);
                    command.Parameters.AddWithValue("@Contraseña", Password);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        Console.WriteLine("inicio de sesion exitoso");

                    }
                    else
                    {
                        Console.WriteLine("credenciales invalidas");
                    }

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}