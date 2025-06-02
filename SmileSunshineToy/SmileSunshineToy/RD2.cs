using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RD2 : Form
    {
        public RD2()
        {
            InitializeComponent();
            InitializeFormData();
        }

        private void InitializeFormData()
        {
            // 初始化下拉框数据
            comboBoxManager.Items.AddRange(new string[] { "张三", "李四", "王五", "赵六" });
            comboBoxManager.SelectedIndex = 0;

            comboBoxCustomer.Items.AddRange(new string[] { "客户A", "客户B", "客户C", "客户D" });
            comboBoxCustomer.SelectedIndex = 0;

            comboBoxTestResult.Items.AddRange(new string[] { "通过", "不通过", "待测试" });
            comboBoxTestResult.SelectedIndex = 0;

            // 设置默认值
            textBoxProjectID.Text = "202504050001";
            textBoxStatus.Text = "Pending";

            // 初始化表格数据
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // 清空现有数据
            dataGridViewPrototype.Rows.Clear();

            // 添加示例数据
            dataGridViewPrototype.Rows.Add("001", "产品原型1", "V1.0", "已完成", "2025-04-01", "查看");
            dataGridViewPrototype.Rows.Add("002", "产品原型2", "V1.1", "进行中", "2025-04-15", "查看");
            dataGridViewPrototype.Rows.Add("003", "产品原型3", "V0.9", "待测试", "2025-05-20", "查看");
            dataGridViewPrototype.Rows.Add("004", "产品原型4", "V1.2", "已提交", "2025-05-25", "查看");
            dataGridViewPrototype.Rows.Add("005", "产品原型5", "V0.8", "待审核", "2025-06-01", "查看");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("数据已成功保存！", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(textBoxProjectID.Text))
            {
                MessageBox.Show("请输入项目ID", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxProjectID.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxSchemeName.Text))
            {
                MessageBox.Show("请输入方案名称", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSchemeName.Focus();
                return false;
            }

            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                MessageBox.Show("结束日期不能早于开始日期", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerEnd.Focus();
                return false;
            }

            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加新产品原型功能将在后续版本中实现", "功能开发中",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件 (*.xlsx)|*.xlsx|CSV文件 (*.csv)|*.csv";
            saveFileDialog.Title = "导出项目数据";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"数据已成功导出到 {saveFileDialog.FileName}", "导出成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要取消当前操作吗？未保存的更改将丢失。", "确认取消",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InitializeFormData(); // 重置表单
            }
        }

        private void buttonSubmitApproval_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DialogResult result = MessageBox.Show("确定要提交此项目进行审批吗？", "确认提交",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    textBoxStatus.Text = "Submitted";
                    MessageBox.Show("项目已成功提交审批！", "提交成功",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("生成报告功能将在后续版本中实现", "功能开发中",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出系统吗？", "确认退出",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridViewPrototype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // 检查是否是操作列
            {
                string prototypeId = dataGridViewPrototype.Rows[e.RowIndex].Cells[0].Value.ToString();
                string prototypeName = dataGridViewPrototype.Rows[e.RowIndex].Cells[1].Value.ToString();

                MessageBox.Show($"查看产品原型 {prototypeId} ({prototypeName}) 的详细信息",
                    "查看详情", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}