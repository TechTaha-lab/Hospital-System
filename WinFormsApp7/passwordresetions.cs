using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class passwordresetions : Form
    {
        public passwordresetions()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\WinFormsApp7\\WinFormsApp7\\db1.mdf;Integrated Security=True;Connect Timeout=30");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                string selectedRole = comboBox1.Text.ToLower(); // Convert to lowercase for case-insensitive comparison

                try
                {
                    string data1 = textBox1.Text; // Current password
                    string data2 = textBox2.Text; // New password

                    string query = "";

                    switch (selectedRole)
                    {
                        case "admin":
                            query = "UPDATE admin SET admin_password = @data2 WHERE admin_password = @data1";
                            break;
                        case "doctor":
                        case "nurse":
                        case "patient":
                            query = "UPDATE employee SET password = @data2 WHERE password = @data1 AND roles = @roles";
                            break;
                        default:
                            MessageBox.Show("Invalid role selected");
                            return;
                    }

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@data1", data1); // Current password
                        command.Parameters.AddWithValue("@data2", data2); // New password
                        command.Parameters.AddWithValue("@roles", selectedRole);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No matching record found to update the password.");
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show($"An error occurred: {error}");
                }
                finally
                {
                    connection.Close();
                }
            }


        }

        private void passwordresetions_Load(object sender, EventArgs e)
        {

        }
    }
}
