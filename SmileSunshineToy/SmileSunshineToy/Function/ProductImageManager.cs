using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy.Utilities
{
    public class ProductImageManager : IDisposable
    {
        private readonly string _connectionString;
        private bool _disposed; // 标记是否已释放

        public ProductImageManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// 保存图片到数据库 (支持所有ImageFormat)
        /// </summary>
        public void SaveImageToDb(string productId, Image image, ImageFormat format = null)
        {
            // 调用前检查是否已释放
            if (_disposed) throw new ObjectDisposedException(nameof(ProductImageManager));

            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(
                    "UPDATE product SET image_data=@data, image_type=@type WHERE ProductID=@id",
                    conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.Parameters.AddWithValue("@data", ImageToBytes(image, format ?? ImageFormat.Jpeg));
                    cmd.Parameters.AddWithValue("@type", GetMimeType(format));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 从数据库获取图片 (兼容string和int类型的ID)
        /// </summary>
        public Image GetImageFromDb(string productId)
        {
            // 调用前检查是否已释放
            if (_disposed) throw new ObjectDisposedException(nameof(ProductImageManager));

            return GetImageById(productId);
        }

        /// <summary>
        /// 图片转字节数组 (可指定格式)
        /// </summary>
        private byte[] ImageToBytes(Image image, ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 字节数组转图片 (自动释放资源)
        /// </summary>
        private Image BytesToImage(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        // 私有方法：统一处理图片查询
        private Image GetImageById(object productId)
        {
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "SELECT image_data FROM product WHERE ProductID=@id",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read() && !reader.IsDBNull(0))
                            {
                                return BytesToImage((byte[])reader["image_data"]);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"图片加载失败: {ex.Message}");
                return null;
            }
        }

        // 获取图片MIME类型
        private string GetMimeType(ImageFormat format)
        {
            if (format == ImageFormat.Jpeg) return "image/jpeg";
            if (format == ImageFormat.Png) return "image/png";
            if (format == ImageFormat.Gif) return "image/gif";
            return "application/octet-stream";
        }

        // 在 ProductImageManager 类中新增
        public static ProductImageManager CreateDefault()
        {
            // 假设 Configuration.ConnectionString 是你项目里的连接字符串
            return new ProductImageManager(Configuration.ConnectionString);
        }
        // 如果你还没统一配置类，也可以直接写死（但不推荐）：
        // return new ProductImageManager("server=...;database=...;uid=...;pwd=...");

        #region IDisposable 实现
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // 这里可释放托管资源（如果有），但当前类主要用 using 管理资源，无需额外操作
                }

                // 标记为已释放
                _disposed = true;
            }
        }

        // 可选：析构函数（防止忘记调用 Dispose）
        ~ProductImageManager()
        {
            Dispose(false);
        }
        #endregion
    }
}