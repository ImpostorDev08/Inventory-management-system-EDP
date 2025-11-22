using Microsoft.Data.SqlClient;
using System.Data;

namespace inventoryManagentSystem
{
    public partial class AdminManageUser : UserControl
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public AdminManageUser()
        {
            InitializeComponent();
        }
        private void AdminManageUser_Load(object sender, EventArgs e)
        {
            displayAllUsersData();
        }

        public void displayAllUsersData()
        {
            UsersData uData = new UsersData();

            List<UsersData> listData = uData.AllUsersData();

            dataGridView1.DataSource = listData;
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
        private void addUsers_addbtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_username.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {

                            cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addUsers_username.Text.Trim()
                                    + " is already taken ", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date) " +
                                    "VALUES (@usern, @pass, @role, @status, @date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllUsersData();

                                    MessageBox.Show("Added successfully", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }
        private void addUsers_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updatebtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_username.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update User ID: " + getID + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem);
                                updateD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayAllUsersData();
                                clearFields();

                                MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();
                string role = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();

                addUsers_username.Text = username;
                addUsers_password.Text = password;
                addUsers_role.Text = role;
                addUsers_status.Text = status;
            }
        }

        private void addUsers_archivebtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_username.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Archive User ID: " + getID + "?",
                    "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            
                            connect.Open();
                            inserttoarchive();


                            string archiveData = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand archiveD = new SqlCommand(archiveData, connect))
                            {
                                archiveD.Parameters.AddWithValue("@id", getID);
                                archiveD.ExecuteNonQuery();

                                clearFields();
                                displayAllUsersData();

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
        public void inserttoarchive()
        {
            string selectData = "SELECT username, password, role, status FROM users WHERE id = @id";

            DataTable productTable = new DataTable();
            using (SqlCommand selectCmd = new SqlCommand(selectData, connect))
            {
                selectCmd.Parameters.AddWithValue("@id", getID);
                SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);
                adapter.Fill(productTable);
            }

            DataRow row = productTable.Rows[0];

            string insertData = @"INSERT INTO archivedusers (username, password, role, status, date) " +
                "VALUES (@usern, @pass, @role, @status, @date)";

            using (SqlCommand insertD = new SqlCommand(insertData, connect))
            {
                insertD.Parameters.AddWithValue("@ID", getID);
                insertD.Parameters.AddWithValue("@usern", row["username"]);
                insertD.Parameters.AddWithValue("@pass", row["password"]);
                insertD.Parameters.AddWithValue("@role", row["role"]);
                insertD.Parameters.AddWithValue("@status", row["status"]);
                insertD.Parameters.AddWithValue("@date", DateTime.Now);

                insertD.ExecuteNonQuery();
            }
        }
    }
}
