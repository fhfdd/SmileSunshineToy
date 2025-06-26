using SmileSunshineToy.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class ProductDetailForm : Form
    {
        private readonly string _productId;
        private Image _currentImage;
        private readonly FileUploadManager _fileUploadManager;
        private readonly ProductImageHelper _imageHelper;

        public ProductDetailForm(string productId, string productName, string description,
                                 FileUploadManager fileUploadManager,
                                 ProductImageHelper imageHelper)
        {
            InitializeComponent();
            _productId = productId;
            _fileUploadManager = fileUploadManager;
            _imageHelper = imageHelper;

            lblProductId.Text = $"产品ID: {productId}";
            lblProductName.Text = productName;
            txtDescription.Text = description;

            LoadProductImage();
        }

        private void LoadProductImage()
        {
            _currentImage = _imageHelper.GetProductImage(_productId);

            if (_currentImage != null)
            {
                pictureBoxProduct.Image = _currentImage;
            }
            else
            {
                pictureBoxProduct.Image = Properties.Resources.DefaultProductImage;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // 选择并上传新图片
            var newImage = _fileUploadManager.SelectAndUploadImage(_productId);

            if (newImage != null)
            {
                // 显示新图片并释放旧资源
                if (_currentImage != null && _currentImage != Properties.Resources.DefaultProductImage)
                {
                    _currentImage.Dispose();
                }

                _currentImage = newImage;
                pictureBoxProduct.Image = _currentImage;

                MessageBox.Show("图片上传成功!", "成功",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 释放图片资源
            if (_currentImage != null && _currentImage != Properties.Resources.DefaultProductImage)
            {
                _currentImage.Dispose();
            }
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}