using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public partial class InsertStudentForm : Form
    {
        private string role;
        public InsertStudentForm(string role)
        {
            InitializeComponent();
            LoadDepartment();
            this.role = role;
        }

        private void LoadDepartment()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT TENDV FROM QLTDH.DONVI WHERE LOAIDV = 'Khoa'";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    cbbStudentDepartment.Items.Clear();
                    while (reader.Read())
                    {
                        cbbStudentDepartment.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("QLTDH.INSERT_STUDENT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new OracleParameter("fullname", txbStudentFullname.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("gender", cbbStudentGender.Text));
                    cmd.Parameters.Add(new OracleParameter("DOB", dtpkStudentDOB.Value));
                    cmd.Parameters.Add(new OracleParameter("address", txbStudentAddress.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("phone", txbStudentPhone.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("department", cbbStudentDepartment.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("role", this.role));

                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is UserDashboardForm userForm)
            {
                userForm.LoadStudentList();
            }
        }
    }
}
