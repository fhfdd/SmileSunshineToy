using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmileSunshineToy.Utilities
{
    public class FileUploadManager
    {
        private readonly string _connectionString;

        public FileUploadManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        // 上传图片到数据库（存储为BLOB）
        public bool UploadProductImage(int productId, Image image)
        {
            if (image == null) return false;

            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    // 转换图片为字节数组
                    byte[] imageData;
                    using (var ms = new MemoryStream())
                    {
                        image.Save(ms, ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }

                    // 更新数据库
                    string sql = "UPDATE product SET image_data = @imageData, " +
                                 "image_type = @imageType WHERE productID = @productId";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@imageData", imageData);
                        cmd.Parameters.AddWithValue("@imageType", "image/jpeg");
                        cmd.Parameters.AddWithValue("@productId", productId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"图片上传失败: {ex.Message}", "错误",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // 从文件选择器中上传图片
        public Image SelectAndUploadImage(string productId)  // 修改为string类型
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (Image image = Image.FromFile(openFileDialog.FileName))
                        {
                            using (var conn = new MySqlConnection(_connectionString))
                            {
                                conn.Open();

                                using (var cmd = new MySqlCommand(
                                    "UPDATE product SET image_data = @data WHERE productID = @id",
                                    conn))
                                {
                                    cmd.Parameters.AddWithValue("@id", productId);  // 使用字符串参数
                                    cmd.Parameters.AddWithValue("@data", ImageToByteArray(image));

                                    int affectedRows = cmd.ExecuteNonQuery();
                                    if (affectedRows > 0)
                                    {
                                        return (Image)image.Clone();  // 返回新实例
                                    }
                                }
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"图片上传失败: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}