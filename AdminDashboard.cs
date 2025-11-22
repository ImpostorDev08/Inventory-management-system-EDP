using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagentSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            adminManageProducts1.Hide();
            adminManageUser1.Hide();
            userAchiveData1.Hide();
            productArchiveData1.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            adminManageProducts1.Hide();
            adminManageUser1.Hide();
            userAchiveData1.Hide();
            productArchiveData1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminManageProducts1.Hide();
            userAchiveData1.Hide();
            productArchiveData1.Hide();
            adminManageUser1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminManageUser1.Hide();
            userAchiveData1.Hide();
            productArchiveData1.Hide();
            adminManageProducts1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminManageProducts1.Hide();
            adminManageUser1.Hide();
            productArchiveData1.Hide();
            userAchiveData1.Show();
        }


    }
}
