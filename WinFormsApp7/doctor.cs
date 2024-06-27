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
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\pc.cc\\source\\repos\\WinFormsApp7\\WinFormsApp7\\db1.mdf;Integrated Security=True;Connect Timeout=30");

        private void doctor_Load(object sender, EventArgs e)
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
                        listView3.Items.Add(item);
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
            string pName = textBox1.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string NName = textBox2.Text;
            l2.Items.Clear();
            string drName = textBox1.Text;

            string query = "SELECT  Id,name FROM employee where name = @name ";
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", NName);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        l2.Items.Add(item);

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

        private void button3_Click(object sender, EventArgs e)
        {
            int idToSearch = Convert.ToInt32(textBox3.Text);
            bool appointmentFound = false;

            foreach (ListViewItem item in listView3.Items)
            {
                if (item.SubItems[0].Text == idToSearch.ToString())
                {
                    appointmentFound = true;
                    listView3.Focus();
                    MessageBox.Show("Appointment found!");
                    break;
                }
            }

            if (!appointmentFound)
            {
                MessageBox.Show("Appointment not found.");
            }
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string me_name = textBox7.Text;
            string desc = textBox6.Text;
            string drName = textBox4.Text;
            string pName = textBox5.Text;
            int dr_id = -1;
            int p_id = -1;

            try
            {
                connection.Open();

                string selectDoctorIdQuery = "SELECT Id FROM employee WHERE roles = 'doctor' AND name = @drName";
                using (SqlCommand command = new SqlCommand(selectDoctorIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@drName", drName);
                    object doctorIdResult = command.ExecuteScalar();
                    if (doctorIdResult != null && int.TryParse(doctorIdResult.ToString(), out dr_id))
                    {
                        // Doctor ID retrieved successfully
                    }
                    else
                    {
                        MessageBox.Show("Doctor ID not found or invalid format.", "Error");
                        return;
                    }
                }

                string selectPatientIdQuery = "SELECT Id FROM employee WHERE roles = 'patient' AND name = @pName";
                using (SqlCommand command = new SqlCommand(selectPatientIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@pName", pName);
                    object patientIdResult = command.ExecuteScalar();
                    if (patientIdResult != null && int.TryParse(patientIdResult.ToString(), out p_id))
                    {
                        // Patient ID retrieved successfully
                    }
                    else
                    {
                        MessageBox.Show("Patient ID not found or invalid format.", "Error");
                        return;
                    }
                }

                string insertMedicineQuery = "INSERT INTO medicine (doctor_id, patient_id, medicine_name, description) VALUES (@drId, @pId, @meName, @description)";
                using (SqlCommand insertCommand = new SqlCommand(insertMedicineQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@drId", dr_id);
                    insertCommand.Parameters.AddWithValue("@pId", p_id);
                    insertCommand.Parameters.AddWithValue("@meName", me_name);
                    insertCommand.Parameters.AddWithValue("@description", desc);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medicine record inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error inserting medicine record.");
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
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tabPage4.BackColor = Color.Blue;
                tabPage4.ForeColor = Color.White;
            }
            else
            {
                tabPage4.BackColor = Color.Transparent;
                tabPage4.BackColor = Color.Black;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tabPage4.BackColor = Color.Red;
                tabPage4.ForeColor = Color.White;
            }
            else
            {
                tabPage4.BackColor = Color.Transparent;
                tabPage4.BackColor = Color.Black;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tabPage3.BackColor = Color.Blue;
                tabPage3.ForeColor = Color.White;
            }
            else
            {
                tabPage3.BackColor = Color.Transparent;
                tabPage3.BackColor = Color.Black;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tabPage3.BackColor = Color.Red;
                tabPage3.ForeColor = Color.White;
            }
            else
            {
                tabPage3.BackColor = Color.Transparent;
                tabPage3.BackColor = Color.Black;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
