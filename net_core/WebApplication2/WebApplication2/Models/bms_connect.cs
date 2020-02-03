using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace WebApplication2.Models
{
    public class bms_connect
    {
        public string ConnectionString { get; set; }

        public bms_connect(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<bms> GetAllAlbums()
        {
            List<bms> list = new List<bms>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from bms where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new bms()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            ArtistName = reader["ArtistName"].ToString(),
                            Price = Convert.ToInt32(reader["Price"]),
                            Genre = reader["genre"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
