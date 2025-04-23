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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            roleLabel.Parent = pictureBox1;
            roleLabel.BackColor = Color.Transparent;
            roleLabel.Visible = false;
            roleTextBox.Visible = false;
            Phone.Parent = pictureBox1;
            Phone.BackColor = Color.Transparent;
            rolenum.Parent = pictureBox1;
            rolenum.BackColor = Color.Transparent;
            rolenum.Visible = false;
            textBox4.Visible = false;
            facultyid.Parent = pictureBox1;
            facultyid.BackColor = Color.Transparent;
            facultyid.Visible = false;
            facultyidtextbox.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check the selected user type and show/hide role text box accordingly
            if (comboBox1.SelectedItem.ToString() == "FACULTY")
            {
                // If faculty is selected, show the role label and text box
                roleLabel.Visible = true;
                roleTextBox.Visible = true;
                facultyid.Visible = true;
                facultyidtextbox.Visible = true;
                rolenum.Visible = false;
                textBox4.Visible = false;

            }

            else
            {
                // If student is selected, hide the role label and text box
                roleLabel.Visible = false;
                roleTextBox.Visible = false;
                rolenum.Visible = true;
                textBox4.Visible = true;
                facultyid.Visible = false;
                facultyidtextbox.Visible = false;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string username = textBox1.Text;
            string password = textBox2.Text;
            string phoneno = textBox3.Text;
            string rolenum = textBox4.Text;
            int rolenumber = Convert.ToInt32(rolenum);



            string userType = (string)comboBox1.SelectedItem;
            string role = (string)roleTextBox.SelectedItem;
            int discount = 0;
            string facID = facultyidtextbox.Text;

            if (userType == "FACULTY")
            {
                if (role == "Visiting")
                {
                    discount = 100;
                }
                else if (role == "Instructor")
                {
                    discount = 150;
                }
                else if (role == "Professor")
                {
                    discount = 200;
                }
                else if (role == "Hod")
                {
                    discount = 250;
                }
                else
                {
                    discount = 0;
                }

            }



            MessageBox.Show($"Registration successful!\nUsername: {username}\nPassword: {password}\nPhoneno: {phoneno}");

            using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
            {
                con1.Open();


                string query = "INSERT INTO Student (RollNum,Name, Password, Phone) VALUES (@RollNum,@Name, @Password, @PhoneNumber)";
                string query2 = "INSERT INTO faculty (FacultyID,Name, Password, role ,Phone, Discount) VALUES (@FacultyID,@Name, @Password, @role, @PhoneNumber, @Discount)";

                if (userType == "STUDENT")
                {
                    using (SqlCommand cmd = new SqlCommand(query, con1))
                    {
                        cmd.Parameters.AddWithValue("@RollNum", rolenumber);
                        cmd.Parameters.AddWithValue("@Name", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneno);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted into the database.");

                            // Hide the current form and show the login form
                            this.Hide();
                            Form1 loginForm = new Form1();
                            loginForm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }

                }
                else if (userType == "FACULTY")
                {
                    using (SqlCommand cmd = new SqlCommand(query2, con1))
                    {
                        cmd.Parameters.AddWithValue("@FacultyID", facID);
                        cmd.Parameters.AddWithValue("@Name", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneno);
                        cmd.Parameters.AddWithValue("@Discount", discount);


                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted into the database.");

                            // Hide the current form and show the login form
                            this.Hide();
                            Form1 loginForm = new Form1();
                            loginForm.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Error: ");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
