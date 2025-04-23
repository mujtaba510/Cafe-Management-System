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
    public partial class cheffviewmenu : Form
    {
        private DataGridView dataGridViewRecipe;

        public cheffviewmenu()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Initialize DataGridView for recipe
            dataGridViewRecipe = new DataGridView();
            dataGridViewRecipe.Location = new System.Drawing.Point(10, 50);
            dataGridViewRecipe.Size = new System.Drawing.Size(710, 200);

            // Add controls to the form
            Controls.Add(dataGridViewRecipe);

            // Load the recipe data into the DataGridView
            PopulateRecipe();
        }

        private void PopulateRecipe()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
                {
                    connection.Open();
                    string query = @"SELECT 
                                    M.MenuItemID,
                                    M.ItemName,
                                    M.Price,
                                    M.Availability,
                                    M.Description,
                                    M.Category,
                                    I.IngredientID,
                                    I.Name AS IngredientName
                                FROM
                                    MenuItem M
                                JOIN
                                    Ingredient I ON M.MenuItemID = I.MenuItemID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable recipeTable = new DataTable();
                            adapter.Fill(recipeTable);
                            dataGridViewRecipe.DataSource = recipeTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cheffviewmenu_Load(object sender, EventArgs e)
        {
            // Additional initialization code if needed
        }
    }

}
