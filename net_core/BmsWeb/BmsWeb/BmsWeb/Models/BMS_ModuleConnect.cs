using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

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
        public String Getdata(string tsqlcommand)
        {
            string str_json = null;
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    //MySqlCommand cmd = new MySqlCommand(tsqlcommand, conn);

                    MySqlDataAdapter data = new MySqlDataAdapter(tsqlcommand, conn);

                    DataTable datatable = new DataTable();
                    data.Fill(datatable);
                    conn.Close();
                    str_json = JsonConvert.SerializeObject(datatable, Formatting.Indented);

                    conn.Close();
                    data.Dispose();
                    datatable.Dispose();
                }
                catch (Exception ex){ 
                
                }
                return str_json;
            }
        }
        public List<BMS_module> GetBMS_ModuleData(string tsqlcommand)
        {
            List<BMS_module> list = new List<BMS_module>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(tsqlcommand, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BMS_module()
                        {
                            datatime = Convert.ToDateTime(reader["datatime"]),
                            V1 = Math.Round( Convert.ToDouble(reader["V1"]),3),
                            V2 = Math.Round( Convert.ToDouble(reader["V2"]),3),
                            V3 = Math.Round( Convert.ToDouble(reader["V3"]),3),
                            V4 = Math.Round( Convert.ToDouble(reader["V4"]),3),
                            V5 = Math.Round( Convert.ToDouble(reader["V5"]),3),
                            V6 = Math.Round( Convert.ToDouble(reader["V6"]),3),
                            V7 = Math.Round( Convert.ToDouble(reader["V7"]),3),
                            V8 = Math.Round( Convert.ToDouble(reader["V8"]),3),
                            T1 = Math.Round( Convert.ToDouble(reader["T1"]),3),
                            T2 = Math.Round( Convert.ToDouble(reader["T2"]),3),
                            T3 = Math.Round( Convert.ToDouble(reader["T3"]),3),
                            T4 = Math.Round( Convert.ToDouble(reader["T4"]),3),
                            T5 = Math.Round( Convert.ToDouble(reader["T5"]),3),
                            T6 = Math.Round( Convert.ToDouble(reader["T6"]),3),
                            T7 = Math.Round( Convert.ToDouble(reader["T7"]),3),
                            T8 = Math.Round( Convert.ToDouble(reader["T8"]),3)
                        });
                    }
                }
            }            
            return list;
        }    
    }
}
