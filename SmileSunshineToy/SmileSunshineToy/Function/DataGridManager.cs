using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy
{
    public class DataGridManager
    {
        private readonly BaseDataManager _baseManager;
        public DataTable DataTable { get; private set; }

        // 添加必要的属性
        public string TableName => _baseManager.TableName;
        public string PrimaryKey => _baseManager.PrimaryKey;

        public DataGridManager(string tableName, string primaryKey, string idPrefix = "")
        {
            _baseManager = new BaseDataManager(tableName, primaryKey, idPrefix);
            DataTable = new DataTable();
        }

        // 添加连接字符串设置
        public void SetConnectionString(string connectionString)
        {
            _baseManager.ConnectionString = connectionString;
        }

        public DataTable LoadData()
        {
            using (var conn = new MySqlConnection(_baseManager.ConnectionString))
            {
                // 关键修改：表名用反引号包裹
                string query = $"SELECT * FROM `{_baseManager.TableName}`";
                var adapter = new MySqlDataAdapter(query, conn);

                DataTable.Clear();
                adapter.Fill(DataTable);
                return DataTable;
            }
        }

        // 添加搜索方法
        public DataTable SearchRecords(string searchText, string column)
        {
            using (var conn = new MySqlConnection(_baseManager.ConnectionString))
            {
                // 安全参数化查询
                string query = $"SELECT * FROM `{_baseManager.TableName}` WHERE `{column}` LIKE @search";
                var adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{searchText}%");

                DataTable result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }

        public bool AddRecord(bool autoGenerateID = true)
        {
            DataRow newRow = DataTable.NewRow();
            if (autoGenerateID && !string.IsNullOrEmpty(_baseManager.IDPrefix))
            {
                // 使用安全ID生成
                newRow[_baseManager.PrimaryKey] = _baseManager.GenerateSystemID();
            }
            DataTable.Rows.Add(newRow);
            return true;
        }

        public bool DeleteRecord(DataGridViewSelectedRowCollection selectedRows)
        {
            if (selectedRows.Count == 0) return false;

            // 添加事务安全删除
            using (var conn = new MySqlConnection(_baseManager.ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in selectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                // 使用参数化删除
                                string deleteQuery = $"DELETE FROM `{_baseManager.TableName}` WHERE `{_baseManager.PrimaryKey}` = @id";
                                var cmd = new MySqlCommand(deleteQuery, conn, trans);
                                cmd.Parameters.AddWithValue("@id", DataTable.Rows[row.Index][_baseManager.PrimaryKey]);
                                cmd.ExecuteNonQuery();

                                DataTable.Rows[row.Index].Delete();
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool SaveChanges()
        {
            return _baseManager.SaveChanges(DataTable);
        }

        // 添加新方法：加载特定表的数据
        public DataTable LoadGridData(string tableName, string idColumn = null, object idValue = null)
        {
            using (var conn = new MySqlConnection(_baseManager.ConnectionString))
            {
                string query = $"SELECT * FROM `{tableName}`";

                if (!string.IsNullOrEmpty(idColumn) && idValue != null)
                {
                    query += $" WHERE `{idColumn}` = @id";
                }

                var adapter = new MySqlDataAdapter(query, conn);

                if (!string.IsNullOrEmpty(idColumn) && idValue != null)
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", idValue);
                }

                DataTable result = new DataTable();
                adapter.Fill(result);
                return result;
            }
        }
    }
}