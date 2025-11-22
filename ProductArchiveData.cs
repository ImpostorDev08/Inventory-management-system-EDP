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
    public partial class ProductArchiveData : UserControl
    {
        public ProductArchiveData()
        {
            InitializeComponent();
        }

        private void productarchive_btn_Click(object sender, EventArgs e)
        {
            displayArchivedProducts();
        }

        private void ProductArchiveData_Load(object sender, EventArgs e)
        {
            displayArchivedProducts();
        }

        public void displayArchivedProducts()
        {
            ArchivedProductData apData = new ArchivedProductData();
            List<ArchivedProductData> listData = apData.AllProductData();
            dataGridView2.DataSource = listData;
        }
    }
}
