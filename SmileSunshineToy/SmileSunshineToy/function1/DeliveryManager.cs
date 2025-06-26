using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient; 

namespace SmileSunshineToy.Logistics
{
    public class DeliveryManager : IDisposable
    {
        private MySqlConnection _connection;

        public DeliveryManager()
        {
            _connection = new MySqlConnection(
                "Server=localhost;Database=test;Uid=root;Pwd=;");
            _connection.Open();

            using (var cmd = new MySqlCommand(
                "CREATE TABLE IF NOT EXISTS order_details (" +
                "order_id VARCHAR(20), product_name VARCHAR(50), quantity INT)",
                _connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public string GenerateDeliveryNote(string orderId)
        {
            string txtPath = $"DeliveryNote_{orderId}.txt";

            using (var cmd = new MySqlCommand(
                "SELECT product_name, quantity FROM order_details WHERE order_id=@id",
                _connection))
            {
                cmd.Parameters.AddWithValue("@id", orderId);

                using (var reader = cmd.ExecuteReader())
                {
                    File.WriteAllText(txtPath, $"=== 送货单 {orderId} ===\n");
                    while (reader.Read())
                    {
                        File.AppendAllText(txtPath,
                            $"{reader["product_name"]} x {reader["quantity"]}\n");
                    }
                }
            }
            return txtPath;
        }

        public void Dispose() => _connection?.Close();
    }
}