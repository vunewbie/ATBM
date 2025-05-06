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
using System.Xml.Linq;

namespace QLTDH
{
    public partial class UserDashboardForm : Form
    {
        private string role;
        public UserDashboardForm(string role)
        {
            InitializeComponent();
            this.role = role;
            LoadUnit();
        }
        public void LoadEmployeeList(string name = null)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("QLTDH.GET_EMPLOYEE_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = this.role;
                    OracleParameter cursorParam = new OracleParameter("employees_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dtgvEmployee.DataSource = dt;

                    if (this.role != "NV TCHC")
                    {
                        txbEmployeeFullname.Enabled = false;
                        cbbEmployeeGender.Enabled = false;
                        dtpkDOB.Enabled = false;
                        txbEmployeeSalary.Enabled= false;
                        txbEmployeeAllowance.Enabled = false;
                        cbbEmployeeRole.Enabled = false;
                        cbbUnitID.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }
        private void LoadUnit()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT MADV FROM QLTDH.DONVI";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    OracleDataReader reader = cmd.ExecuteReader();
                    cbbUnitID.Items.Clear();
                    while (reader.Read())
                    {
                        cbbUnitID.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn vị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txbEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txbEmployeeSearch.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                LoadEmployeeList(); 
            }
            else
            {
                LoadEmployeeList(name); 
            }
        }

        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txbEmployeeID.Text = dtgvEmployee.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
            txbEmployeeFullname.Text = dtgvEmployee.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
            cbbEmployeeGender.Text = dtgvEmployee.Rows[e.RowIndex].Cells["PHAI"].Value.ToString();
            dtpkDOB.Value = Convert.ToDateTime(dtgvEmployee.Rows[e.RowIndex].Cells["NGSINH"].Value);
            txbEmployeeSalary.Text = dtgvEmployee.Rows[e.RowIndex].Cells["LUONG"].Value.ToString();
            txbEmployeeAllowance.Text = dtgvEmployee.Rows[e.RowIndex].Cells["PHUCAP"].Value.ToString();
            txbEmployeePhone.Text = dtgvEmployee.Rows[e.RowIndex].Cells["DT"].Value.ToString();
            cbbEmployeeRole.Text = dtgvEmployee.Rows[e.RowIndex].Cells["VAITRO"].Value.ToString();
            cbbUnitID.Text = dtgvEmployee.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (role != "NV TCHC")
            {
                MessageBox.Show("Bạn không có quyền xoá nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txbEmployeeID.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MANV=txbEmployeeID.Text;
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();

                        string query = "DELETE FROM QLTDH.NHANVIEN WHERE MANV=:manv";
                        OracleCommand cmd = new OracleCommand(query, conn);

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new OracleParameter("manv", MANV));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string name = txbEmployeeSearch.Text.Trim();
                        if (string.IsNullOrEmpty(name))
                        {
                            LoadEmployeeList();
                        }
                        else
                        {
                            LoadEmployeeList(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            if (role != "NV TCHC")
            {
                MessageBox.Show("Bạn không có quyền thêm nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InsertEmployeeForm newInsertEmployeeForm = new InsertEmployeeForm();
            newInsertEmployeeForm.Owner = this;
            newInsertEmployeeForm.ShowDialog();
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmployeeFullname.Text) ||
                string.IsNullOrEmpty(cbbEmployeeGender.Text) ||
                string.IsNullOrEmpty(txbEmployeeSalary.Text) ||
                string.IsNullOrEmpty(txbEmployeeAllowance.Text) ||
                string.IsNullOrEmpty(txbEmployeePhone.Text) ||
                string.IsNullOrEmpty(cbbEmployeeRole.Text) ||
                string.IsNullOrEmpty(cbbUnitID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd;

                    if (role == "NVCB" || role == "GV" || role == "NV PĐT" || role == "NV PKT" ||
                        role == "NV CTSV" || role == "TRGĐV")
                    {
                        cmd = new OracleCommand("QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER", conn);
                        cmd.Parameters.Add(new OracleParameter("p_new_dt", txbEmployeePhone.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                    else if (role=="NV TCHC")
                    {
                        cmd = new OracleCommand("QLTDH.UPDATE_EMPLOYEE", conn);
                        cmd.Parameters.Add(new OracleParameter("employeeID", txbEmployeeID.Text));
                        cmd.Parameters.Add(new OracleParameter("fullname", txbEmployeeFullname.Text));
                        cmd.Parameters.Add(new OracleParameter("gender", cbbEmployeeGender.Text));
                        cmd.Parameters.Add(new OracleParameter("DOB", dtpkDOB.Value));
                        cmd.Parameters.Add(new OracleParameter("salary", Convert.ToInt32(txbEmployeeSalary.Text)));
                        cmd.Parameters.Add(new OracleParameter("allowance", Convert.ToInt32(txbEmployeeAllowance.Text)));
                        cmd.Parameters.Add(new OracleParameter("phone", txbEmployeePhone.Text));
                        cmd.Parameters.Add(new OracleParameter("role", cbbEmployeeRole.Text));
                        cmd.Parameters.Add(new OracleParameter("unit", cbbUnitID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("Chỉnh sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string name = txbEmployeeSearch.Text.Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        LoadEmployeeList();
                    }
                    else
                    {
                        LoadEmployeeList(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadOpenSubjectList(string name = null)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("QLTDH.GET_OPEN_SUBJECT_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = this.role;
                    OracleParameter cursorParam = new OracleParameter("subject_cursor", OracleDbType.RefCursor);
                    cursorParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(cursorParam);

                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dtgvOpenSubject.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin mở môn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelectOpenSubject_Click(object sender, EventArgs e)
        {
            LoadOpenSubjectList();
        }

        private void txbOpenSubjectSearch_TextChanged(object sender, EventArgs e)
        {
            string name = txbOpenSubjectSearch.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                LoadOpenSubjectList();
            }
            else
            {
                LoadOpenSubjectList(name);
            }
        }

        private void dtgvOpenSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txbOpenSubjectID.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["MAMM"].Value.ToString();
            cbbSubjectID.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
            cbbTeacherID.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["MAGV"].Value.ToString();
            cbbSemester.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["HK"].Value.ToString();
            txbYear.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["NAM"].Value.ToString();
        }

        private void btnDeleteOpenSubject_Click(object sender, EventArgs e)
        {
            if (role != "NV PĐT")
            {
                MessageBox.Show("Bạn không có quyền xóa mở môn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txbOpenSubjectID.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn nhân viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MAMM = txbOpenSubjectID.Text;
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("QLTDH.EDUCATION_DEPARTMENT_DELETE_COURSE_OFFERING", conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("p_mamm", MAMM));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa mở môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string name = txbOpenSubjectSearch.Text.Trim();
                        if (string.IsNullOrEmpty(name))
                        {
                            LoadOpenSubjectList();
                        }
                        else
                        {
                            LoadOpenSubjectList(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa mở môn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnInsertOpenSubject_Click(object sender, EventArgs e)
        {
            if (role != "NV PĐT")
            {
                MessageBox.Show("Bạn không có quyền thêm mở môn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InsertOpenSubjectForm newInsertOpenSubjectForm = new InsertOpenSubjectForm();
            newInsertOpenSubjectForm.Owner = this;
            newInsertOpenSubjectForm.ShowDialog();
        }
        private void btnUpdateOpenSubject_Click(object sender, EventArgs e)
        {
            if (role != "NV PĐT")
            {
                MessageBox.Show("Bạn không có quyền cập nhật mở môn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txbOpenSubjectID.Text) ||
                string.IsNullOrEmpty(cbbSubjectID.Text) ||
                string.IsNullOrEmpty(cbbTeacherID.Text) ||
                string.IsNullOrEmpty(cbbSemester.Text) ||
                string.IsNullOrEmpty(txbYear.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd=new OracleCommand("QLTDH.EDUCATION_DEPARTMENT_UPDATE_COURSE_OFFERING", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_mamm", txbOpenSubjectID.Text);
                    cmd.Parameters.Add("p_mahp", cbbSubjectID.Text);
                    cmd.Parameters.Add("p_magv", cbbTeacherID.Text);
                    cmd.Parameters.Add("p_hk", cbbSemester.Text);
                    cmd.Parameters.Add("p_nam", txbYear.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Chỉnh sửa mmở môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string name = txbOpenSubjectSearch.Text.Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        LoadOpenSubjectList();
                    }
                    else
                    {
                        LoadOpenSubjectList(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa mở môn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
