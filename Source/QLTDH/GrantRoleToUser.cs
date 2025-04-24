using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTDH
{
    public partial class GrantRoleToUser : Form
    {
        public GrantRoleToUser()
        {
            InitializeComponent();
            LoadUser();
            LoadRole();
        }
        private void LoadUser()
        {
            try
            {
                // Clear existing items
                cbbUser.Items.Clear();

                // Create connection using ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Create command to call the stored procedure that gets users
                    OracleCommand cmd = new OracleCommand("GET_USER_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Create cursor parameter for the output
                    OracleParameter cursorParam = new OracleParameter("users_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    // Execute the command and get the reader
                    OracleDataReader reader = cmd.ExecuteReader();

                    // Add users to the combo box and the master list
                    while (reader.Read())
                    {
                        string username = reader["USERNAME"].ToString();
                        cbbUser.Items.Add(username);
                    }

                    // Close the reader
                    reader.Close();
                }

                // Select the first item if available
                if (cbbUser.Items.Count > 0)
                    cbbUser.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách user/role: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRole()
        {
            try
            {
                // Clear existing items
                cbbRole.Items.Clear();

                // Create connection using ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Create command to call the stored procedure that gets roles 
                    OracleCommand cmd = new OracleCommand("GET_ROLE_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter cursorParam = new OracleParameter("roles_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();


                    // Add roles to the combo box and the master list
                    while (reader.Read())
                    {
                        string rolename = reader["ROLE"].ToString();
                        cbbRole.Items.Add(rolename);
                    }
                }

                // Select the first item if available
                if (cbbRole.Items.Count > 0)
                    cbbRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách user/role: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUser.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset cbbUserRole to the first item
                if (cbbUser.Items.Count > 0)
                {
                    cbbUser.SelectedIndex = 0;
                }
                else
                {
                    cbbUser.Text = string.Empty;
                }
                return;
            }
        }
        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một Role hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset cbbUserRole to the first item
                if (cbbRole.Items.Count > 0)
                {
                    cbbRole.SelectedIndex = 0;
                }
                else
                {
                    cbbRole.Text = string.Empty;
                }
                return;
            }
        }
        private void btnGrantRole_Click(object sender, EventArgs e)
        {

            if (cbbUser.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset cbbUserRole to the first item
                if (cbbUser.Items.Count > 0)
                {
                    cbbUser.SelectedIndex = 0;
                }
                else
                {
                    cbbUser.Text = string.Empty;
                }
                return;
            }
            if (cbbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một Role hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset cbbUserRole to the first item
                if (cbbRole.Items.Count > 0)
                {
                    cbbRole.SelectedIndex = 0;
                }
                else
                {
                    cbbRole.Text = string.Empty;
                }
                return;
            }

            string user = cbbUser.Text.Trim();
            string role = cbbRole.Text.Trim();
            bool isChecked = ckbWithAdminOption.Checked;
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "GRANT_ROLE_TO_USER";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.BindByName = true;

                    cmd.Parameters.Add("p_user", OracleDbType.Varchar2).Value = user;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                    cmd.Parameters.Add("p_with_admin_option", OracleDbType.Boolean).Value = isChecked;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cấp quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OracleException ex)
            {
                // Xử lý lỗi Oracle 
                string errorMessage;

                switch (ex.Number)
                {
                    case 20001:
                        errorMessage = "Không tìm thấy người dùng đã chọn.";
                        break;
                    case 20002:
                        errorMessage = "Không tìm thấy role đã chọn.";
                        break;
                    case 20003:
                        errorMessage = "Không thể cấp role cho người dùng ở PDB khác.\nRole và người dùng phải thuộc cùng một PDB.";
                        break;
                    case 20000:
                        errorMessage = ex.Message.Replace("ORA-20000: ", "");
                        break;
                    default:
                        errorMessage = ex.Message;
                        break;
                }

                MessageBox.Show(errorMessage, "Lỗi cấp quyền", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrantRoleToUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gọi hàm btnRefresh_Click ở form DBAForm
            if (Owner is DBAForm dbaForm)
            {
                dbaForm.btnRefresh_Click(sender, e);
            }
        }
    }
}
