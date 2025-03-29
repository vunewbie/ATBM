using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Kiểm tra xem người dùng đã tồn tại
                    OracleCommand checkCmd = new OracleCommand("CHECK_USER_EXISTS", conn);
                    checkCmd.CommandType = CommandType.StoredProcedure;
                    checkCmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    OracleParameter existsParam = new OracleParameter("p_exists", OracleDbType.Varchar2, 10);
                    existsParam.Direction = ParameterDirection.Output;
                    checkCmd.Parameters.Add(existsParam);

                    checkCmd.ExecuteNonQuery();

                    string userExists = existsParam.Value.ToString();
                    if (userExists == "FALSE")
                    {
                        MessageBox.Show("Người dùng không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Xóa người dùng
                    OracleCommand deleteCmd = new OracleCommand("DELETE_USER", conn);
                    deleteCmd.CommandType = CommandType.StoredProcedure;
                    deleteCmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Người dùng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách người dùng trong DBAForm
                    OracleCommand cmd = new OracleCommand("GET_USER_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter cursorParam = new OracleParameter("users_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);
                    OracleDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable vào DataGridView
                    DBAForm.data_grid_view.DataSource = dt;

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
