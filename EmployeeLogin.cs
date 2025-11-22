using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace inventoryManagentSystem
{
    public partial class EmployeeLogin : Form
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public EmployeeLogin()
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

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmployeeDashboard menu = new EmployeeDashboard();

                            menu.Show();
                            this.Hide();
                        }
                        else if (login_username.Text == "" || login_password.Text == "")
                        {
                            MessageBox.Show("Please fill all empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password or there's no Admin's approval",
                                "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
