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
    public partial class stufacdashboard : Form
    {
        public stufacdashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainmenu menu = new mainmenu();
            menu.Show();
            this.Hide();
        }
    }
}
