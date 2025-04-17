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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng không nhập đầy đủ thông tin
            if (txbUsername.Text == "" || txbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txbUsername.Text;
            string password = txbPassword.Text;

            // Lưu thông tin đăng nhập vào ConnectionManager
            ConnectionManager.Username = username;
            ConnectionManager.Password = password;

            try
            {
                // Tạo kết nối từ ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    // Kiểm tra quyền của người dùng
                    string checkRoleQuery = @"SELECT GRANTED_ROLE 
                                              FROM DBA_ROLE_PRIVS 
                                              WHERE GRANTEE = :username 
                                              AND GRANTED_ROLE = 'DBA'";
                    OracleCommand cmd = new OracleCommand(checkRoleQuery, conn);
                    cmd.Parameters.Add(new OracleParameter("username", username));

                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Nếu người dùng có quyền SYSDBA hoặc DBA, chuyển sang giao diện DBAForm
                        if (reader.GetString(0) == "SYSDBA" || reader.GetString(0) == "DBA")
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide(); // Ẩn LoginForm thay vì đóng
                            DBAForm dbaForm = new DBAForm();
                            dbaForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không phải DBA", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi kết nối
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            // Chuyển đổi giữa hiển thị và ẩn mật khẩu
            if (txbPassword.UseSystemPasswordChar)
            {
                txbPassword.UseSystemPasswordChar = false;
                pbPassword.Image = Properties.Resources.eye_on; // Hình ảnh mắt mở
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                pbPassword.Image = Properties.Resources.eye_off; // Hình ảnh mắt đóng
            }
        }
    }
}
