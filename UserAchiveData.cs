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
    public partial class UserAchiveData : UserControl
    {
        public UserAchiveData()
        {
            InitializeComponent();
        }

        private void productarchive_btn_Click(object sender, EventArgs e)
        {
            displayArchivedUsers();
        }

        private void UserAchiveData_Load(object sender, EventArgs e)
        {
            displayArchivedUsers();
        }
        public void displayArchivedUsers()
        {
            ArchivedUserData auData = new ArchivedUserData();
            List<ArchivedUserData> listData = auData.AllUsersData();
            dataGridView2.DataSource = listData;
        }
    }
}
