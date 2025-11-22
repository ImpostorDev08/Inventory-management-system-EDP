using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace inventoryManagentSystem
{
    internal class AddProductData
    {
        public int ID { get; set; }
        public string prod_id { get; set; }
        public string prod_name { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public int stock { get; set; }
        public int size { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public List<AddProductData> AllProductData()
        {
            List<AddProductData> listData = new List<AddProductData>();

            using (SqlConnection connect = new SqlConnection(
                "Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;"))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductData apData = new AddProductData
                        {
                            ID = (int)reader["id"],
                            prod_id = reader["prod_id"].ToString(),
                            prod_name = reader["prod_name"].ToString(),
                            brand = reader["brand"].ToString(),
                            category = reader["category"].ToString(),
                            stock = (int)reader["stock"],
                            size = (int)reader["size"],
                            description = reader["description"].ToString(),
                            date = reader["date_insert"].ToString()
                        };
                        listData.Add(apData);
                    }
                }
            }

            return listData;
        }
    }
}
