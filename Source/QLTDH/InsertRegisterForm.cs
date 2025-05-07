using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace QLTDH
{
    public partial class InsertRegisterForm : Form
    {
        private string role;
        public InsertRegisterForm(string role)
        {
            InitializeComponent();
            this.role = role;
            LoadStudentID();
            LoadCourseID();
        }

        private void LoadStudentID()
        {
            if (this.role == "SV")
            {
                cbbStudentID.Items.Clear();
                //Hiển thị mã sinh viên hiện tại
                cbbStudentID.Text = ConnectionManager.Username;
                cbbStudentID.Enabled = false;
                return;
            }

            if (this.role == "NV PĐT")
            {
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("QLTDH.GET_STUDENT_LIST", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = null;
                        cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = this.role;

                        OracleParameter cursorParam = new OracleParameter("student_cursor", OracleDbType.RefCursor);
                        cursorParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cursorParam);

                        OracleDataReader reader = cmd.ExecuteReader();
                        cbbStudentID.Items.Clear();
                        while (reader.Read())
                        {
                            cbbStudentID.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải mã sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void LoadCourseID()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("QLTDH.GET_OPEN_SUBJECT_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = null;
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = this.role;
                    OracleParameter cursorParam = new OracleParameter("subject_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();


                    cbbOpenSubjectID.Items.Clear();
                    while (reader.Read())
                    {
                        cbbOpenSubjectID.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("QLTDH.INSERT_REGISTER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter("studentID", cbbStudentID.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("openSubjectID", cbbOpenSubjectID.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("role", this.role));

                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Đăng ký môn học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (Owner is UserDashboardForm userForm)
                        {
                            userForm.LoadRegisterList();
                        }
                        this.Close();
                    }
                }
            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 20010:
                        MessageBox.Show("Sinh viên đã đăng ký môn này rồi!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 20020:
                        MessageBox.Show("Đã quá hạn đăng ký môn này!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 20030:
                        MessageBox.Show("Bạn không có quyền đăng ký môn này!", "Lỗi phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show("Lỗi khi đăng ký môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đăng ký: " + ex.Message, "Lỗi không xác định", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertRegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is UserDashboardForm userForm)
            {
                userForm.LoadRegisterList();
            }
        }
    }
}
