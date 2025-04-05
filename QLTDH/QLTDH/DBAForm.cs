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
        public static DataGridView user_data_grid_view; // Truyền user data giữa các form
        public static DataGridView role_data_grid_view; // Truyền role data giữa các form
        public DBAForm()
        {
            InitializeComponent();
            user_data_grid_view = dgvUsers;
            role_data_grid_view = dgvRoles;
        }

        private void tpageUsers_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức để tải dữ liệu người dùng
            LoadUsers();
        }

        private void tpageRoles_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức để tải dữ liệu roles
            LoadRoles();
        }
        private void tpagePrivileges_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức để tải dữ liệu privileges
            LoadPrivileges();
        }

        private void DBAForm_Load(object sender, EventArgs e)
        {
        }

        // Tải dữ liệu users lên datagridview
        private void LoadUsers()
        {
            try
            {
                // Tạo kết nối từ ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Khai báo một OracleCommand để gọi stored procedure
                    OracleCommand cmd = new OracleCommand("SYS.PH1_GET_USER_LIST", conn);
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
                    user_data_grid_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi khi tải dữ liệu người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải dữ liệu roles lên datagridview 
        private void LoadRoles()
        {
            try
            {
                // Tạo kết nối từ ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Khai báo một OracleCommand để gọi stored procedure
                    OracleCommand cmd = new OracleCommand("SYS.PH1_GET_ROLE_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Tạo một cursor output parameter
                    OracleParameter cursorParam = new OracleParameter("roles_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    // Thực thi procedure và lấy kết quả về
                    OracleDataReader reader = cmd.ExecuteReader();

                    // Tạo DataTable để chứa kết quả trả về
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable vào DataGridView
                    role_data_grid_view.DataSource= dt;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show("Lỗi khi tải dữ liệu Roles: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải dữ liệu privileges lên table và column priviledges datagirdview

        private void LoadPrivileges()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    //Load table privileges
                    OracleCommand cmd = new OracleCommand("PH1_GET_PRIVILEGES_TABLE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = null;
                    OracleParameter cursorParam = new OracleParameter("table_privileges_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // TẮT tính năng tự động tạo cột
                    dgvTablePrivilege.AutoGenerateColumns = false;

                    // Gán DataTable vào DataSource
                    dgvTablePrivilege.DataSource = dt;


                    //Load column privileges
                    OracleCommand cmd2 = new OracleCommand("PH1_GET_PRIVILEGES_COLUMN", conn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = null;
                    OracleParameter cursorParam2 = new OracleParameter("column_privileges_cursor", OracleDbType.RefCursor);
                    cursorParam2.Direction = ParameterDirection.Output;

                    cmd2.Parameters.Add(cursorParam2);
                    OracleDataReader reader2 = cmd2.ExecuteReader();

                    DataTable dt2 = new DataTable();
                    dt2.Load(reader2);
                    // TẮT tính năng tự động tạo cột
                    dgvColumnPrivilege.AutoGenerateColumns = false;
                    // Gán DataTable vào DataSource
                    dgvColumnPrivilege.DataSource = dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Privileges: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn nút "Create User"
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Mở form CreateUser
            CreateUserForm newUserForm = new CreateUserForm();
            newUserForm.ShowDialog();
        }
        // Sự kiện khi nhấn nút "Update User"
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Mỏ form UpdateUserStatus
            UpdateUserStatusForm updateUserStatusForm = new UpdateUserStatusForm();
            updateUserStatusForm.ShowDialog();
        }

        // Sự kiện khi nhấn nút "Delete User"
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Mở form DeleteUser
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.ShowDialog();
        }


        // Thêm phương thức tìm kiếm người dùng
        private void SearchUsers(string username)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Khai báo OracleCommand để gọi stored procedure tìm kiếm người dùng
                    OracleCommand cmd = new OracleCommand("SYS.PH1_SEARCH_USER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số tìm kiếm
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                    OracleParameter cursorParam = new OracleParameter("users_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    user_data_grid_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvTablePrivilege.Cursor = Cursors.Default; // Khôi phục con trỏ mặc định
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

        // Sự kiện khi nhấn nút "Create Role"
        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            // Mở form CreateRole
            CreateRoleForm createRoleForm = new CreateRoleForm();
            createRoleForm.ShowDialog();
        }

        // Sự kiện khi nhấn nút "Update Role"
        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            // Mở form UpdateRolePassword
            UpdateRolePasswordForm updateRolePasswordForm = new UpdateRolePasswordForm();
            updateRolePasswordForm.ShowDialog();
        }
        
        // Sự kiện khi nhấn nút "Delete Role"
        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            // Mở form DeleteRole
            DeleteRoleForm deleteRoleForm = new DeleteRoleForm();
            deleteRoleForm.ShowDialog();
        }

        // Thêm phương thức tìm kiếm Roles
        private void SearchRoles(string role)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Khai báo OracleCommand để gọi stored procedure tìm kiếm role
                    OracleCommand cmd = new OracleCommand("SYS.PH1_SEARCH_ROLE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số tìm kiếm
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                    OracleParameter cursorParam = new OracleParameter("roles_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    // Thực thi thủ tục và lấy kết quả
                    OracleDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable vào DataGridView để hiển thị kết quả
                    role_data_grid_view.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm role: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi nhấn vào nút "Search Roles"
        private void btnSearchRole_Click(object sender, EventArgs e)
        {
            string searchQuery = txbSearchRole.Text.Trim(); // txbSearchRole là TextBox để nhập tên Role
            if (string.IsNullOrEmpty(searchQuery))
            {
                // Nếu ô tìm kiếm trống, tải lại tất cả roles
                LoadRoles();
            }
            else
            {
                // Nếu ô tìm kiếm có dữ liệu, tìm kiếm role
                SearchRoles(searchQuery);
            }
        }

        private void btnGrantPrivilege_Click(object sender, EventArgs e)
        {
            // Mở form GrantPrivilege
            GrantPrivilegeForm newGrantPrivilegeForm = new GrantPrivilegeForm();
            newGrantPrivilegeForm.ShowDialog();
        }

        private void btnRevokePrivilege_Click(object sender, EventArgs e)
        {
            // Mở form RevokePrivilege
            RevokePrivilegeForm newRevokePrivilegeForm = new RevokePrivilegeForm();
            newRevokePrivilegeForm.ShowDialog();
        }
    }
}
