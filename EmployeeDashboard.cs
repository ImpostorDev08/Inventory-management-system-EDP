using Microsoft.Data.SqlClient;
using System.Data;

namespace inventoryManagentSystem
{
    public partial class EmployeeDashboard : Form
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public EmployeeDashboard()
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

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            displayAllProducts();
        }

        public void displayAllProducts()
        {
            AddProductData apData = new AddProductData();
            List<AddProductData> listData = apData.AllProductData();
            dataGridView2.DataSource = listData;
        }

        private int getID = 0;

        private void productupdate_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Update Product stock?",
               "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();


                        string updateData = "UPDATE products SET stock = @stock WHERE id = @id";

                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                            updateD.Parameters.AddWithValue("@stock", int.Parse(stock.Text.Trim()));
                            updateD.Parameters.AddWithValue("@id", getID);

                            updateD.ExecuteNonQuery();
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
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                stock.Text = row.Cells[5].Value.ToString();

            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();

                this.Hide();
            }
        }
    }
}
