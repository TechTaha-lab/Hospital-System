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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\WinFormsApp7\\WinFormsApp7\\db1.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string roles = comboBox2.Text;

            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM employee WHERE name = @name AND roles = @roles";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@roles", roles);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the provided name and role.", "Error");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error.Message}", "Error");
            }
            finally
            {
                connection.Close();
            }
            textBox4.Clear();
            comboBox2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;
            string roles = comboBox1.Text;

            int id = -1;

            try
            {
                connection.Open();

                string checkExistQuery = "SELECT COUNT(*) FROM employee WHERE name = @name AND roles = @roles";
                using (SqlCommand checkExistCommand = new SqlCommand(checkExistQuery, connection))
                {
                    checkExistCommand.Parameters.AddWithValue("@name", name);
                    checkExistCommand.Parameters.AddWithValue("@roles", roles);
                    int existingCount = (int)checkExistCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        MessageBox.Show("User already exists.", "Error");
                        return;
                    }
                }

                string selectQuery = "SELECT Id FROM admin";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out id))
                    {
                        string insertQuery = "INSERT INTO employee (roles, name, [password], admin_id) VALUES (@roles, @name, @password, @adminId)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@roles", roles);
                            insertCommand.Parameters.AddWithValue("@name", name);
                            insertCommand.Parameters.AddWithValue("@password", pass);
                            insertCommand.Parameters.AddWithValue("@adminId", id);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data inserted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Error inserting data.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No admin ID found or invalid format.", "Error");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error.Message}", "Error");
            }
            finally
            {
                connection.Close();
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";

        }


        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            string roles = comboBox3.Text;
            string res = textBox6.Text;

            try
            {
                connection.Open();
                string query = "SELECT password FROM employee WHERE roles = @roles AND name = @name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roles", roles);
                    command.Parameters.AddWithValue("@name", name);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string password = result.ToString();
                        textBox6.Text = password;
                    }
                    else
                    {
                        MessageBox.Show("No password found for the provided name and role.", "Error");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error.Message}", "Error");
            }
            finally
            {
                connection.Close();
            }

        }

        private void admin_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "SELECT Id, name, roles FROM employee";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listView1.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["name"].ToString());
                            item.SubItems.Add(reader["roles"].ToString());

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error.Message}", "Error");
            }
            finally
            {
                connection.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string nameToSearch = textBox3.Text.Trim();
          


            string query = "SELECT Id, name, roles FROM employee WHERE name = @name";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(nameToSearch) ? (object)DBNull.Value : nameToSearch);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["name"].ToString());
                            item.SubItems.Add(reader["roles"].ToString());

                            listView1.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred: {error.Message}");
            }
            finally
            {
                connection.Close();
            }

            // Clear the text box after operation
            textBox2.Clear();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }

}
