using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SmileSunshineToy.Utilities
{
    public static class GridViewImageHelper
    {
        /// <summary>
        /// 显示选中行的图片和信息（自动处理列名异常）
        /// </summary>
        public static void ShowSelectedRowImage(DataGridView gridView, string imageColumn, params string[] infoColumns)
        {
            try
            {
                // 参数校验
                if (gridView == null) throw new ArgumentNullException(nameof(gridView));
                if (string.IsNullOrWhiteSpace(imageColumn)) throw new ArgumentException("图片列名不能为空");

                // 检查选中行
                if (gridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请先选择一行数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 验证列是否存在
                if (!gridView.Columns.Contains(imageColumn))
                {
                    throw new ArgumentException($"未找到列: {imageColumn}");
                }

                DataGridViewRow row = gridView.SelectedRows[0];

                // 创建详情窗口
                using (Form detailForm = new Form()
                {
                    Text = "产品详情",
                    Size = new Size(600, 500),
                    StartPosition = FormStartPosition.CenterParent
                })
                using (PictureBox pictureBox = new PictureBox()
                {
                    Dock = DockStyle.Top,
                    Height = 300,
                    SizeMode = PictureBoxSizeMode.Zoom
                })
                using (TextBox textBox = new TextBox()
                {
                    Dock = DockStyle.Fill,
                    Multiline = true,
                    ReadOnly = true,
                    ScrollBars = ScrollBars.Vertical
                })
                {
                    // 加载图片
                    LoadImage(row.Cells[imageColumn].Value, pictureBox);

                    // 加载信息
                    textBox.Text = BuildInfoText(row, infoColumns);

                    // 添加控件并显示
                    detailForm.Controls.Add(textBox);
                    detailForm.Controls.Add(pictureBox);
                    detailForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"操作失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadImage(object cellValue, PictureBox pictureBox)
        {
            try
            {
                if (cellValue == null) return;

                if (cellValue is Image img)
                {
                    pictureBox.Image = new Bitmap(img);
                }
                else if (cellValue is byte[] bytes)
                {
                    using (var ms = new MemoryStream(bytes))
                    {
                        pictureBox.Image = new Bitmap(ms);
                    }
                }
                else if (cellValue is string path && File.Exists(path))
                {
                    pictureBox.Image = new Bitmap(path);
                }
            }
            catch
            {
                pictureBox.Image = CreatePlaceholderImage("图片加载失败");
            }
        }

        private static string BuildInfoText(DataGridViewRow row, string[] infoColumns)
        {
            var infoText = new System.Text.StringBuilder();
            foreach (string col in infoColumns)
            {
                if (row.Cells[col].Value != null)
                {
                    infoText.AppendLine($"{col}: {row.Cells[col].Value}");
                }
            }
            return infoText.ToString();
        }

        private static Bitmap CreatePlaceholderImage(string text)
        {
            var bmp = new Bitmap(300, 300);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString(text,
                    new Font("微软雅黑", 12),
                    Brushes.Black,
                    new RectangleF(10, 10, 280, 280),
                    new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
            }
            return bmp;
        }
    }
}