using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using MySql.Data.MySqlClient;

public class ProductImageManager
{
    private readonly string _connectionString;

    public ProductImageManager(string connectionString)
    {
        _connectionString = connectionString;
    }

    // 保存图片到数据库
    public void SaveImageToDb(int productId, Image image)
    {
        using (var conn = new MySqlConnection(_connectionString))
        {
            conn.Open();

            using (var cmd = new MySqlCommand(
                "UPDATE product SET image_data = @data, image_type = @type WHERE ProductID = @id",
                conn))
            {
                cmd.Parameters.AddWithValue("@id", productId);
                cmd.Parameters.AddWithValue("@data", ImageToBytes(image));
                cmd.Parameters.AddWithValue("@type", "image/jpeg");

                cmd.ExecuteNonQuery();
            }
        }
    }

    // 从数据库读取图片
    public Image GetImageFromDb(int productId)
    {
        using (var conn = new MySqlConnection(_connectionString))
        {
            conn.Open();

            using (var cmd = new MySqlCommand(
                "SELECT image_data FROM product WHERE ProductID = @id",
                conn))
            {
                cmd.Parameters.AddWithValue("@id", productId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        byte[] data = (byte[])reader["image_data"];
                        return BytesToImage(data);
                    }
                }
            }
        }
        return null;
    }

    // 辅助方法：图片转字节数组
    private byte[] ImageToBytes(Image image)
    {
        using (var ms = new MemoryStream())
        {
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }

    // 辅助方法：字节数组转图片
    private Image BytesToImage(byte[] data)
    {
        using (var ms = new MemoryStream(data))
        {
            return Image.FromStream(ms);
        }
    }
}