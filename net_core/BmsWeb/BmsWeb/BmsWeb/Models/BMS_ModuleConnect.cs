using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BmsWeb.Models
{
    public class BMS_ModuleConnect
    {
        public string ConnectionString { get; set; }
        public BMS_ModuleConnect(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<BMS_module> GetAllBMS_Module()
        {
            List<BMS_module> list = new List<BMS_module>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from module_data", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BMS_module()
                        {
                            datatime = Convert.ToDateTime(reader["datatiem"]),
                            V1 = Convert.ToDouble(reader["V1"]),
                            V2 = Convert.ToDouble(reader["V2"]),
                            V3 = Convert.ToDouble(reader["V3"]),
                            V4 = Convert.ToDouble(reader["V4"]),
                            V5 = Convert.ToDouble(reader["V5"]),
                            V6 = Convert.ToDouble(reader["V6"]),
                            V7 = Convert.ToDouble(reader["V7"]),
                            V8 = Convert.ToDouble(reader["V8"]),
                            T1 = Convert.ToDouble(reader["T1"]),
                            T2 = Convert.ToDouble(reader["T2"]),
                            T3 = Convert.ToDouble(reader["T3"]),
                            T4 = Convert.ToDouble(reader["T4"]),
                            T5 = Convert.ToDouble(reader["T5"]),
                            T6 = Convert.ToDouble(reader["T6"]),
                            T7 = Convert.ToDouble(reader["T7"]),
                            T8 = Convert.ToDouble(reader["T8"]),
                        });
                    }
                }
            }
            return list;
        }
    }
}
