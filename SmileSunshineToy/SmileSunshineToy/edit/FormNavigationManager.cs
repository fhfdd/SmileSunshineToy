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