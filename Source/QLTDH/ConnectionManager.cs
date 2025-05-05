using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            Username = "NVCB0001";
            Password = "NVCB0001";

            string connectionString;
            connectionString = $"User Id={Username};Password={Password};Data Source=localhost:1521/QUANLYTRUONGDAIHOC;";

            OracleConnection connection = new OracleConnection(connectionString);
            return connection;
        }
    }
}

