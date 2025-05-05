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

                    OracleCommand cmd = new OracleCommand("GET_EMPLOYEE_LIST", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
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
            if (e.RowIndex < 0)
                return;

            string MANV = dtgvEmployee.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
            try
            {
                using (OracleConnection conn = ConnectionManager.CreateConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM QLTDH.NHANVIEN WHERE MANV = :manv";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new OracleParameter("manv", MANV));

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txbEmployeeID.Text = reader.GetString(0);
                                txbEmployeeFullname.Text = reader.GetString(1);
                                cbbEmployeeGender.Text = reader.GetString(2);
                                dtpkDOB.Value = reader.GetDateTime(3);
                                txbEmployeeSalary.Text = reader.GetDecimal(4).ToString();
                                txbEmployeeAllowance.Text = reader.GetDecimal(5).ToString();
                                cbbEmployeeRole.Text = reader.GetString(6);
                                cbbUnitID.Text = reader.GetString(7);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
