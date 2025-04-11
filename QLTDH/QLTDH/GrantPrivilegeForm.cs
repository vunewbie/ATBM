using Oracle.ManagedDataAccess.Client;
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
            cbbPrivilege.Enabled = false;
            cbbObjectType.Enabled = false;
            cbbObject.Enabled = false;
            ckbWithGrantOption.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string usernamerole = txbUsernameRole.Text.Trim();
            if (string.IsNullOrEmpty(usernamerole))
            {
                MessageBox.Show("Vui lòng nhập username/role.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("PH1_CHECK_USER_ROLE", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Tham số đầu vào
                        cmd.Parameters.Add("p_username_or_role", OracleDbType.Varchar2).Value = usernamerole;

                        // Tham số OUT
                        OracleParameter outputParam = cmd.Parameters.Add("p_type", OracleDbType.Varchar2, 100);
                        outputParam.Direction = ParameterDirection.Output;

                        // Gọi procedure
                        cmd.ExecuteNonQuery();

                        // Lấy kết quả từ tham số OUT
                        lblResultCheck.Text = outputParam.Value.ToString();
                        if (lblResultCheck.Text!="Không hợp lệ")
                        {
                            txbUsernameRole.Enabled = false;
                            cbbPrivilege.Enabled = true;
                            cbbObjectType.Enabled = true;
                            ckbWithGrantOption.Enabled = true;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txbUsernameRole.Text = "";
            lblResultCheck.Text = "";
            txbUsernameRole.Enabled=true;
            cbbPrivilege.SelectedIndex = -1;
            cbbPrivilege.Enabled = false;
            cbbObjectType.SelectedIndex = -1;
            cbbObjectType.Enabled = false;
            cbbObject.SelectedIndex = -1;
            cbbObject.Enabled = false;
            cklbAttribute.Items.Clear();
            cklbAttribute.Enabled = false;
            ckbWithGrantOption.Checked = false;
            ckbWithGrantOption.Enabled = false;
        }
        private void cbbPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbObjectType.Enabled = true;

            if (cbbPrivilege.Text == "Select" || cbbPrivilege.Text == "Update")
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
            cbbObject.Enabled = true;

            string usernamerole = txbUsernameRole.Text.Trim();
            if (string.IsNullOrEmpty(usernamerole)) return;

            if (cbbObjectType.SelectedItem != null)
            {
                string selectedValue = cbbObjectType.SelectedItem.ToString();

                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("PH1_GET_OBJECT_TYPE_BY_USER_OR_ROLE", conn))
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
            if (string.IsNullOrWhiteSpace(txbUsernameRole.Text) ||
                cbbPrivilege.SelectedItem == null ||
                cbbObjectType.SelectedItem == null ||
                cbbObject.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usernamerole = txbUsernameRole.Text.Trim();
            string privilege = cbbPrivilege.SelectedItem.ToString();
            string objtype = cbbObjectType.SelectedItem.ToString();
            string obj = cbbObject.SelectedItem.ToString();
            bool isChecked = ckbWithGrantOption.Checked;
            string[] selectedAttributes = cklbAttribute.CheckedItems.Cast<object>().Select(item => item.ToString()).ToArray();

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (privilege == "SELECT")
                    {
                        cmd.CommandText = "PH1_GRANT_SELECT_TO_USER_OR_ROLE";
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = usernamerole;
                        cmd.Parameters.Add("p_object_type", OracleDbType.Varchar2).Value = objtype;
                        cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = obj;
                        cmd.Parameters.Add("p_attribute", OracleDbType.Varchar2).CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        cmd.Parameters["p_attribute"].Value = selectedAttributes;
                        cmd.Parameters["p_attribute"].Size = selectedAttributes.Length;
                        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = isChecked;
                        cmd.Parameters.Add("p_success", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                    }
                    else if (privilege == "UPDATE")
                    {
                        cmd.CommandText = "PH1_GRANT_UPDATE_TO_USER_OR_ROLE";
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = usernamerole;
                        cmd.Parameters.Add("p_object_type", OracleDbType.Varchar2).Value = objtype;
                        cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = obj;
                        cmd.Parameters.Add("p_attribute", OracleDbType.Varchar2).CollectionType = OracleCollectionType.PLSQLAssociativeArray;
                        cmd.Parameters["p_attribute"].Value = selectedAttributes;
                        cmd.Parameters["p_attribute"].Size = selectedAttributes.Length;
                        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = isChecked;
                        cmd.Parameters.Add("p_success", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                    }
                    else if (privilege == "INSERT")
                    {
                        cmd.CommandText = "PH1_GRANT_INSERT_TO_USER_OR_ROLE";
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = usernamerole;
                        cmd.Parameters.Add("p_object_type", OracleDbType.Varchar2).Value = objtype;
                        cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = obj;
                        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = isChecked;
                        cmd.Parameters.Add("p_success", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                    }
                    else if (privilege == "DELETE")
                    {
                        cmd.CommandText = "PH1_GRANT_DELETE_TO_USER_OR_ROLE";
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = usernamerole;
                        cmd.Parameters.Add("p_object_type", OracleDbType.Varchar2).Value = objtype;
                        cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = obj;
                        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = isChecked;
                        cmd.Parameters.Add("p_success", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                    }
                    else if (privilege == "EXECUTE")
                    {
                        cmd.CommandText = "PH1_GRANT_EXEC_TO_USER_OR_ROLE";
                        cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = usernamerole;
                        cmd.Parameters.Add("p_object", OracleDbType.Varchar2).Value = obj;
                        cmd.Parameters.Add("p_with_grant_option", OracleDbType.Boolean).Value = isChecked;
                        cmd.Parameters.Add("p_success", OracleDbType.Boolean).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    bool result = Convert.ToBoolean(cmd.Parameters["p_success"].Value);
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
