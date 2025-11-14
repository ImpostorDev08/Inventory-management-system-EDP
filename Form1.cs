using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace inventoryManagentSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;");
        public Form1()
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
                            Form2 menu = new Form2();

                            menu.Show();
                            this.Hide();
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
                    MessageBox.Show("Connection failed" + ex,"Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            registerform.Show();

            this.Hide();
        }
    }
}
