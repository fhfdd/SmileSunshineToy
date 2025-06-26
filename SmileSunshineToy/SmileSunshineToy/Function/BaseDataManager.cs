using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SmileSunshineToy
{
    public class BaseDataManager
    {
        private static readonly object _idLock = new object();
        public string ConnectionString { get; set; } = "Server=localhost;Database=test;Uid=root;Pwd=;";
        public string TableName { get; set; }
        public string PrimaryKey { get; set; }
        public string IDPrefix { get; set; }

        public BaseDataManager(string tableName, string primaryKey, string idPrefix = "")
        {
            TableName = tableName;
            PrimaryKey = primaryKey;
            IDPrefix = idPrefix;
        }

        public string GenerateSystemID()
        {
            lock (_idLock)
            {
                string datePart = DateTime.Now.ToString("yyyyMMdd");
                string randomPart = Guid.NewGuid().ToString("N").Substring(0, 8);
                return $"{IDPrefix}-{datePart}-{randomPart}";
            }
        }
        public bool SaveChanges(DataTable dataTable)
        {
            DataTable changes = dataTable.GetChanges();
            if (changes == null || changes.Rows.Count == 0) return false;

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (DataRow row in changes.Rows)
                        {
                            if (row.RowState == DataRowState.Added)
                            {
                                InsertRow(conn, trans, row);
                            }
                            else if (row.RowState == DataRowState.Modified)
                            {
                                UpdateRow(conn, trans, row);
                            }
                            else if (row.RowState == DataRowState.Deleted)
                            {
                                DeleteRow(conn, trans, row);
                            }
                        }
                        trans.Commit();
                        return true;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        private void InsertRow(MySqlConnection conn, MySqlTransaction trans, DataRow row)
        {
            string columns = string.Join(",", GetColumnNames(row.Table, name => $"`{name}`"));
            string values = string.Join(",", GetColumnNames(row.Table, name => $"@{name}"));
            string query = $"INSERT INTO `{TableName}` ({columns}) VALUES ({values})";
            var cmd = new MySqlCommand(query, conn, trans);

            foreach (DataColumn col in row.Table.Columns)
            {
                cmd.Parameters.AddWithValue($"@{col.ColumnName}", row[col]);
            }
            cmd.ExecuteNonQuery();
        }

        private void UpdateRow(MySqlConnection conn, MySqlTransaction trans, DataRow row)
        {
            string setClause = string.Join(",", GetColumnNames(row.Table, name => $"`{name}`=@{name}"));
            string query = $"UPDATE `{TableName}` SET {setClause} WHERE `{PrimaryKey}`=@pk";
            var cmd = new MySqlCommand(query, conn, trans);

            foreach (DataColumn col in row.Table.Columns)
            {
                cmd.Parameters.AddWithValue($"@{col.ColumnName}", row[col]);
            }
            cmd.Parameters.AddWithValue("@pk", row[PrimaryKey, DataRowVersion.Original]);
            cmd.ExecuteNonQuery();
        }

        private void DeleteRow(MySqlConnection conn, MySqlTransaction trans, DataRow row)
        {
            string query = $"DELETE FROM `{TableName}` WHERE `{PrimaryKey}`=@pk";
            var cmd = new MySqlCommand(query, conn, trans);
            cmd.Parameters.AddWithValue("@pk", row[PrimaryKey, DataRowVersion.Original]);
            cmd.ExecuteNonQuery();
        }

        private string[] GetColumnNames(DataTable table, Func<string, string> format = null)
        {
            format = format ?? (name => name);
            var names = new string[table.Columns.Count];

            for (int i = 0; i < table.Columns.Count; i++)
            {
                names[i] = format(table.Columns[i].ColumnName);
            }
            return names;
        }
    }
}