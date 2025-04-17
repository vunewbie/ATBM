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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLTDH
{
    public partial class CreateRoleForm : Form
    {
        public CreateRoleForm()
        {
            InitializeComponent();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            string role = txbRole.Text.Trim();
            string password = txbPassword.Text.Trim();

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập tên vai trò.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection()) { 
                    conn.Open();

                    // Kiểm tra xem role đã tồn tại
                    OracleCommand checkCmd = new OracleCommand("CHECK_ROLE_EXISTS", conn);
                    checkCmd.CommandType = CommandType.StoredProcedure;
                    checkCmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                    OracleParameter existsParam = new OracleParameter("p_exists", OracleDbType.Varchar2, 10);
                    existsParam.Direction = ParameterDirection.Output;
                    checkCmd.Parameters.Add(existsParam);

                    checkCmd.ExecuteNonQuery();

                    string roleExists = existsParam.Value.ToString();
                    if (roleExists == "TRUE")
                    {
                        MessageBox.Show("Vai trò đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo người dùng mới
                    OracleCommand createCmd = new OracleCommand("CREATE_ROLE", conn);
                    createCmd.CommandType = CommandType.StoredProcedure;
                    createCmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                    createCmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                    createCmd.ExecuteNonQuery();

                    MessageBox.Show("Tạo vai trò thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách vai trò trong DBAForm
                    OracleCommand cmd = new OracleCommand("GET_ROLE_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter cursorParam = new OracleParameter("roles_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);
                    OracleDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable vào DataGridView
                    DBAForm.role_data_grid_view.DataSource = dt;

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
