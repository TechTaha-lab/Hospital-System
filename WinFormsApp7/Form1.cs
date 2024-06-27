using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            comboBox1.Items.AddRange(new string[] { "admin", "doctor", "nurse", "patient" });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\WinFormsApp7\\WinFormsApp7\\db1.mdf;Integrated Security=True;Connect Timeout=30");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("all field are required");
            }
            else
            {
                try
                {
                    connection.Open();

                    if (comboBox1.Text == "admin" && textBox1.Text == "admin" && textBox2.Text == "admin")
                    {

                        string query = "insert into admin (user_admin, admin_password) values (@username, @password)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", textBox1.Text);
                            command.Parameters.AddWithValue("@password", textBox2.Text);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Admin logged successfully.");

                                admin ad = new admin();
                                ad.Show();

                            }
                            else
                            {
                                MessageBox.Show("Error creating admin account.");
                            }
                        }
                    }

                    try
                    {
               
                        string selectQuery = "SELECT Id, [password] FROM employee WHERE name = @username AND roles = @role";
                        string username = textBox1.Text.Trim();
                        string password = textBox2.Text.Trim();
                        string role = comboBox1.Text.ToLower();

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@role", role);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string storedPassword = reader["password"].ToString();
                                    int id = Convert.ToInt32(reader["Id"]);

                                 
                                    if (password == storedPassword)
                                    {
                                        switch (role)
                                        {
                                            case "doctor":
                                                MessageBox.Show("Logged in successfully as doctor");
                                                doctor c1 = new doctor();
                                                c1.Show();
                                                break;
                                            case "patient":
                                                MessageBox.Show("Logged in successfully as patient");
                                                patient s = new patient();
                                                s.Show();
                                                break;
                                            case "nurse":
                                                MessageBox.Show("Logged in successfully as nurse");
                                                nurse n1 = new nurse();
                                                n1.Show();
                                                break;
                                            default:
                                                MessageBox.Show("Invalid role.", "Error");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Invalid password or username");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"No user found with the provided username and role.", "Error");
                                }
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show($"An error has occurred: {error.Message}", "Error");
                    }
                  




                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passwordresetions password = new passwordresetions();
            password.Show();
        }
    }
}