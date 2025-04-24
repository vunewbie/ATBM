using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public static class ConnectionManager
    {
        // Lưu trữ thông tin username và password
        public static string Username { get; set; }
        public static string Password { get; set; }

        // Tạo chuỗi kết nối Oracle
        public static OracleConnection CreateConnection()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                throw new InvalidOperationException("Chưa có thông tin đăng nhập hợp lệ.");
            }

            string connectionString;
            connectionString = $"User Id={Username};Password={Password};Data Source=localhost:1521/QUANLYTRUONGDAIHOC;";

            OracleConnection connection = new OracleConnection(connectionString);
            return connection;
        }
    }
}

