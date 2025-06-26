using System;
using System.Data;

namespace SmileSunshineToy.Services
{
    public class AfterSalesService
    {
        private readonly DataTable _serviceRequests;

        public AfterSalesService()
        {
            // 内存表实现（无需数据库）
            _serviceRequests = new DataTable("ServiceRequests");
            _serviceRequests.Columns.Add("RequestID", typeof(string));
            _serviceRequests.Columns.Add("CustomerID", typeof(string));
            _serviceRequests.Columns.Add("Issue", typeof(string));
        }

        // 添加服务请求
        public string CreateRequest(string customerId, string issue)
        {
            string requestId = Guid.NewGuid().ToString();
            _serviceRequests.Rows.Add(requestId, customerId, issue);
            return requestId;
        }

        // 获取所有请求
        public DataTable GetRequests() => _serviceRequests.Copy();
    }
}