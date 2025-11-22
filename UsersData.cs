using Microsoft.Data.SqlClient;

namespace inventoryManagentSystem
{
    internal class UsersData
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection connect = new SqlConnection(
                "Server=LAPTOP-E6DHJ1I3\\SQLEXPRESS;Database=inventory;Trusted_Connection=true;TrustServerCertificate=true;"))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData uData = new UsersData
                        {
                            ID = (int)reader["id"],
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        listData.Add(uData);
                    }
                }
            }

            return listData;
        }

    }
}
