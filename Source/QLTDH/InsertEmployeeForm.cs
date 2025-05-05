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
    public partial class InsertEmployeeForm : Form
    {
        private string role;
        public InsertEmployeeForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbEmployeeFullname.Text) ||
                string.IsNullOrEmpty(cbbEmployeeGender.Text) ||
                string.IsNullOrEmpty(txbEmployeeSalary.Text) ||
                string.IsNullOrEmpty(txbEmployeeAllowance.Text) ||
                string.IsNullOrEmpty(txbEmployeePhone.Text) ||
                string.IsNullOrEmpty(cbbEmployeeRole.Text) ||
                string.IsNullOrEmpty(cbbUnitName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("INSERT_EMPLOYEE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new OracleParameter("fullname", txbEmployeeFullname.Text));
                    cmd.Parameters.Add(new OracleParameter("gender", cbbEmployeeGender.Text));
                    cmd.Parameters.Add(new OracleParameter("DOB", dtpkDOB.Value)); 
                    cmd.Parameters.Add(new OracleParameter("salary", Convert.ToInt32(txbEmployeeSalary.Text)));
                    cmd.Parameters.Add(new OracleParameter("allowance", Convert.ToInt32(txbEmployeeAllowance.Text)));
                    cmd.Parameters.Add(new OracleParameter("phone", txbEmployeePhone.Text));
                    cmd.Parameters.Add(new OracleParameter("role", cbbEmployeeRole.Text));
                    cmd.Parameters.Add(new OracleParameter("unit", cbbUnitName.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
