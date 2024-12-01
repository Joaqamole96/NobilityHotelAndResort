using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace HotelAndResort.Models.Data
{
    public static class DatabaseHelper
    {
        public static string connectionString = 
            "Server = localhost;" +
            "Database = nobilityhotelandresort_db;" +
            "User ID = 'root';" +
            "Password = '';" +
            "Pooling = true;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static void Initialize()
        {
            try
            {
                string query = File.ReadAllText(@"..\..\Models\Data\.sql\init.sql");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error selecting records: {ex.Message}", ex);
            }
        }

        public static DataTable Select(string query)
        {
            DataTable resultTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error selecting records: {ex.Message}", ex);
            }

            return resultTable;
        }
    }
}
