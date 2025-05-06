using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // Đặt nút đăng nhập là nút mặc định khi nhấn Enter
            LoadRoles();
        }

        private void LoadRoles()
        {
            if (cbbRole.Items.Count > 0)
            {
                cbbRole.SelectedIndex = 0;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng không nhập đầy đủ thông tin
            if (txbUsername.Text == "" || txbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txbUsername.Text.ToUpper().Trim();
            string password = txbPassword.Text.Trim();
            string role = cbbRole.SelectedItem.ToString();

            // Lưu thông tin đăng nhập vào ConnectionManager
            ConnectionManager.Username = username;
            ConnectionManager.Password = password;

            try
            {
                // Tạo kết nối từ ConnectionManager
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    try
                    {
                        if (!RoleManager.HasRole(conn, role))
                        {
                            MessageBox.Show("Bạn không có quyền truy cập vào role này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        this.Hide();

                        if (role == "DBA")
                        {
                            DBAForm DBAForm = new DBAForm();
                            DBAForm.ShowDialog();
                        }
                        else
                        {
                            UserDashboardForm userDashboardForm = new UserDashboardForm(role);
                            userDashboardForm.ShowDialog();
                        }

                        this.Close();

                    }
                    catch (ArgumentException argEx)
                    {
                        MessageBox.Show("Lỗi khi kiểm tra role: " + argEx.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (OracleException oraEx)
            {
                if (oraEx.Number == 1017)
                {
                    // Lỗi đăng nhập không thành công
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi Oracle: " + oraEx.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
