using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2var = new Form2();
            form2var.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userType = (string)comboBox1.SelectedItem;

            // Initialize variables for different types of users
            string username = "";
            string rollnum = "";
            string password = "";

            // Check user type and collect the appropriate input
            if (userType == "STUDENT")
            {
                rollnum = textBox1.Text; // For students, collect rollnum
                password = textBox2.Text; // For students, collect password
            }
            else if (userType == "FACULTY" || userType == "STAFF" || userType == "ADMIN")
            {
                username = textBox1.Text; // For faculty, cafe staff, and admin, collect username
                password = textBox2.Text; // For faculty, cafe staff, and admin, collect password
            }

            else
            {
                MessageBox.Show("Invalid user type.");
                return; // You might want to return or handle this case appropriately
            }

            // Continue with your database connection and query
            using (SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-PLPIC3Q\\SQLEXPRESS;Initial Catalog=Db_Project;Integrated Security=True"))
            {
                con2.Open();

                string tableName = ""; // Initialize tableName with a default value

                if (userType == "STUDENT")
                {
                    tableName = "Student";
                }
                else if (userType == "FACULTY")
                {
                    tableName = "Faculty";
                }
                else if (userType == "STAFF" || userType == "ADMIN")
                {

                    tableName = "CafeteriaStaff";
                }

                // Construct your SQL query with the collected input
                string query = $"SELECT COUNT(*) FROM {tableName} WHERE ";

                // Add conditions based on the user type
                if (userType == "STUDENT")
                {
                    query += "RollNum = @rollnum AND Password = @password";
                }
                else if (userType == "FACULTY" || userType == "STAFF" || userType == "ADMIN")
                {

                    query += "Username = @username AND Password = @password";
                }

                using (SqlCommand cmd = new SqlCommand(query, con2))
                {
                    cmd.Parameters.AddWithValue("@Username", @username); // This should match the SQL query
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@RollNum", rollnum);

                    try
                    {
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!");

                            if (userType == "FACULTY" || userType == "STUDENT")
                            {
                                stufacdashboard form3 = new stufacdashboard();
                                form3.Show();
                            }
                            else if (userType == "STAFF" && username == "Admin")
                            {
                                Form4 form4 = new Form4(username);
                                form4.Show();
                            }
                            else if (userType == "STAFF" && username == "Manager")
                            {
                                managerDashboard mgrDash = new managerDashboard(username);
                                mgrDash.Show();
                            }
                            else if (username == "Cheff" && userType == "STAFF")
                            {
                                Cheff cheff = new Cheff();
                                cheff.Show();
                            }
                            else if (userType == "STAFF")
                            {
                                empdash emp = new empdash();
                                emp.Show();
                            }

                            this.Hide();


                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }



}

