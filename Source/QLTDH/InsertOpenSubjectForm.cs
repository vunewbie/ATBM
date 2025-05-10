using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTDH
{
    public partial class InsertOpenSubjectForm : Form
    {
        public InsertOpenSubjectForm()
        {
            InitializeComponent();
            LoadSubject();
            LoadTeacherID();
        }
        private void LoadSubject()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT MAHP FROM QLTDH.HOCPHAN";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    OracleDataReader reader = cmd.ExecuteReader();
                    cbbSubjectID.Items.Clear();
                    while (reader.Read())
                    {
                        cbbSubjectID.Items.Add(reader.GetString(0));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn vị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTeacherID()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT MANV FROM QLTDH.v_TeacherID";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    OracleDataReader reader = cmd.ExecuteReader();
                    cbbTeacherID.Items.Clear();
                    while (reader.Read())
                    {
                        cbbTeacherID.Items.Add(reader.GetString(0));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải mã giảng viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertOpenSubject_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd;
                    cmd = new OracleCommand("QLTDH.EDUCATION_DEPARTMENT_INSERT_COURSE_OFFERING", conn);
                    cmd.Parameters.Add(new OracleParameter("p_mahp", cbbSubjectID.Text));
                    cmd.Parameters.Add(new OracleParameter("p_magv", cbbTeacherID.Text));
                    cmd.Parameters.Add(new OracleParameter("p_hk", cbbSemester.Text));
                    cmd.Parameters.Add(new OracleParameter("p_nam", txbYear.Text));

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    if (MessageBox.Show("Thêm mở môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (Owner is UserDashboardForm userForm)
                        {
                            userForm.LoadOpenSubjectList();
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mở môn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertOpenSubjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is UserDashboardForm userForm)
            {
                userForm.LoadOpenSubjectList();
            }
        }
    }
}
