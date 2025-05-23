﻿using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
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
            LoadEmployeeList();
        }
        public void LoadEmployeeList(string name = null)
        {
            if (this.role == "NVCB"|| this.role == "GV"|| this.role == "NV PĐT"|| this.role == "NV PKT"||
                this.role == "NV TCHC"|| this.role == "NV CTSV"|| this.role == "TRGĐV")
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (this.role != "NV TCHC")
            {
                txbEmployeeFullname.Enabled = false;
                cbbEmployeeGender.Enabled = false;
                dtpkDOB.Enabled = false;
                txbEmployeeSalary.Enabled = false;
                txbEmployeeAllowance.Enabled = false;
                cbbEmployeeRole.Enabled = false;
                cbbUnitID.Enabled = false;
            }
            if (this.role == "SV")
            {
                txbEmployeePhone.Enabled = false;
            }
        }
        private void LoadUnit()
        {
            if (this.role == "NV TCHC")
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
            LoadUnit();
            txbEmployeeID.Text = dtgvEmployee.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
            txbEmployeeFullname.Text = dtgvEmployee.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
            cbbEmployeeGender.Text = dtgvEmployee.Rows[e.RowIndex].Cells["PHAI"].Value.ToString();
            dtpkDOB.Value = Convert.ToDateTime(dtgvEmployee.Rows[e.RowIndex].Cells["NGSINH"].Value);
            txbEmployeeSalary.Text = dtgvEmployee.Rows[e.RowIndex].Cells["LUONG"].Value.ToString();
            txbEmployeeAllowance.Text = dtgvEmployee.Rows[e.RowIndex].Cells["PHUCAP"].Value.ToString();
            txbEmployeePhone.Text = dtgvEmployee.Rows[e.RowIndex].Cells["DT"].Value.ToString();
            cbbEmployeeRole.Text = dtgvEmployee.Rows[e.RowIndex].Cells["VAITRO"].Value.ToString();
            cbbUnitID.Text = dtgvEmployee.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
            if (role == "TRGĐV" && !dtgvEmployee.Rows[e.RowIndex].Cells["MANV"].Value.ToString().StartsWith("TRGDV"))
            {
                txbEmployeePhone.Enabled = false;
            }
            if (role == "TRGĐV" && dtgvEmployee.Rows[e.RowIndex].Cells["MANV"].Value.ToString().StartsWith("TRGDV"))
            {
                txbEmployeePhone.Enabled = true;
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (this.role != "NV TCHC")
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
            if (this.role != "NV TCHC")
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
            if (this.role != "NVCB" && this.role != "GV" && this.role != "NV PĐT" && this.role != "NV PKT" &&
                        this.role != "NV CTSV" && this.role != "TRGĐV" && this.role != "NV TCHC")
            {
                MessageBox.Show("Bạn không có quyền thêm nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.role=="NV TCHC")
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
            }
            else
            {
                if (string.IsNullOrEmpty(txbEmployeePhone.Text))
                {
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } 

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd;

                    if (this.role == "NVCB" || this.role == "GV" || this.role == "NV PĐT" || this.role == "NV PKT" ||
                        this.role == "NV CTSV" || this.role == "TRGĐV")
                    {
                        cmd = new OracleCommand("QLTDH.EMPLOYEE_UPDATE_PHONE_NUMBER", conn);
                        cmd.Parameters.Add(new OracleParameter("p_new_dt", txbEmployeePhone.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                    else if (this.role == "NV TCHC")
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
            if (this.role == "GV"|| this.role == "NV PĐT"|| this.role == "TRGĐV"|| this.role == "SV")
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
            if (this.role != "NV PĐT")
            {
                cbbSubjectID.Enabled = false;
                cbbTeacherID.Enabled = false;
                cbbSemester.Enabled = false;
                txbYear.Enabled = false;
            }
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
        private void LoadSubject()
        {
            if (this.role == "NV PĐT")
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
        }
        private void LoadTeacherID()
        {
            if (this.role == "NV PĐT")
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
        }
        private void dtgvOpenSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            LoadSubject();
            LoadTeacherID();
            txbOpenSubjectID.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["MAMM"].Value.ToString();
            cbbSubjectID.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
            cbbTeacherID.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["MAGV"].Value.ToString();
            cbbSemester.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["HK"].Value.ToString();
            txbYear.Text = dtgvOpenSubject.Rows[e.RowIndex].Cells["NAM"].Value.ToString();
        }

        private void btnDeleteOpenSubject_Click(object sender, EventArgs e)
        {
            if (this.role != "NV PĐT")
            {
                MessageBox.Show("Bạn không có quyền xóa mở môn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txbOpenSubjectID.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn mở môn cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mở môn này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (this.role != "NV PĐT")
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
            if (this.role != "NV PĐT")
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

                    MessageBox.Show("Chỉnh sửa mở môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tpgEmployee_Enter(object sender, EventArgs e)
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

        private void tpgOpenSubject_Enter(object sender, EventArgs e)
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }


        public void LoadStudentList(string studentName = null)
        {
            if (this.role == "SV" || this.role == "NV CTSV" || this.role == "NV PĐT" || this.role == "GV")
            {
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("QLTDH.GET_STUDENT_LIST", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = studentName;
                        cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = this.role;

                        OracleParameter cursorParam = new OracleParameter("student_cursor", OracleDbType.RefCursor);
                        cursorParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cursorParam);

                        OracleDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvStudent.AutoGenerateColumns = false;
                        dgvStudent.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tpgStudent_Enter(object sender, EventArgs e)
        {
            string studentName = txbSearchStudent.Text.Trim();
            if (string.IsNullOrEmpty(studentName))
            {
                LoadStudentList();
            }
            else
            {
                LoadStudentList(studentName);
            }

            if (this.role == "SV")
            {
                txbStudentID.Enabled = false;
                txbStudentName.Enabled = false;
                cbbStudentGender.Enabled = false;
                dtpckStudentDOB.Enabled = false;
                txbStudentPhoneNumber.Enabled = true;
                txbStudentAddress.Enabled = true;
                cbbStudentDepartment.Enabled = false;
                cbbStudentStatus.Enabled = false;
            }
            else if (this.role == "NV CTSV")
            {
                txbStudentID.Enabled = false;
                txbStudentName.Enabled = true;
                cbbStudentGender.Enabled = true;
                dtpckStudentDOB.Enabled = true;
                txbStudentPhoneNumber.Enabled = true;
                txbStudentAddress.Enabled = true;
                cbbStudentDepartment.Enabled = true;
                cbbStudentStatus.Enabled = false;

                //load department to cbbStudentDepartment
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        string query = "SELECT MADV FROM QLTDH.DONVI WHERE LOAIDV = 'Khoa'";
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
            else if (this.role == "NV PĐT")
            {
                txbStudentID.Enabled = false;
                txbStudentName.Enabled = false;
                cbbStudentGender.Enabled = false;
                dtpckStudentDOB.Enabled = false;
                txbStudentPhoneNumber.Enabled = false;
                txbStudentAddress.Enabled = false;
                cbbStudentDepartment.Enabled = false;
                cbbStudentStatus.Enabled = true;
            }
            else
            {
                txbStudentID.Enabled = false;
                txbStudentName.Enabled = false;
                cbbStudentGender.Enabled = false;
                dtpckStudentDOB.Enabled = false;
                txbStudentPhoneNumber.Enabled = false;
                txbStudentAddress.Enabled = false;
                cbbStudentDepartment.Enabled = false;
                cbbStudentStatus.Enabled = false;
            }
        }


        private void txbSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string studentName = txbSearchStudent.Text.Trim();
            if (string.IsNullOrEmpty(studentName))
            {
                LoadStudentList();
            }
            else
            {
                LoadStudentList(studentName);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txbStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells["stdMASV"].Value.ToString();
            txbStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells["stdHOTEN"].Value.ToString();
            cbbStudentGender.Text = dgvStudent.Rows[e.RowIndex].Cells["stdPHAI"].Value.ToString();
            dtpckStudentDOB.Value = Convert.ToDateTime(dgvStudent.Rows[e.RowIndex].Cells["stdNGSINH"].Value);
            txbStudentPhoneNumber.Text = dgvStudent.Rows[e.RowIndex].Cells["stdDT"].Value.ToString();
            txbStudentAddress.Text = dgvStudent.Rows[e.RowIndex].Cells["stdDCHI"].Value.ToString();
            cbbStudentDepartment.Text = dgvStudent.Rows[e.RowIndex].Cells["stdKHOA"].Value.ToString();
            cbbStudentStatus.Text = dgvStudent.Rows[e.RowIndex].Cells["stdTINHTRANG"].Value.ToString();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (this.role != "SV" && this.role != "NV CTSV" && this.role != "NV PĐT")
            {
                MessageBox.Show("Bạn không có quyền cập nhật thông tin sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txbStudentID.Text) ||
                string.IsNullOrEmpty(txbStudentName.Text) ||
                string.IsNullOrEmpty(cbbStudentGender.Text) ||
                string.IsNullOrEmpty(txbStudentPhoneNumber.Text) ||
                string.IsNullOrEmpty(txbStudentAddress.Text) ||
                string.IsNullOrEmpty(cbbStudentDepartment.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("QLTDH.UPDATE_STUDENT", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new OracleParameter("studentID", txbStudentID.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("fullname", txbStudentName.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("gender", cbbStudentGender.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("DOB", dtpckStudentDOB.Value));
                    cmd.Parameters.Add(new OracleParameter("address", txbStudentAddress.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("phone", txbStudentPhoneNumber.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("department", cbbStudentDepartment.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("status", cbbStudentStatus.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("role", this.role));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string studentName = txbSearchStudent.Text.Trim();
                    if (string.IsNullOrEmpty(studentName))
                    {
                        LoadStudentList();
                    }
                    else
                    {
                        LoadStudentList(studentName);
                    }
                }
            }
            catch(OracleException ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (this.role != "NV CTSV")
            {
                MessageBox.Show("Bạn không có quyền xóa sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txbStudentID.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn sinh viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string studentID = txbStudentID.Text;
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("QLTDH.DELETE_STUDENT", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new OracleParameter("studentID", studentID));
                        cmd.Parameters.Add(new OracleParameter("role", this.role));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string studentName = txbSearchStudent.Text.Trim();
                        if (string.IsNullOrEmpty(studentName))
                        {
                            LoadStudentList();
                        }
                        else
                        {
                            LoadStudentList(studentName);
                        }
                    }
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 2292)
                    {
                        MessageBox.Show("Không thể xóa sinh viên này vì có liên kết với các bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            if (this.role != "NV CTSV")
            {
                MessageBox.Show("Bạn không có quyền thêm sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InsertStudentForm newInsertStudentForm = new InsertStudentForm(this.role);
            newInsertStudentForm.Owner = this;
            newInsertStudentForm.ShowDialog();
        }

        public void LoadRegisterList(string studentID = null)
        {
            if (this.role == "SV" || this.role == "NV PKT" || this.role == "NV PĐT" || this.role == "GV")
            {
                try
                {
                    using (OracleConnection conn = ConnectionManager.CreateConnection())
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("QLTDH.GET_REGISTER_LIST", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("studentID", OracleDbType.Varchar2).Value = studentID;
                        cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = this.role;

                        OracleParameter cursorParam = new OracleParameter("register_cursor", OracleDbType.RefCursor);
                        cursorParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cursorParam);

                        OracleDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvRegister.AutoGenerateColumns = false;
                        dgvRegister.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thông tin đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txbSearchRegister_TextChanged(object sender, EventArgs e)
        {
            string studentID = txbSearchRegister.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                LoadRegisterList();
            }
            else
            {
                LoadRegisterList(studentID);
            }
        }

        private void tpgRegister_Enter(object sender, EventArgs e)
        {
            string studentID = txbSearchRegister.Text.Trim();
            if (string.IsNullOrEmpty(studentID))
            {
                LoadRegisterList();
            }
            else
            {
                LoadRegisterList(studentID);
            }

            if (this.role == "SV")
            {
                txbRgtStudentID.Enabled = false;
                txbRgtOpenSubjectID.Enabled = false;
                txbDiemTH.Enabled = false;
                txbDiemQT.Enabled = false;
                txbDiemCK.Enabled = false;
                txbDiemTK.Enabled = false;
            }
            else if (this.role == "NV PKT")
            {
                txbRgtStudentID.Enabled = false;
                txbRgtOpenSubjectID.Enabled = false;
                txbDiemTH.Enabled = true;
                txbDiemQT.Enabled = true;
                txbDiemCK.Enabled = true;
                txbDiemTK.Enabled = true;
            }
            else
            {
                txbRgtStudentID.Enabled = false;
                txbRgtOpenSubjectID.Enabled = false;
                txbDiemTH.Enabled = false;
                txbDiemQT.Enabled = false;
                txbDiemCK.Enabled = false;
                txbDiemTK.Enabled = false;
            }
        }

        private void dgvRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            txbRgtStudentID.Text = dgvRegister.Rows[e.RowIndex].Cells["rgtMASV"].Value.ToString();
            txbRgtOpenSubjectID.Text = dgvRegister.Rows[e.RowIndex].Cells["rgtMAMM"].Value.ToString();
            txbDiemTH.Text = dgvRegister.Rows[e.RowIndex].Cells["rgtDIEMTH"].Value.ToString();
            txbDiemQT.Text = dgvRegister.Rows[e.RowIndex].Cells["rgtDIEMQT"].Value.ToString();
            txbDiemCK.Text = dgvRegister.Rows[e.RowIndex].Cells["rgtDIEMCK"].Value.ToString();
            txbDiemTK.Text = dgvRegister.Rows[e.RowIndex].Cells["rgtDIEMTK"].Value.ToString();
        }

        private void btnUpdateRegister_Click(object sender, EventArgs e)
        {
            if (this.role != "NV PKT")
            {
                MessageBox.Show("Bạn không có quyền cập nhật thông tin đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txbRgtStudentID.Text) ||
                string.IsNullOrEmpty(txbRgtOpenSubjectID.Text) ||
                string.IsNullOrEmpty(txbDiemTH.Text) ||
                string.IsNullOrEmpty(txbDiemQT.Text) ||
                string.IsNullOrEmpty(txbDiemCK.Text) ||
                string.IsNullOrEmpty(txbDiemTK.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("QLTDH.UPDATE_REGISTER", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new OracleParameter("studentID", txbRgtStudentID.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("openSubjectID", txbRgtOpenSubjectID.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("diemTH", Convert.ToDouble(txbDiemTH.Text.Trim())));
                    cmd.Parameters.Add(new OracleParameter("diemQT", Convert.ToDouble(txbDiemQT.Text.Trim())));
                    cmd.Parameters.Add(new OracleParameter("diemCK", Convert.ToDouble(txbDiemCK.Text.Trim())));
                    cmd.Parameters.Add(new OracleParameter("diemTK", Convert.ToDouble(txbDiemTK.Text.Trim())));
                    cmd.Parameters.Add(new OracleParameter("role", this.role));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string studentID = txbSearchRegister.Text.Trim();
                    if (string.IsNullOrEmpty(studentID))
                    {
                        LoadRegisterList();
                    }
                    else
                    {
                        LoadRegisterList(studentID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRegister_Click(object sender, EventArgs e)
        {
            if (this.role != "NV PĐT" && this.role != "SV")
            {
                MessageBox.Show("Bạn không có quyền xóa đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txbRgtStudentID.Text) || string.IsNullOrEmpty(txbRgtOpenSubjectID.Text))
            {
                MessageBox.Show("Vui lòng lựa chọn đăng ký cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.role == "SV" && ConnectionManager.Username != txbRgtStudentID.Text)
            {
                MessageBox.Show("Bạn không có quyền xóa đăng ký của sinh viên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem khoảng cách từ ngày hiện tại đến NgayBD ở bảng MOMON của MAMM đó có lớn hơn 14 hay không
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("QLTDH.CHECK_REGISTER_DELETE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new OracleParameter("openSubjectID", txbRgtOpenSubjectID.Text.Trim()));
                    cmd.Parameters.Add(new OracleParameter("role", this.role));

                    OracleParameter resultParam = new OracleParameter("result", OracleDbType.Int32);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    cmd.ExecuteNonQuery();

                    int result = ((OracleDecimal)resultParam.Value).ToInt32();
                    if (result == 0)
                    {
                        MessageBox.Show("Không thể xóa đăng ký này vì đã quá thời gian cho phép.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa đăng ký này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        OracleCommand deleteCmd = new OracleCommand("QLTDH.DELETE_REGISTER", conn);
                        deleteCmd.CommandType = CommandType.StoredProcedure;

                        deleteCmd.Parameters.Add(new OracleParameter("studentID", txbRgtStudentID.Text.Trim()));
                        deleteCmd.Parameters.Add(new OracleParameter("openSubjectID", txbRgtOpenSubjectID.Text.Trim()));
                        deleteCmd.Parameters.Add(new OracleParameter("role", this.role));

                        deleteCmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string studentID = txbSearchRegister.Text.Trim();
                        if (string.IsNullOrEmpty(studentID))
                        {
                            LoadRegisterList();
                        }
                        else
                        {
                            LoadRegisterList(studentID);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                if (ex.Number == 2292)
                {
                    MessageBox.Show("Không thể xóa đăng ký này vì có liên kết với các bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInsertRegister_Click(object sender, EventArgs e)
        {
            if (this.role != "SV" && this.role != "NV PĐT")
            {
                MessageBox.Show("Bạn không có quyền thêm đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertRegisterForm insertRegisterForm = new InsertRegisterForm(this.role);
            insertRegisterForm.Owner = this;
            insertRegisterForm.ShowDialog();
        }
    }
}
