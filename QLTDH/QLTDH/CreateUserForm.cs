using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.Trim();
            string password = txbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Kiểm tra xem người dùng đã tồn tại
                    OracleCommand checkCmd = new OracleCommand("SYS.PH1_CHECK_USER_EXISTS", conn);
                    checkCmd.CommandType = CommandType.StoredProcedure;
                    checkCmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    OracleParameter existsParam = new OracleParameter("p_exists", OracleDbType.Varchar2, 10);
                    existsParam.Direction = ParameterDirection.Output;
                    checkCmd.Parameters.Add(existsParam);

                    checkCmd.ExecuteNonQuery();

                    string userExists = existsParam.Value.ToString();
                    if (userExists == "TRUE")
                    {
                        MessageBox.Show("Người dùng đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo người dùng mới
                    OracleCommand createCmd = new OracleCommand("SYS.PH1_CREATE_USER", conn);
                    createCmd.CommandType = CommandType.StoredProcedure;
                    createCmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    createCmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                    createCmd.ExecuteNonQuery();

                    MessageBox.Show("Tạo người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách người dùng trong DBAForm
                    OracleCommand cmd = new OracleCommand("SYS.PH1_GET_USER_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter cursorParam = new OracleParameter("users_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);
                    OracleDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable vào DataGridView
                    DBAForm.user_data_grid_view.DataSource = dt;

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
