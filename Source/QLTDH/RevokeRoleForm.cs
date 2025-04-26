using Oracle.ManagedDataAccess.Client;
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
    public partial class RevokeRoleForm : Form
    {
        public RevokeRoleForm()
        {
            InitializeComponent();
            LoadUser();
        }

        private void LoadUser()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("GET_GRANTED_ROLES", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = DBNull.Value; OracleParameter cursorParam = new OracleParameter("granted_roles_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        cbbUser.Items.Clear(); 

                        while (reader.Read())
                        {
                            string user = reader["GRANTEE"].ToString();
                            if (!cbbUser.Items.Contains(user)) 
                            {
                                cbbUser.Items.Add(user);
                            }
                        }
                        if (cbbUser.Items.Count > 0) cbbUser.SelectedIndex = 0;
                        else
                        {
                            MessageBox.Show("Không có role nào được cấp cho user.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbbUser.SelectedIndex = -1;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách role của user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = cbbUser.SelectedItem?.ToString();
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

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("QLTDH.GET_GRANTED_ROLES", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = selectedUser;

                        OracleParameter cursorParam = new OracleParameter("granted_roles_cursor", OracleDbType.RefCursor);
                        cursorParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cursorParam);

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            cbbRole.Items.Clear(); // Xóa dữ liệu cũ

                            while (reader.Read())
                            {
                                string role = reader["GRANTED_ROLE"].ToString();
                                if (!cbbRole.Items.Contains(role))
                                {
                                    cbbRole.Items.Add(role);
                                }
                            }
                            if (cbbRole.Items.Count > 0)
                                cbbRole.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải role của user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void RevokeRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gọi hàm btnRefresh_Click ở form DBAForm
            if (Owner is DBAForm dbaForm)
            {
                dbaForm.btnRefresh_Click(sender, e);
            }
        }

        private void btnRevokeRole_Click(object sender, EventArgs e)
        {
            if (cbbUser.SelectedItem == null|| cbbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User/Role hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedUser = cbbUser.SelectedItem.ToString();
            string selectedRole = cbbRole.SelectedItem.ToString();
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("REVOKE_ROLE_FROM_USER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = selectedUser;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = selectedRole;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Role đã được thu hồi thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OracleException ex)
            {
                if (ex.ErrorCode == -20003)
                {
                    MessageBox.Show($"Lỗi khi thu hồi role: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(ex.ErrorCode == -20002)
                {
                    MessageBox.Show($"Không thể thu hồi role từ user này: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi không xác định", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
