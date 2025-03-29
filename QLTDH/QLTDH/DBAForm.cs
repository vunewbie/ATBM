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
    public partial class DBAForm : Form
    {
        public static DataGridView data_grid_view;
        public DBAForm()
        {
            InitializeComponent();
            data_grid_view = dgvUsers;
        }

        private void tpageUsers_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức để tải dữ liệu người dùng
            LoadUsers();
        }

        private void DBAForm_Load(object sender, EventArgs e)
        {
            // Gọi phương thức để tải dữ liệu người dùng
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                // Tạo kết nối từ ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Khai báo một OracleCommand để gọi stored procedure
                    OracleCommand cmd = new OracleCommand("GET_USER_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tạo một cursor output parameter
                    OracleParameter cursorParam = new OracleParameter("users_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    // Thực thi procedure và lấy kết quả về
                    OracleDataReader reader = cmd.ExecuteReader();

                    // Tạo DataTable để chứa kết quả trả về
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable vào DataGridView
                    data_grid_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sự kiện khi nhấn nút "Create User"
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Mở form CreateUser
            CreateUserForm newUserForm = new CreateUserForm();
            newUserForm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Mở form DeleteUser
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Mỏ form UpdateUserStatus
            UpdateUserStatusForm updateUserStatusForm = new UpdateUserStatusForm();
            updateUserStatusForm.ShowDialog();
        }

        // Thêm phương thức tìm kiếm người dùng
        // Thêm phương thức tìm kiếm người dùng
        private void SearchUsers(string username)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Khai báo OracleCommand để gọi stored procedure tìm kiếm người dùng
                    OracleCommand cmd = new OracleCommand("SEARCH_USER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số tìm kiếm
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    OracleParameter cursorParam = new OracleParameter("users_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    data_grid_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Search User"
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string searchQuery = txbSearchUser.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                // Nếu ô tìm kiếm trống, tải lại tất cả người dùng
                LoadUsers();
            }
            else
            {
                // Nếu ô tìm kiếm có dữ liệu, tìm kiếm người dùng
                SearchUsers(searchQuery);
            }
        }
    }
}
