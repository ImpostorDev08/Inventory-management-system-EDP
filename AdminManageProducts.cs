using Microsoft.Data.SqlClient;
using System.Data;

namespace inventoryManagentSystem
{
    public partial class AdminManageProducts : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public AdminManageProducts()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void displayAllProducts()
        {
            AddProductData apData = new AddProductData();
            List<AddProductData> listData = apData.AllProductData();
            dataGridView2.DataSource = listData;
        }
        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_brand.SelectedIndex == -1
                || addProducts_category.SelectedIndex == -1 || addProducts_stock.Text == "" || addProducts_size.Text == "")
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM products WHERE prod_ID = @prod_ID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prod_ID", addProducts_prodID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + addProducts_prodID.Text.Trim() + " already exists",
                                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products(prod_id, prod_name, brand, category, stock, size, description, date_insert) " +
                                    "VALUES(@prodID, @prodName, @brand, @cat, @stock, @size, @des, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@brand", addProducts_brand.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@size", addProducts_size.Text.Trim());
                                    insertD.Parameters.AddWithValue("@des", addProducts_description.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllProducts();
                                    MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_brand.SelectedItem = -1;
            addProducts_category.SelectedItem = -1;
            addProducts_stock.Text = "";
            addProducts_size.Text = "";
            addProducts_description.Text = "";
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AdminManageProducts_Load(object sender, EventArgs e)
        {
            displayAllProducts();
        }

        private int getID = 0;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_brand.SelectedItem = row.Cells[3].Value.ToString();
                addProducts_category.SelectedItem = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();
                addProducts_size.Text = row.Cells[6].Value.ToString(); ;
                addProducts_description.Text = row.Cells[7].Value.ToString();

            }
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_brand.SelectedIndex == -1
                || addProducts_category.SelectedIndex == -1 || addProducts_stock.Text == "" || addProducts_size.Text == "")
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Product ID: " + addProducts_prodID.Text.Trim() + "?",
                   "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName, brand = @brand, category = @cat, stock = @stock, size = @size, description = @des WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                updateD.Parameters.AddWithValue("@brand", addProducts_brand.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@size", addProducts_size.Text.Trim());
                                updateD.Parameters.AddWithValue("@des", addProducts_description.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                DateTime today = DateTime.Today;
                                updateD.Parameters.AddWithValue("@date", today);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();
                                MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void addProducts_archiveBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_brand.SelectedIndex == -1
                || addProducts_category.SelectedIndex == -1 || addProducts_stock.Text == "" || addProducts_size.Text == "")
            {
                MessageBox.Show("Empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (MessageBox.Show("Are you sure you want to Archive product ID: " + addProducts_prodID.Text.Trim() + "?",
                "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            inserttoarchive();
                            string archiveData = "DELETE FROM products WHERE id = @id";

                            using (SqlCommand archiveD = new SqlCommand(archiveData, connect))
                            {
                                archiveD.Parameters.AddWithValue("@id", getID);
                                archiveD.ExecuteNonQuery();

                                clearFields();
                                displayAllProducts();

                                MessageBox.Show("Archived successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }

        }
        private void inserttoarchive()
        {
            string selectData = "SELECT prod_id, prod_name, brand, category, stock, size, description " +
                                "FROM products WHERE id = @id";

            DataTable productTable = new DataTable();
            using (SqlCommand selectCmd = new SqlCommand(selectData, connect))
            {
                selectCmd.Parameters.AddWithValue("@id", getID);
                SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);
                adapter.Fill(productTable);
            }

            DataRow row = productTable.Rows[0];

            string insertData = @"INSERT INTO archivedproducts 
                        (prod_id, prod_name, brand, category, stock, size, description, date_insert)
                        VALUES (@prodID, @prodName, @brand, @cat, @stock, @size, @des, @date)";

            using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
            {
                insertCmd.Parameters.AddWithValue("@ID", getID);
                insertCmd.Parameters.AddWithValue("@prodID", row["prod_id"]);
                insertCmd.Parameters.AddWithValue("@prodName", row["prod_name"]);
                insertCmd.Parameters.AddWithValue("@brand", row["brand"]);
                insertCmd.Parameters.AddWithValue("@cat", row["category"]);
                insertCmd.Parameters.AddWithValue("@stock", row["stock"]);
                insertCmd.Parameters.AddWithValue("@size", row["size"]);
                insertCmd.Parameters.AddWithValue("@des", row["description"]);
                insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                insertCmd.ExecuteNonQuery();
            }
        }
    }
}
