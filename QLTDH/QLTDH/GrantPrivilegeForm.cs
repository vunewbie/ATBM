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
            btnGrantPrivilege.Enabled=false;
        }
        private void txbUsernameRole_TextChanged(object sender, EventArgs e)
        {
            // Khi thay đổi nội dung, yêu cầu kiểm tra lại
            lblResultCheck.Text = ""; 
            btnGrantPrivilege.Enabled = false;
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
        }
        private void cbbPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            string selectedValue = cbbObjectType.SelectedItem.ToString();
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    if (selectedValue == "Table")
                    {
                        using (OracleCommand cmd = new OracleCommand("PH1_GET_TABLES_FOR_GRANT", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Tham số OUT
                            OracleParameter outputParam = cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor);
                            outputParam.Direction = ParameterDirection.Output;

                            // Gọi procedure
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string tableName = reader.GetString(0);
                                    cbbObject.Items.Add(tableName);
                                }

                            }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
