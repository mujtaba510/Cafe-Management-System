using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class burger : Form
    {
        public burger()
        {
            InitializeComponent();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu menu = new mainmenu();
            menu.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
