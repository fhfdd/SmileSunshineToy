using System;
using System.Windows.Forms;

public class SelectionHandler
{
    private bool _userHasManuallySelected;
    private DataGridView _attachedGrid;
    private Action<string> _selectionCallback;
    private string _targetColumnName;

    /// <summary>
    /// 初始化选择处理器
    /// </summary>
    /// <param name="grid">关联的DataGridView控件</param>
    /// <param name="callback">选择回调方法</param>
    /// <param name="columnName">目标列名</param>
    public SelectionHandler(DataGridView grid, Action<string> callback, string columnName = "")
    {
        if (grid == null)
            throw new ArgumentNullException(nameof(grid));
        if (callback == null)
            throw new ArgumentNullException(nameof(callback));

        _attachedGrid = grid;
        _selectionCallback = callback;
        _targetColumnName = string.IsNullOrEmpty(columnName) ? grid.Columns[0].Name : columnName;

        // 注册事件
        _attachedGrid.SelectionChanged += Grid_SelectionChanged;
        _attachedGrid.MouseDown += Grid_MouseDown;
        _attachedGrid.DataBindingComplete += Grid_DataBindingComplete;
    }

    /// <summary>
    /// 处理选择变化事件
    /// </summary>
    private void Grid_SelectionChanged(object sender, EventArgs e)
    {
        if (_userHasManuallySelected && _attachedGrid.SelectedRows.Count > 0)
        {
            var selectedValue = _attachedGrid.SelectedRows[0].Cells[_targetColumnName].Value?.ToString() ?? "";
            _selectionCallback(selectedValue);
        }
    }

    /// <summary>
    /// 标记手动选择开始
    /// </summary>
    private void Grid_MouseDown(object sender, MouseEventArgs e)
    {
        _userHasManuallySelected = true;
    }

    /// <summary>
    /// 数据绑定完成后重置选择状态
    /// </summary>
    private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        ResetSelectionState();
    }

    /// <summary>
    /// 重置选择状态
    /// </summary>
    public void ResetSelectionState()
    {
        _userHasManuallySelected = false;
    }

    /// <summary>
    /// 手动触发选择处理
    /// </summary>
    public void ProcessCurrentSelection()
    {
        Grid_SelectionChanged(_attachedGrid, EventArgs.Empty);
    }

    /// <summary>
    /// 释放资源
    /// </summary>
    public void Dispose()
    {
        if (_attachedGrid != null)
        {
            _attachedGrid.SelectionChanged -= Grid_SelectionChanged;
            _attachedGrid.MouseDown -= Grid_MouseDown;
            _attachedGrid.DataBindingComplete -= Grid_DataBindingComplete;
            _attachedGrid = null;
        }
        _selectionCallback = null;
    }
}