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
    
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            

            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                       

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            connect.Close();
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim()
                                    + "is already taken", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if(register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed"
                                    , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else if(register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Password does not match."
                                    , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date)" +
                                    "VALUES (@usern, @pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    connect.Open();
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    connect.Close();

                                    MessageBox.Show("Registered successfully!"
                                    , "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();

                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex
                                    , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
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
    }
}
