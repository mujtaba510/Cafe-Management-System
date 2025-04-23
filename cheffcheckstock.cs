using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class cheffcheckstock : Form
    {
        private DataGridView dataGridViewStock;

        public cheffcheckstock()
        {
            InitializeComponent();
            InitializeComponents();
            LoadMenuIngredientsInventoryData();
        }

        private void InitializeComponents()
        {
            // Initialize DataGridView for stock
            dataGridViewStock = new DataGridView();
            dataGridViewStock.Location = new System.Drawing.Point(10, 300);
            dataGridViewStock.Size = new System.Drawing.Size(800, 200);
            dataGridViewStock.Visible = true;

            // Add the DataGridView to the form
            Controls.Add(dataGridViewStock);
        }

        private void LoadMenuIngredientsInventoryData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            M.MenuItemID,
                            M.ItemName AS MenuItemName,
                            M.Price,
                            M.Availability,
                            M.Description AS MenuItemDescription,
                            M.Category AS MenuItemCategory,
                            I.IngredientID,
                            I.Name AS IngredientName,
                            I.MenuItemID AS IngredientMenuItemID,
                            Inv.InventoryItemID,
                            Inv.ItemName AS InventoryItemName,
                            Inv.Category AS InventoryCategory,
                            Inv.ExpirationDate,
                            Inv.Quantity,
                            Inv.Units
                        FROM
                            MenuItem M
                        JOIN
                            Ingredient I ON M.MenuItemID = I.MenuItemID
                        JOIN
                            Inventory Inv ON I.Name = Inv.ItemName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable resultTable = new DataTable();
                            adapter.Fill(resultTable);

                            // Assuming you have a DataGridView named dataGridViewStock in your form
                            dataGridViewStock.DataSource = resultTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cheffcheckstock_Load(object sender, EventArgs e)
        {
            // Additional initialization code if needed
        }
    }
}
