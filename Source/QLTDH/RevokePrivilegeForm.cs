using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace QLTDH
{
    public partial class RevokePrivilegeForm : Form
    {
        public RevokePrivilegeForm()
        {
            InitializeComponent();

            // Load users and roles into the combo box when the form loads
            LoadUserRole();
        }

        private void LoadUserRole()
        {
            try
            {
                // Clear existing items
                cbbUserRole.Items.Clear();

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
                        cbbUserRole.Items.Add(username);
                    }

                    // Close the reader
                    reader.Close();

                    // Now add roles
                    cmd = new OracleCommand("GET_ROLE_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cursorParam = new OracleParameter("roles_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    reader = cmd.ExecuteReader();


                    // Add roles to the combo box and the master list
                    while (reader.Read())
                    {
                        string rolename = reader["ROLE"].ToString();
                        cbbUserRole.Items.Add(rolename);
                    }
                }

                cbbUserRole.SelectedIndex = -1;
                cbbUserRole.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách user/role: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadObject()
        {
            string grantee = cbbUserRole.SelectedItem.ToString();
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    //Load table privileges
                    OracleCommand cmd = new OracleCommand("GET_ALL_OBJECTS_BY_USER_OR_ROLE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = grantee;
                    OracleParameter cursorParam = new OracleParameter("all_objects_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string objectName = reader["TABLE_NAME"].ToString();
                        if (!cbbObject.Items.Contains(objectName))
                        {
                            cbbObject.Items.Add(objectName);
                        }
                    }

                    reader.Close();

                    if (cbbObject.Items.Count > 0)
                    {
                        cbbObject.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Không có quyền nào được cấp cho người dùng/nhóm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbbUserRole.SelectedIndex = -1; // Reset to no selection
                        cbbObject.SelectedIndex = -1; // Reset to no 
                        cbbObject.Text = string.Empty;
                        cbbUserRole.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách quyền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbUserRole_SelectedValueChanged(object sender, EventArgs e)
        {
            // Clear the object combo box
            cbbObject.Items.Clear();
            // Clear the text on the combo box
            cbbObject.Text = string.Empty;
            // Load the objects based on the selected user/role

            //Only load object when user/role is selected
            if (cbbUserRole.SelectedItem == null)
            {
                return;
            }
            LoadObject();
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            //get all value from all checkbox
            if (cbbUserRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User/Role hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset
                cbbUserRole.SelectedIndex = -1; // Reset to no selection
                cbbUserRole.Text = string.Empty; // Clear the text
                cbbObject.Text = string.Empty; // Clear the text
                cbbObject.SelectedIndex = -1; // Reset to no selection
                return;
            }

            if (cbbObject.SelectedItem == null) {
                MessageBox.Show("Vui lòng chọn một đối tượng hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset
                cbbUserRole.SelectedIndex = -1; // Reset to no selection
                cbbUserRole.Text = string.Empty; // Clear the text
                cbbObject.SelectedIndex = -1; // Reset to no selection
                cbbObject.Text = string.Empty; // Clear the text
                return;
            }

            string grantee = cbbUserRole.SelectedItem.ToString();
            string objectName = cbbObject.SelectedItem.ToString();

            //select from checkbox
            string select_priv = ckbSelect.Checked ? "SELECT" : "";
            string insert_priv = ckbInsert.Checked ? "INSERT" : "";
            string update_priv = ckbUpdate.Checked ? "UPDATE" : "";
            string delete_priv = ckbDelete.Checked ? "DELETE" : "";
            string execute_priv = ckbExecute.Checked ? "EXECUTE" : "";

            // Check if at least one privilege is selected
            if (string.IsNullOrEmpty(select_priv) && string.IsNullOrEmpty(insert_priv) && string.IsNullOrEmpty(update_priv) && string.IsNullOrEmpty(delete_priv) && string.IsNullOrEmpty(execute_priv))
            {
                MessageBox.Show("Vui lòng chọn ít nhất một quyền để thu hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the object name is selected
            if (string.IsNullOrEmpty(objectName))
            {
                MessageBox.Show("Vui lòng chọn một đối tượng để thu hồi quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the grantee is selected
            if (string.IsNullOrEmpty(grantee))
            {
                MessageBox.Show("Vui lòng chọn một người dùng hoặc nhóm để thu hồi quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //create the revoke statement
            string revokeStatement = "REVOKE";
            if (!string.IsNullOrEmpty(select_priv))
            {
                revokeStatement += " " + select_priv;
            }
            if (!string.IsNullOrEmpty(insert_priv))
            {
                revokeStatement += " " + insert_priv;
            }
            if (!string.IsNullOrEmpty(update_priv))
            {
                revokeStatement += " " + update_priv;
            }
            if (!string.IsNullOrEmpty(delete_priv))
            {
                revokeStatement += " " + delete_priv;
            }
            if (!string.IsNullOrEmpty(execute_priv))
            {
                revokeStatement += " " + execute_priv;
            }
            revokeStatement += " ON " + objectName;
            revokeStatement += " FROM " + grantee;

            // Show the revoke statement in a message box
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thực hiện lệnh sau không?\n\n" + revokeStatement, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        // Create command to execute the revoke statement
                        OracleCommand cmd = new OracleCommand(revokeStatement, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thực hiện lệnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện lệnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Clear the checkboxes after revoking
                ckbSelect.Checked = false;
                ckbInsert.Checked = false;
                ckbUpdate.Checked = false;
                ckbDelete.Checked = false;
                ckbExecute.Checked = false;
            }
        }

        private void RevokePrivilegeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Gọi hàm btnRefresh_Click ở form DBAForm
            if (Owner is DBAForm dbaForm)
            {
                dbaForm.btnRefresh_Click(sender, e);
            }
        }

        private void RevokePrivilegeForm_Shown(object sender, EventArgs e)
        {
            cbbUserRole.Focus();
        }
    }
}
