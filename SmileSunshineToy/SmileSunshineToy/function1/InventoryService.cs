using System;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy.Inventory
{
    public class InventoryService : IDisposable
    {
        private readonly MySqlConnection _connection;

        public InventoryService()
        {
            _connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=;");
            _connection.Open();
        }

        public void RecordStockIn(string productId, int quantity)
        {
            string query = "INSERT INTO stock_log (product_id, quantity) VALUES (@pid, @qty)";
            using (var cmd = new MySqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@pid", productId);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.ExecuteNonQuery();
            }
        }

        public void Dispose()
        {
            _connection?.Close();
        }
    }
}