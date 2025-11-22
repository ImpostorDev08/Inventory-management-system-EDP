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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void employeelogin_btn_Click(object sender, EventArgs e)
        {
            EmployeeLogin employee = new EmployeeLogin();
            employee.Show();
            this.Hide();
        }

        private void adminlogin_btn_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.Show();
            this.Hide();
        }
    }
}
