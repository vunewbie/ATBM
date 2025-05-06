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
        public InsertEmployeeForm()
        {
            InitializeComponent();
            LoadUnit();
        }
        private void LoadUnit()
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT TENDV FROM QLTDH.DONVI";
                    OracleCommand cmd = new OracleCommand(query,conn);
                    cmd.CommandType = CommandType.Text;

                    OracleDataReader reader = cmd.ExecuteReader();
                    cbbUnitName.Items.Clear();
                    while (reader.Read())
                    {
                        cbbUnitName.Items.Add(reader.GetString(0));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đơn vị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is UserDashboardForm userForm)
            {
                userForm.LoadEmployeeList();
            }
        }

        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();
                    OracleCommand cmd;
                    cmd = new OracleCommand("QLTDH.INSERT_EMPLOYEE", conn);
                    cmd.Parameters.Add(new OracleParameter("fullname", txbEmployeeFullname.Text));
                    cmd.Parameters.Add(new OracleParameter("gender", cbbEmployeeGender.Text));
                    cmd.Parameters.Add(new OracleParameter("DOB", dtpkDOB.Value));
                    cmd.Parameters.Add(new OracleParameter("salary", Convert.ToInt32(txbEmployeeSalary.Text)));
                    cmd.Parameters.Add(new OracleParameter("allowance", Convert.ToInt32(txbEmployeeAllowance.Text)));
                    cmd.Parameters.Add(new OracleParameter("phone", txbEmployeePhone.Text));
                    cmd.Parameters.Add(new OracleParameter("role", cbbEmployeeRole.Text));
                    cmd.Parameters.Add(new OracleParameter("unit", cbbUnitName.Text));

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    if (MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (Owner is UserDashboardForm userForm)
                        {
                            userForm.LoadEmployeeList();
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
