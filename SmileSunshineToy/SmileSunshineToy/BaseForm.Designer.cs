// BaseForm.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SmileSunshineToy
{
    public partial class BaseForm : Form
    {
        private Size _designSize;
        private Dictionary<Control, Rectangle> _controlPositions = new Dictionary<Control, Rectangle>();

        public BaseForm()
        {
            InitializeComponent(); // 调用设计器生成的方法
            this.MinimumSize = new Size(800, 600);
            this.Load += BaseForm_Load;
            this.Resize += BaseForm_Resize;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            // 如果未设置设计尺寸，使用窗体当前尺寸
            if (_designSize.IsEmpty)
            {
                _designSize = this.Size;
            }

            RecordControlPositions(this);
        }

        private void BaseForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            ResizeControls();
        }

        protected void SetDesignSize(Size size)
        {
            _designSize = size;
        }

        private void RecordControlPositions(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // 排除窗体和特殊控件
                if (control == this || control is MdiClient)
                    continue;

                _controlPositions[control] = new Rectangle(control.Location, control.Size);

                if (control.HasChildren)
                {
                    RecordControlPositions(control);
                }
            }
        }

        private void ResizeControls()
        {
            if (_controlPositions.Count == 0 || _designSize.IsEmpty)
                return;

            float scaleX = (float)this.ClientSize.Width / _designSize.Width;
            float scaleY = (float)this.ClientSize.Height / _designSize.Height;

            // 设置缩放限制 (50%-200%)
            scaleX = Math.Max(0.5f, Math.Min(scaleX, 2.0f));
            scaleY = Math.Max(0.5f, Math.Min(scaleY, 2.0f));

            foreach (var entry in _controlPositions)
            {
                Control control = entry.Key;
                Rectangle original = entry.Value;

                // 计算新位置和尺寸
                int newX = (int)(original.X * scaleX);
                int newY = (int)(original.Y * scaleY);
                int newWidth = (int)(original.Width * scaleX);
                int newHeight = (int)(original.Height * scaleY);

                // 应用新位置和尺寸
                control.SuspendLayout();
                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
                control.ResumeLayout();

                // 调整字体大小
                AdjustFontSize(control, Math.Min(scaleX, scaleY));

                // 特殊控件处理
                HandleSpecialControls(control, scaleX);
            }
        }

        private void AdjustFontSize(Control control, float scale)
        {
            // 跳过不需要字体缩放的控件
            if (control is DataGridView || control is ListView || control is TreeView || control is TabControl)
                return;

            if (control.Font != null)
            {
                float fontSize = control.Font.Size * scale;
                if (fontSize > 6 && fontSize < 24) // 限制字体大小范围
                {
                    control.Font = new Font(control.Font.FontFamily, fontSize, control.Font.Style);
                }
            }
        }

        private void HandleSpecialControls(Control control, float scaleX)
        {
            // 处理DataGridView列宽
            if (control is DataGridView dgv)
            {
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Width = (int)(column.Width * scaleX);
                }
            }

            // 处理ListView列宽
            if (control is ListView lv && lv.View == View.Details)
            {
                foreach (ColumnHeader column in lv.Columns)
                {
                    column.Width = (int)(column.Width * scaleX);
                }
            }

            // 处理TabControl
            if (control is TabControl tabControl)
            {
                foreach (TabPage tabPage in tabControl.TabPages)
                {
                    AdjustFontSize(tabPage, scaleX);
                }
            }
        }
    }
}