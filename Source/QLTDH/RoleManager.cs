using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    internal class RoleManager
    {
        public static bool HasRole(OracleConnection connection, string role)
        {
            if (connection == null || connection.State != ConnectionState.Open)
            {
                throw new ArgumentException("Kết nối không được mở.");
            }

            string query = "SELECT 1 FROM SESSION_ROLES WHERE ROLE = :role";
            OracleCommand cmd = new OracleCommand(query, connection);
            cmd.Parameters.Add(new OracleParameter("role", role));

            object result = cmd.ExecuteScalar();
            return result != null;
        }
    }
}
