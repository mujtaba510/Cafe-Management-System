using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Project
{
    public partial class Form4 : Form
    {
        public Form4(string name)
        {
            InitializeComponent();
            label2.Text = "Welcome, " + name; // You can customize the label text as needed

        }



        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AddEmployee(string username, string password)
        {
            // Define your connection string
            string connectionString = "Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True";

            // Create a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define the SQL query
                    string query = "INSERT INTO CafeteriaStaff (Username, Password) VALUES (@Username, @Password)";

                    // Create a SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void RemoveEmployee(string username)
        {
            // Define your connection string
            string connectionString = "Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True";

            // Create a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Define the SQL query
                    string query = "DELETE FROM CafeteriaStaff WHERE Username = @Username";

                    // Create a SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Add the Username as a parameter
                        cmd.Parameters.AddWithValue("@Username", username);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee removed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove employee. Username not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        private void label1_Click_1(object sender, EventArgs e)
        {
            //add employee functionality
            addRemoveEmployee emp = new addRemoveEmployee(0);
            emp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //remove employee functionality
            addRemoveEmployee emp = new addRemoveEmployee(1);
            emp.Show();
        }
    }
}
