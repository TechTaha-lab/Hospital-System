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
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\WinFormsApp7\\WinFormsApp7\\db1.mdf;Integrated Security=True;Connect Timeout=30");

        private void patient_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string queryPatient = "SELECT Id, name FROM employee WHERE roles='doctor'";
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
                string queryDoctor = "SELECT name FROM employee WHERE roles = 'doctor'";
                string queryNurse = "SELECT name FROM employee WHERE roles = 'nurse'";
                using (SqlCommand commandDoctor = new SqlCommand(queryDoctor, connection))
                {
                    SqlDataReader readerDoctor = commandDoctor.ExecuteReader();
                    while (readerDoctor.Read())
                    {
                        comboBox1.Items.Add(readerDoctor["name"].ToString());
                    }
                    readerDoctor.Close();
                }

                using (SqlCommand commandNurse = new SqlCommand(queryNurse, connection))
                {
                    SqlDataReader readerNurse = commandNurse.ExecuteReader();
                    while (readerNurse.Read())
                    {
                        comboBox2.Items.Add(readerNurse["name"].ToString());
                    }
                    readerNurse.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Items.Clear();
            string DName = textBox1.Text;

            string query = "SELECT Id, name FROM employee WHERE name = @name";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(DName) ? (object)DBNull.Value : DName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["name"].ToString());
                            l1.Items.Add(item);
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

            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            l2.Items.Clear();
            string NName = textBox2.Text;
            

            string query = "SELECT Id, name FROM employee WHERE name = @name";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", string.IsNullOrEmpty(NName) ? (object)DBNull.Value : NName);
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string drrole = comboBox1.Text;
            string nrole = comboBox2.Text;
            string pName = textBox3.Text;
            string description = textBox4.Text;
            string time = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"); // Convert DateTime to string
            int dr_id = -1;
            int pa_id = -1;

            try
            {
                connection.Open();

                string selectDoctorIdQuery = "SELECT Id FROM employee WHERE roles = 'doctor'";
                using (SqlCommand command = new SqlCommand(selectDoctorIdQuery, connection))
                {
                    object doctorIdResult = command.ExecuteScalar();
                    if (doctorIdResult != null && int.TryParse(doctorIdResult.ToString(), out dr_id))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Doctor ID not found or invalid format.", "Error");
                        return;
                    }
                }

                string selectNurseIdQuery = "SELECT Id FROM employee WHERE roles = 'nurse'";
                using (SqlCommand command = new SqlCommand(selectNurseIdQuery, connection))
                {
                    object nurseIdResult = command.ExecuteScalar();
                    if (nurseIdResult != null && int.TryParse(nurseIdResult.ToString(), out pa_id))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Nurse ID not found or invalid format.", "Error");
                        return;
                    }
                }


                string selectExistingAppointmentQuery = "SELECT COUNT(*) FROM Appointment WHERE time = @time";
                using (SqlCommand command = new SqlCommand(selectExistingAppointmentQuery, connection))
                {
                    command.Parameters.AddWithValue("@time", time);
                    int existingAppointments = (int)command.ExecuteScalar();
                    if (existingAppointments > 0)
                    {
                        MessageBox.Show("Appointment already exists at this time. Please choose another time.", "Error");
                        return;
                    }
                }

                string insertAppointmentQuery = "INSERT INTO Appointment (doctor_id, nurse_id, patient_name, time, description) VALUES (@doctorId, @nurseId, @patientName, @time, @description)";
                using (SqlCommand insertCommand = new SqlCommand(insertAppointmentQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@doctorId", dr_id);
                    insertCommand.Parameters.AddWithValue("@nurseId", pa_id);
                    insertCommand.Parameters.AddWithValue("@patientName", pName);
                    insertCommand.Parameters.AddWithValue("@time", time);
                    insertCommand.Parameters.AddWithValue("@description", description);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Appointment created successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error creating appointment.");
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;

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

    }
}
