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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp7
{
    public partial class nurse : Form
    {
        public nurse()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\WinFormsApp7\\WinFormsApp7\\db1.mdf;Integrated Security=True;Connect Timeout=30");


        private void nurse_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string queryPatient = "SELECT Id, name FROM employee WHERE roles='patient'";
                string queryNurse = "SELECT Id, name FROM employee WHERE roles='nurse'";

                using (SqlCommand command = new SqlCommand(queryPatient, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        l1.Items.Add(item);
                    }

                    reader.Close();
                }

                using (SqlCommand command = new SqlCommand(queryNurse, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        l2.Items.Add(item);
                    }

                    reader.Close();
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
            try
            {
                connection.Open();

                string queryAppointment = "SELECT Id, patient_name, time, description FROM Appointment";

                using (SqlCommand command = new SqlCommand(queryAppointment, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["patient_name"].ToString());
                        item.SubItems.Add(reader["time"].ToString());
                        item.SubItems.Add(reader["description"].ToString());
                        listView2.Items.Add(item);
                    }

                    reader.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Items.Clear();
            string drName = textBox1.Text;

            string query = "SELECT  Id,name FROM employee where name = @name ";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", drName);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        l1.Items.Add(item);

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error}");
            }
            finally
            {
                connection.Close();
            }
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pName = textBox5.Text;
            int p_id = -1;

            try
            {
                connection.Open();

                // Select patient ID
                string selectPatientIdQuery = "SELECT Id FROM employee WHERE roles = 'patient' AND name = @pName";
                using (SqlCommand command = new SqlCommand(selectPatientIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@pName", pName);
                    object patientIdResult = command.ExecuteScalar();
                    if (patientIdResult != null && int.TryParse(patientIdResult.ToString(), out p_id))
                    {
                        string selectMedicineQuery = "SELECT Id, medicine_name, description FROM medicine WHERE patient_id = @pId";
                        using (SqlCommand medicineCommand = new SqlCommand(selectMedicineQuery, connection))
                        {
                            medicineCommand.Parameters.AddWithValue("@pId", p_id);
                            SqlDataReader reader = medicineCommand.ExecuteReader();

                            if (!reader.HasRows)
                            {
                                MessageBox.Show("No medicines found for the patient.", "Info");
                            }

                            while (reader.Read())
                            {
                                int medicineId = (int)reader["Id"];
                                string medicineName = reader["medicine_name"].ToString();
                                string medicineDescription = reader["description"].ToString();

                                // Create and add ListViewItem
                                ListViewItem item = new ListViewItem(medicineId.ToString());
                                item.SubItems.Add(medicineName);
                                item.SubItems.Add(medicineDescription);
                                listView1.Items.Add(item);

                                MessageBox.Show($"medicine Id: {medicineId}, Name: {medicineName}, Description: {medicineDescription}");
                            }
                            reader.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Patient ID not found or invalid format.", "Error");
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
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                int id = Convert.ToInt32(textBox3.Text);

                string deleteQuery = "DELETE FROM Appointment WHERE ID = @id";
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No appointment found with the given ID.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
            finally
            {
                connection.Close();
            }
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            l2.Items.Clear();
            string pName = textBox2.Text;


            string query = "SELECT Id, name FROM employee WHERE name = @name";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(pName) ? (object)DBNull.Value : pName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["name"].ToString());
                            l2.Items.Add(item);
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
    }
}
