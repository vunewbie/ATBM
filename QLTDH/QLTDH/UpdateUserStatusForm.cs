using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public partial class UpdateUserStatusForm : Form
    {
        public UpdateUserStatusForm()
        {
            InitializeComponent();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.Trim();
            string newStatus = cbbStatus.SelectedItem?.ToString(); // Lấy trạng thái mới từ ComboBox

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và chọn trạng thái tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    // Cập nhật trạng thái người dùng
                    OracleCommand updateCmd = new OracleCommand("UPDATE_USER_STATUS", conn);
                    updateCmd.CommandType = CommandType.StoredProcedure;
                    updateCmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    updateCmd.Parameters.Add("p_new_status", OracleDbType.Varchar2).Value = newStatus;

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show($"Trạng thái người dùng đã được cập nhật thành {newStatus}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái người dùng đã chọn
            string selectedStatus = cbbStatus.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStatus))
            {
                if (selectedStatus == "LOCK")
                {
                    this.BackColor = Color.LightCoral;
                }
                else if (selectedStatus == "UNLOCK")
                {
                    this.BackColor = Color.LightGreen;
                }
            }
        }

    }
}
