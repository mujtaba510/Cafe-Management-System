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
using System.Diagnostics.Eventing.Reader;

namespace DB_Project
{
    public partial class managerDashboard : Form
    {
        public managerDashboard(string name)
        {
            InitializeComponent();
            label3.Text = "Welcome, " + name; // You can customize the label text as needed

        }

        private void managerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            CreateAndDisplayEmployeesGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void DisplayEmployees()
        {
            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True";

            // SQL query to select all employees from the CafeteriaStaff table
            string query = "SELECT * FROM CafeteriaStaff";

            // Create a DataTable to store the results
            DataTable dataTable = new DataTable();

            // Using statement ensures that resources are released when the SqlConnection is closed
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a SqlDataAdapter to execute the query and fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Fill the DataTable with the results from the query
                    adapter.Fill(dataTable);

                }
            }

            // Set the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = dataTable;
        }
        private void CreateAndDisplayEmployeesGrid()
        {
            // Create a new DataGridView
            dataGridView1 = new DataGridView();

            // Set properties for the DataGridView
            dataGridView1.Name = "dataGridView1";

            // Set the location and size of the DataGridView (adjust these values as needed)
            dataGridView1.Location = new Point(300, 100);

            dataGridView1.Size = new Size(300, 300);

            // Fetch and display the employees in the DataGridView
            DisplayEmployees();

            // Add the DataGridView to the form's controls
            this.Controls.Add(dataGridView1);
        }




    }
}
