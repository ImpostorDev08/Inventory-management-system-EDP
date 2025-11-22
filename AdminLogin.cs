using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace inventoryManagentSystem
{
    public partial class AdminLogin : Form
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public AdminLogin()
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

        private void login_btn2_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM admins WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        cmd.Parameters.AddWithValue("@usern", login_username2.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password2.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminDashboard admindashboard = new AdminDashboard();

                            admindashboard.Show();
                            this.Hide();
                        }
                        else if (login_username2.Text == "" || login_password2.Text == "")
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
