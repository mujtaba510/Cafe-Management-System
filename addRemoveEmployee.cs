using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Project
{
    public partial class addRemoveEmployee : Form
    {
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private Button actionButton;
        int var;

        public addRemoveEmployee(int a)
        {
            InitializeComponent();

            // Create and initialize the controls
            usernameTextBox = new TextBox();
            usernameTextBox.Location = new Point(10, 10);
            usernameTextBox.Size = new Size(200, 20);

            passwordTextBox = new TextBox();
            passwordTextBox.Location = new Point(10, 40);
            passwordTextBox.Size = new Size(200, 20);

            usernameLabel = new Label();
            usernameLabel.Text = "Username:";
            usernameLabel.Location = new Point(10, 10);

            actionButton = new Button();
            if (a == 0)
            {
                actionButton.Text = "Add";
            }
            else if (a == 1)
            {
                actionButton.Text = "Remove";
            }

            actionButton.Location = new Point(10, 70);
            actionButton.Click += ActionButton_Click;


            // Add controls to the form based on the value of 'a'
            if (a == 0) //add employee
            {
                this.Controls.Add(usernameTextBox);
                this.Controls.Add(passwordTextBox);
                this.Controls.Add(usernameLabel);
                this.Controls.Add(actionButton);
                var = a;
            }
            else if (a == 1)
            {
                this.Controls.Add(usernameTextBox);
                this.Controls.Add(usernameLabel);
                this.Controls.Add(actionButton);
                passwordTextBox.Dispose(); // Remove the passwordTextBox
                var = a;
            }
        }

        private void addRemoveEmployee_Load(object sender, EventArgs e)
        {

        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            // Handle the button click based on whether you are adding or removing an employee
            if (var == 0/*actionButton.Text == "Add Employee"*/)
            {
                // Add employee logic using usernameTextBox and passwordTextBox
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                // Implement the AddEmployee function here
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    // Define your connection string
                    string connectionString = "Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True";

                    // Create a SQL connection
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Define the SQL query for adding an employee
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
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a username and password.");
                }

            }
            else if (var == 1)
            {
                // Remove employee logic using usernameTextBox
                string usernameToRemove = usernameTextBox.Text;
                // Implement the RemoveEmployee function here
                if (!string.IsNullOrEmpty(usernameToRemove))
                {
                    // Define your connection string
                    string connectionString = "Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True";

                    // Create a SQL connection
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // Define the SQL query for removing an employee
                            string query = "DELETE FROM CafeteriaStaff WHERE Username = @Username";

                            // Create a SqlCommand
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                // Add the Username as a parameter
                                cmd.Parameters.AddWithValue("@Username", usernameToRemove);

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
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a username to remove.");
                }
            }
        }
    }
}
