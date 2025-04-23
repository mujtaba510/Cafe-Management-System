using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Cheff : Form
    {
        private DataGridView dataGridViewMenuItems;
        private Button addButton;
        private Button removeButton;
        private Button defineIngredientsButton;
        private DataGridView dataGridViewIngredients;
        private Button addIngredientButton;

        public Cheff()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            label1.Click += label1_Click;

            // Initialize DataGridView for menu items
            dataGridViewMenuItems = new DataGridView();
            dataGridViewMenuItems.Location = new System.Drawing.Point(10, 50);
            dataGridViewMenuItems.Size = new System.Drawing.Size(400, 200);
            dataGridViewMenuItems.Visible = false;
            dataGridViewMenuItems.AllowUserToAddRows = true;

            // Initialize Add button
            addButton = new Button();
            addButton.Text = "Add Item";
            addButton.Location = new System.Drawing.Point(10, 260);
            addButton.Click += addButton_Click;
            addButton.Hide();

            // Initialize Remove button
            removeButton = new Button();
            removeButton.Text = "Remove Item";
            removeButton.Location = new System.Drawing.Point(120, 260);
            removeButton.Click += removeButton_Click;
            removeButton.Hide();

            // Initialize Define Ingredients button
            defineIngredientsButton = new Button();
            defineIngredientsButton.Text = "Define Ingredients";
            defineIngredientsButton.Location = new System.Drawing.Point(230, 260);
            defineIngredientsButton.Click += defineIngredientsButton_Click;
            defineIngredientsButton.Hide();

            // Initialize DataGridView for ingredients
            dataGridViewIngredients = new DataGridView();
            dataGridViewIngredients.Location = new System.Drawing.Point(420, 50);
            dataGridViewIngredients.Size = new System.Drawing.Size(300, 200);
            dataGridViewIngredients.Visible = false;
            dataGridViewIngredients.AllowUserToAddRows = true;

            // Initialize Add Ingredient button
            addIngredientButton = new Button();
            addIngredientButton.Text = "Add Ingredient";
            addIngredientButton.Location = new System.Drawing.Point(580, 260);
            addIngredientButton.Click += addIngredientButton_Click;
            addIngredientButton.Hide();

            // Add controls to the form
            Controls.Add(dataGridViewMenuItems);
            Controls.Add(addButton);
            Controls.Add(removeButton);
            Controls.Add(defineIngredientsButton);
            Controls.Add(dataGridViewIngredients);
            Controls.Add(addIngredientButton);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PopulateMenuItems();
            addButton.Show();
            removeButton.Show();
            defineIngredientsButton.Show();
        }

        private void defineIngredientsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected
                if (dataGridViewMenuItems.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridViewMenuItems.SelectedRows[0];

                    // Get the MenuItemID from the selected row (assuming it's in the first cell)
                    int menuItemID = Convert.ToInt32(selectedRow.Cells["MenuItemID"].Value);

                    // Show the DataGridView for ingredients
                    ShowIngredientsDataGridView(menuItemID);
                }
                else
                {
                    MessageBox.Show("Please select a row to define ingredients.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowIngredientsDataGridView(int menuItemID)
        {
            // Populate ingredients DataGridView based on menuItemID
            PopulateIngredients(menuItemID);

            // Show the ingredients DataGridView and related controls
            dataGridViewIngredients.Show();
            addIngredientButton.Show();
        }

        private void PopulateIngredients(int menuItemID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
                {
                    connection.Open();
                    string query = $"SELECT * FROM Ingredient WHERE MenuItemID = {menuItemID}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable ingredientsTable = new DataTable();
                            adapter.Fill(ingredientsTable);
                            dataGridViewIngredients.DataSource = ingredientsTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the menuItemID from the currently selected row in dataGridViewMenuItems
                int menuItemID = Convert.ToInt32(dataGridViewMenuItems.SelectedRows[0].Cells["MenuItemID"].Value);

                // Insert the ingredient data into the database
                InsertIngredientIntoDatabase(menuItemID);

                // Refresh the ingredients DataGridView
                PopulateIngredients(menuItemID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertIngredientIntoDatabase(int menuItemID)
        {
            try
            {
                // Assuming that you have columns named "IngredientID" and "Name" in your DataGridView
                DataGridViewRow newRow = dataGridViewIngredients.Rows[dataGridViewIngredients.Rows.Count - 2];

                // Get the ingredient data from the currently selected row in dataGridViewIngredients
                int ingredientID = Convert.ToInt32(newRow.Cells["IngredientID"].Value);
                string ingredientName = newRow.Cells["Name"].Value.ToString();

                // Insert the ingredient data into the database
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
                {
                    connection.Open();
                    string query = "INSERT INTO Ingredient (IngredientID, Name, MenuItemID) VALUES (@IngredientID, @Name, @MenuItemID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IngredientID", ingredientID);
                        command.Parameters.AddWithValue("@Name", ingredientName);
                        command.Parameters.AddWithValue("@MenuItemID", menuItemID);

                        command.ExecuteNonQuery();
                    }
                }

                // Refresh the ingredients DataGridView without resetting it
                PopulateIngredients(menuItemID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PopulateMenuItems()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
                {
                    connection.Open();

                    // Retrieve menu items from the database
                    DataTable menuItemsTable = GetMenuItemsFromDatabase(connection);

                    // Display menu items in the DataGridView
                    dataGridViewMenuItems.DataSource = menuItemsTable;

                    // Make the DataGridView visible
                    dataGridViewMenuItems.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable GetMenuItemsFromDatabase(SqlConnection connection)
        {
            string query = "SELECT * FROM MenuItem";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable menuItemsTable = new DataTable();
                    adapter.Fill(menuItemsTable);
                    return menuItemsTable;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMenuItems.AllowUserToAddRows = true;
                DataGridViewRow newRow = dataGridViewMenuItems.Rows[dataGridViewMenuItems.Rows.Count - 2];

                //int menuItemID = Convert.ToInt32(newRow.Cells["MenuItemID"].Value);
                string itemName = newRow.Cells["ItemName"].Value.ToString();
                decimal price = Convert.ToDecimal(newRow.Cells["Price"].Value);
                bool availability = Convert.ToBoolean(newRow.Cells["Availability"].Value);
                string description = newRow.Cells["Description"].Value.ToString();
                string category = newRow.Cells["Category"].Value.ToString();

                InsertNewItemIntoDatabase(itemName, price, availability, description, category);
                PopulateMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertNewItemIntoDatabase(string itemName, decimal price, bool availability, string description, string category)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
            {
                connection.Open();
                string query = "INSERT INTO MenuItem (ItemName, Price, Availability, Description, Category) VALUES (@ItemName, @Price, @Availability, @Description, @Category)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Category", category);
                    // command.Parameters.AddWithValue("@MenuItemID", menuItemID);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMenuItems.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewMenuItems.SelectedRows[0];
                    int menuItemID = Convert.ToInt32(selectedRow.Cells["MenuItemID"].Value);
                    RemoveItemFromDatabase(menuItemID);
                    PopulateMenuItems();
                }
                else
                {
                    MessageBox.Show("Please select a row to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RemoveItemFromDatabase(int menuItemID)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IMGMHDU\\SQLEXPRESS02;Initial Catalog=Db_Project;Integrated Security=True"))
            {
                connection.Open();
                string query = "DELETE FROM MenuItem WHERE MenuItemID = @MenuItemID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MenuItemID", menuItemID);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Cheff_Load(object sender, EventArgs e)
        {
            // Additional initialization code if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            cheffviewmenu menu = new cheffviewmenu();
            menu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cheffcheckstock stock = new cheffcheckstock();
            stock.Show();
        }
    }
}
