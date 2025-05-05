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
        }
        private void LoadEmployeeList(string name = null)
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

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string name = tbxSearch.Text.Trim();
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
            InsertEmployeeForm newInsertEmployeeForm = new InsertEmployeeForm(this.role);
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

                    OracleCommand cmd = new OracleCommand("UPDATE_EMPLOYEE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new OracleParameter("fullname", txbEmployeeFullname.Text));
                    cmd.Parameters.Add(new OracleParameter("gender", cbbEmployeeGender.Text));
                    cmd.Parameters.Add(new OracleParameter("DOB", dtpkDOB.Value));
                    cmd.Parameters.Add(new OracleParameter("salary", Convert.ToInt32(txbEmployeeSalary.Text)));
                    cmd.Parameters.Add(new OracleParameter("allowance", Convert.ToInt32(txbEmployeeAllowance.Text)));
                    cmd.Parameters.Add(new OracleParameter("phone", txbEmployeePhone.Text));
                    cmd.Parameters.Add(new OracleParameter("role", cbbEmployeeRole.Text));
                    cmd.Parameters.Add(new OracleParameter("unit", cbbUnitID.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chỉnh sửa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
