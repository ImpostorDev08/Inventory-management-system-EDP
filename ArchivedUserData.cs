using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace inventoryManagentSystem
{
    internal class ArchivedUserData
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<ArchivedUserData> AllUsersData()
        {
            List<ArchivedUserData> listData = new List<ArchivedUserData>();

            using (SqlConnection connect = new SqlConnection(
                "Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;"))
            {
                connect.Open();

                string selectData = "SELECT * FROM archivedusers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ArchivedUserData auData = new ArchivedUserData
                        {
                            ID = (int)reader["id"],
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        listData.Add(auData);
                    }
                }
            }

            return listData;
        }
    }
}
