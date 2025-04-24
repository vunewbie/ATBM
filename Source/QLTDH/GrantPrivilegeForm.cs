using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTDH
{
    public partial class GrantPrivilegeForm: Form
    {
        public GrantPrivilegeForm()
        {
            InitializeComponent();
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

                // Select the first item if available
                if (cbbUserRole.Items.Count > 0)
                    cbbUserRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách user/role: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cbbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrivilege.SelectedIndex = -1;
            cbbObject.SelectedIndex = -1;
            cbbObject.Items.Clear();
            cbbObjectType.SelectedIndex = -1;
            cbbObjectType.Items.Clear();
            cklbAttribute.Items.Clear();
        }
        private void cbbPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbPrivilege.Text == "SELECT" || cbbPrivilege.Text == "UPDATE")
            {
                cklbAttribute.Enabled = true;
            }
            else
            {
                cklbAttribute.Enabled = false;
                for (int i = 0; i < cklbAttribute.Items.Count; i++)
                {
                    cklbAttribute.SetItemChecked(i, false);
                }
            }

            cbbObjectType.SelectedIndex = -1;
            cbbObjectType.Items.Clear();
            if (cbbPrivilege.Text == "EXECUTE")
            {
                string[] items = { "PROCEDURE", "FUNCTION" };
                cbbObjectType.Items.AddRange(items);
            }
            else
            {
                string[] items = { "TABLE", "VIEW" };
                cbbObjectType.Items.AddRange(items);
            }
        }

        private void cbbObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbObject.SelectedIndex = -1;
            cbbObject.Items.Clear();
            cklbAttribute.Items.Clear();

            if (cbbUserRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User/Role hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset cbbUserRole to the first item
                if (cbbUserRole.Items.Count > 0)
                {
                    cbbUserRole.SelectedIndex = 0;
                }
                else
                {
                    cbbUserRole.Text = string.Empty;
                }
                return;
            }

            string usernamerole = cbbUserRole.Text.Trim();
            if (string.IsNullOrEmpty(usernamerole)) return;

            if (cbbObjectType.SelectedItem != null)
            {
                string selectedValue = cbbObjectType.SelectedItem.ToString();

                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("GET_OBJECT_TYPE_BY_USER_OR_ROLE", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("p_user_or_role", OracleDbType.Varchar2).Value = usernamerole;
                            cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = selectedValue;
                            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string objName = reader.GetString(0);
                                    cbbObject.Items.Add(objName);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cbbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cklbAttribute.Items.Clear();
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT column_name FROM USER_TAB_COLUMNS WHERE table_name = \'" + cbbObject.Text.ToString() + '\'';
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        cklbAttribute.Items.Add(row["column_name"].ToString());
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrantPrivilege_Click(object sender, EventArgs e)
        {
            if (cbbPrivilege.SelectedItem == null ||
                cbbObjectType.SelectedItem == null ||
                cbbObject.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbUserRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một User/Role hợp lệ từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Reset cbbUserRole
                cbbUserRole.SelectedItem = -1;
                cbbUserRole.Text = string.Empty;
                return;
            }

            string usernamerole = cbbUserRole.Text.Trim();
            string privilege = cbbPrivilege.SelectedItem.ToString();
            string objtype = cbbObjectType.SelectedItem.ToString();
            string obj = cbbObject.SelectedItem.ToString();
            bool isChecked = ckbWithGrantOption.Checked;

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.BindByName = true;

                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = usernamerole;
                    cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = obj;
                    cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = isChecked;
                    cmd.Parameters.Add("p_success", OracleDbType.Boolean).Direction = ParameterDirection.Output;

                    if (privilege == "SELECT"|| privilege == "UPDATE")
                    {
                        List<string> selectedAttrs = new List<string>();
                        for (int i = 0; i < cklbAttribute.Items.Count; i++)
                        {
                            if (cklbAttribute.GetItemChecked(i) == true)
                            {
                                selectedAttrs.Add(cklbAttribute.Items[i].ToString());
                            }
                        }

                        if (selectedAttrs.Count == 0 || selectedAttrs.Count == cklbAttribute.Items.Count)
                        {
                            selectedAttrs.Clear();          
                            selectedAttrs.Add("*");         
                        }

                        string[] attributeArray = selectedAttrs.ToArray();
                        cmd.Parameters.Add("p_attribute", OracleDbType.Varchar2);
                        cmd.Parameters["p_attribute"].CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        cmd.Parameters["p_attribute"].Value = attributeArray;
                        cmd.Parameters["p_attribute"].Size = attributeArray.Length;


                        if (privilege =="SELECT") cmd.CommandText = "GRANT_SELECT_TO_USER_OR_ROLE";
                        else cmd.CommandText = "GRANT_UPDATE_TO_USER_OR_ROLE";
                    }
                    else if (privilege == "INSERT") cmd.CommandText = "GRANT_INSERT_TO_USER_OR_ROLE";
                    else if (privilege == "DELETE") cmd.CommandText = "GRANT_DELETE_TO_USER_OR_ROLE";
                    else if (privilege == "EXECUTE") cmd.CommandText = "GRANT_EXEC_TO_USER_OR_ROLE";

                    cmd.ExecuteNonQuery();
                    bool result = ((OracleBoolean)cmd.Parameters["p_success"].Value).IsTrue;
                    if (result)
                    {
                        MessageBox.Show("Cấp quyền thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cấp quyền thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GrantPrivilegeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is DBAForm dbaForm)
            {
                dbaForm.btnRefresh_Click(sender, e);
            }
        }
    }
}
