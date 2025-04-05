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
                    using (OracleCommand cmd = new OracleCommand("CHECK_USER_ROLE", conn))
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
            if (cbbPrivilege.Text.ToString() == "Select" || cbbPrivilege.Text.ToString() == "Update")
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
        }
        private void cbbObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbObject.SelectedIndex = -1;
            cbbObject.Items.Clear();
            cklbAttribute.Items.Clear();
            cbbObject.Enabled = true;
            if (cbbObjectType.SelectedItem != null)
            {
                string selectedValue = cbbObjectType.SelectedItem.ToString();
                if (selectedValue == "Table")
                {
                    string[] items = { "QLDT_DETAI", "QLDT_GIAOVIEN", "QLDT_PHONGBAN", "QLDT_THAMGIA" };
                    cbbObject.Items.AddRange(items);
                }
                else if (selectedValue == "View")
                {
                    string[] items = { "GV_MATKHAU", "GV_THAMGIADETAI" };
                    cbbObject.Items.AddRange(items);
                }
                else if (selectedValue == "Stored Procedure")
                {
                    string[] items = { "PROC_CAPNHAT_PHUCAP", "PROC_DSTHAMGIA_GV" };
                    cbbObject.Items.AddRange(items);
                }
                else {
                    string[] items = { "FN_TONG_THOIGIAN_THAMGIA" };
                    cbbObject.Items.AddRange(items);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
