using System;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy.Utilities
{
    public class ProductImageHelper
    {
        private readonly string _connectionString;

        public ProductImageHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        // 从数据库获取产品图片
        public Image GetProductImage(string productId)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand(
                        "SELECT image_data FROM product WHERE productID = @id",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                byte[] data = (byte[])reader["image_data"];
                                return ByteArrayToImage(data);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"获取图片失败: {ex.Message}");
                return null;
            }
        }

        // 字节数组转Image
        private Image ByteArrayToImage(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"图片转换失败: {ex.Message}");
                return null;
            }
        }
    }
}