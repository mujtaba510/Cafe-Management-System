namespace DB_Project
{
    public partial class mainmenu : Form
    {
        private burger form2; // Declare an instance of Form2
        private pizzaa form3; // Declare an instance of Form3
        private snacks form4; // Declare an instance of Form4
        private drinks form5; // Declare an instance of Form5


        public mainmenu()
        {
            InitializeComponent();
            //form1 = new Form1();
            form2 = new burger(); // Initialize Form2
            form3 = new pizzaa(); // Initialize Form3
            form4 = new snacks(); // Initialize Form4
            form5 = new drinks(); // Initialize Form5
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            // Initially, show form1 and hide the others
            form2.Hide();
            form3.Hide();
            form4.Hide();
            form5.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // When label2 is clicked, show form2 and hide the others
            form2.Show();
            this.Hide();

          
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // When label3 is clicked, show form3 and hide the others
            form3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // When label1 is clicked, show form1 and hide the others
         
        }

        // You can add similar click event handlers for other labels as needed.

        private void label4_Click(object sender, EventArgs e)
        {
            // Handle label4 click event here
            form4.Show();
            this.Hide();
        }
    

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label5 click event here
            form5.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stufacdashboard form3 = new stufacdashboard();
            form3.Show();
            this.Hide();
        }
    }
}
