using System;
using System.Drawing;
using System.Windows.Forms;
using SmileSunshineToy.Utilities;

namespace SmileSunshineToy
{
    public partial class ProductDetailForm : Form
    {
        private readonly string _productId;
        private Image _currentImage;

        public ProductDetailForm(string productId, string productName, string description)
        {
            InitializeComponent();
            _productId = productId;

            // 初始化界面
            lblProductId.Text = $"产品ID: {productId}";
            lblProductName.Text = productName;
            txtDescription.Text = description;

            LoadProductImage();
        }

        private void LoadProductImage()
        {
            // 直接创建 ProductImageManager（用默认连接字符串）
            using (var imageManager = ProductImageManager.CreateDefault())
            {
                try
                {
                    _currentImage = imageManager.GetImageFromDb(_productId);
                    pictureBoxProduct.Image = _currentImage ?? GetDefaultImage();
                }
                catch (Exception ex)
                {
                    FormNavigationManager.ShowError($"图片加载失败: {ex.Message}");
                    pictureBoxProduct.Image = GetDefaultImage();
                }
            }
        }

        private Image GetDefaultImage()
        {
            return Properties.Resources.DefaultProductImage ??
                   SystemIcons.WinLogo.ToBitmap();
        }

        // 其他事件（如上传）如果需要保存图片，也局部创建：
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var image = Image.FromFile(openDialog.FileName))
                        using (var imageManager = ProductImageManager.CreateDefault())
                        {
                            // 保存图片到数据库
                            imageManager.SaveImageToDb(_productId, image);
                            // 更新界面
                            _currentImage?.Dispose();
                            _currentImage = new Bitmap(image);
                            pictureBoxProduct.Image = _currentImage;
                            FormNavigationManager.ShowInformation("图片上传成功");
                        }
                    }
                    catch (Exception ex)
                    {
                        FormNavigationManager.ShowError($"上传失败: {ex.Message}");
                    }
                }
            }
        }

        // 窗体关闭时释放图片
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _currentImage?.Dispose();
        }
    }
}