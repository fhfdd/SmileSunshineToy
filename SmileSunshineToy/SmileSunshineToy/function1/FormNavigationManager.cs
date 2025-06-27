using System;
using System.Windows.Forms;

public static class FormNavigationManager
{
    /// <summary>
    /// 导航到指定窗体
    /// </summary>
    /// <param name="currentForm">当前窗体</param>
    /// <param name="formType">目标窗体类型</param>
    /// <param name="closeCurrent">是否关闭当前窗体</param>
    /// 
    /// <summary>
    /// 显示带选项的对话框并返回用户选择
    /// </summary>
    /// <param name="message">对话框消息</param>
    /// <param name="title">对话框标题</param>
    /// <param name="options">可选按钮</param>
    /// <param name="defaultSelection">默认选中的按钮</param>
    /// <returns>用户选择的按钮</returns>
    public static DialogResult ShowDialog(
        string message,
        string title = "对话框",
        MessageBoxButtons options = MessageBoxButtons.OK,
        MessageBoxIcon icon = MessageBoxIcon.Information)
    {
        return MessageBox.Show(message, title, options, icon);
    }

    /// <summary>
    /// 显示带选项的对话框并返回用户选择（字符串数组选项）
    /// </summary>
    /// <param name="message">对话框消息</param>
    /// <param name="title">对话框标题</param>
    /// <param name="options">选项列表</param>
    /// <param name="defaultOption">默认选项</param>
    /// <returns>用户选择的选项文本</returns>
    public static string ShowDialog(
        string message,
        string title,
        string[] options,
        string defaultOption = null)
    {
        // 创建带选项的自定义对话框（简化实现，实际项目中可使用自定义窗体）
        using (var dialog = new Form())
        {
            dialog.Text = title;
            dialog.Size = new System.Drawing.Size(400, 200);
            dialog.StartPosition = FormStartPosition.CenterScreen;

            // 添加标签显示消息
            var label = new Label
            {
                Text = message,
                Location = new System.Drawing.Point(20, 20),
                Width = 360,
                Height = 60
            };
            dialog.Controls.Add(label);

            // 添加按钮
            int buttonWidth = 80;
            int buttonHeight = 30;
            int startX = (dialog.Width - (options.Length * buttonWidth + (options.Length - 1) * 10)) / 2;
            int y = 100;

            string selectedOption = defaultOption;

            foreach (string option in options)
            {
                var button = new Button
                {
                    Text = option,
                    Location = new System.Drawing.Point(startX, y),
                    Width = buttonWidth,
                    Height = buttonHeight
                };

                button.Click += (s, e) =>
                {
                    selectedOption = option;
                    dialog.Close();
                };

                dialog.Controls.Add(button);
                startX += buttonWidth + 10;
            }

            dialog.FormClosing += (s, e) => dialog.Dispose();
            dialog.ShowDialog();
            return selectedOption;
        }
    }
    public static void NavigateToForm(Form currentForm, Type formType, bool closeCurrent = false)
    {
        if (currentForm == null || formType == null || !typeof(Form).IsAssignableFrom(formType))
        {
            return;
        }

        try
        {
            // 创建新窗体实例
            Form newForm = (Form)Activator.CreateInstance(formType);

            // 显示新窗体
            newForm.Show();

            // 处理当前窗体
            if (closeCurrent)
            {
                currentForm.Close();
            }
            else
            {
                currentForm.Hide();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"无法打开窗体: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// 显示确认对话框
    /// </summary>
    /// <param name="message">确认消息</param>
    /// <param name="title">对话框标题</param>
    /// <returns>用户是否确认</returns>
    public static bool ShowConfirmation(string message, string title = "确认")
    {
        return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    /// <summary>
    /// 显示信息提示
    /// </summary>
    /// <param name="message">提示消息</param>
    /// <param name="title">对话框标题</param>
    public static void ShowInformation(string message, string title = "提示")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    /// 显示错误提示
    /// </summary>
    /// <param name="message">错误消息</param>
    /// <param name="title">对话框标题</param>
    public static void ShowError(string message, string title = "错误")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// 确认退出登录
    /// </summary>
    /// <returns>用户是否确认退出</returns>
    public static bool ConfirmLogout()
    {
        return ShowConfirmation("确定要退出登录吗？", "退出登录确认");
    }

    /// <summary>
    /// 关闭应用程序
    /// </summary>
    public static void ExitApplication()
    {
        Application.Exit();
    }
}