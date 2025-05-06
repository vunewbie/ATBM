namespace QLTDH
{
    partial class InsertEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInsertEmployee = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbUnitName = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cbbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.txbEmployeePhone = new System.Windows.Forms.TextBox();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.txbEmployeeAllowance = new System.Windows.Forms.TextBox();
            this.lblEmployeeAllowance = new System.Windows.Forms.Label();
            this.txbEmployeeSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.lblEmployeeDOB = new System.Windows.Forms.Label();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.lblEmployeeFullname = new System.Windows.Forms.Label();
            this.txbEmployeeFullname = new System.Windows.Forms.TextBox();
            this.cbbEmployeeGender = new System.Windows.Forms.ComboBox();
            this.dtpkDOB = new System.Windows.Forms.DateTimePicker();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblInsertEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertEmployee, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.40342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.59658F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblInsertEmployee
            // 
            this.lblInsertEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsertEmployee.AutoSize = true;
            this.lblInsertEmployee.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertEmployee.Location = new System.Drawing.Point(272, 13);
            this.lblInsertEmployee.Name = "lblInsertEmployee";
            this.lblInsertEmployee.Size = new System.Drawing.Size(238, 36);
            this.lblInsertEmployee.TabIndex = 0;
            this.lblInsertEmployee.Text = "Thêm nhân viên";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81959F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.98969F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33505F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.1134F));
            this.tableLayoutPanel2.Controls.Add(this.cbbUnitName, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblUnit, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbbEmployeeRole, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeRole, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbEmployeePhone, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeePhone, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txbEmployeeAllowance, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeAllowance, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbEmployeeSalary, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeSalary, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeDOB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeGender, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeFullname, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbEmployeeFullname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbEmployeeGender, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpkDOB, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 66);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 340);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbbUnitName
            // 
            this.cbbUnitName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbUnitName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUnitName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUnitName.FormattingEnabled = true;
            this.cbbUnitName.Location = new System.Drawing.Point(490, 280);
            this.cbbUnitName.Name = "cbbUnitName";
            this.cbbUnitName.Size = new System.Drawing.Size(246, 35);
            this.cbbUnitName.TabIndex = 15;
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(389, 284);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(78, 27);
            this.lblUnit.TabIndex = 14;
            this.lblUnit.Text = "Đơn vị";
            // 
            // cbbEmployeeRole
            // 
            this.cbbEmployeeRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbEmployeeRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEmployeeRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEmployeeRole.FormattingEnabled = true;
            this.cbbEmployeeRole.Items.AddRange(new object[] {
            "NVCB",
            "GV",
            "NV PĐT",
            "NV PKT",
            "NV TCHC",
            "NV CTSV",
            "TRGĐV"});
            this.cbbEmployeeRole.Location = new System.Drawing.Point(490, 195);
            this.cbbEmployeeRole.Name = "cbbEmployeeRole";
            this.cbbEmployeeRole.Size = new System.Drawing.Size(246, 35);
            this.cbbEmployeeRole.TabIndex = 13;
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Location = new System.Drawing.Point(390, 199);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(75, 27);
            this.lblEmployeeRole.TabIndex = 12;
            this.lblEmployeeRole.Text = "Vai trò";
            // 
            // txbEmployeePhone
            // 
            this.txbEmployeePhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEmployeePhone.Location = new System.Drawing.Point(490, 110);
            this.txbEmployeePhone.Name = "txbEmployeePhone";
            this.txbEmployeePhone.Size = new System.Drawing.Size(246, 35);
            this.txbEmployeePhone.TabIndex = 11;
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Location = new System.Drawing.Point(372, 114);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(112, 27);
            this.lblEmployeePhone.TabIndex = 10;
            this.lblEmployeePhone.Text = "Điện thoại";
            // 
            // txbEmployeeAllowance
            // 
            this.txbEmployeeAllowance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEmployeeAllowance.Location = new System.Drawing.Point(490, 25);
            this.txbEmployeeAllowance.Name = "txbEmployeeAllowance";
            this.txbEmployeeAllowance.Size = new System.Drawing.Size(246, 35);
            this.txbEmployeeAllowance.TabIndex = 9;
            // 
            // lblEmployeeAllowance
            // 
            this.lblEmployeeAllowance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeAllowance.AutoSize = true;
            this.lblEmployeeAllowance.Location = new System.Drawing.Point(383, 29);
            this.lblEmployeeAllowance.Name = "lblEmployeeAllowance";
            this.lblEmployeeAllowance.Size = new System.Drawing.Size(90, 27);
            this.lblEmployeeAllowance.TabIndex = 8;
            this.lblEmployeeAllowance.Text = "Phụ cấp";
            // 
            // txbEmployeeSalary
            // 
            this.txbEmployeeSalary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEmployeeSalary.Location = new System.Drawing.Point(117, 280);
            this.txbEmployeeSalary.Name = "txbEmployeeSalary";
            this.txbEmployeeSalary.Size = new System.Drawing.Size(246, 35);
            this.txbEmployeeSalary.TabIndex = 7;
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Location = new System.Drawing.Point(19, 284);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(76, 27);
            this.lblEmployeeSalary.TabIndex = 6;
            this.lblEmployeeSalary.Text = "Lương";
            // 
            // lblEmployeeDOB
            // 
            this.lblEmployeeDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeDOB.AutoSize = true;
            this.lblEmployeeDOB.Location = new System.Drawing.Point(3, 199);
            this.lblEmployeeDOB.Name = "lblEmployeeDOB";
            this.lblEmployeeDOB.Size = new System.Drawing.Size(108, 27);
            this.lblEmployeeDOB.TabIndex = 4;
            this.lblEmployeeDOB.Text = "Ngày sinh";
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeGender.AutoSize = true;
            this.lblEmployeeGender.Location = new System.Drawing.Point(29, 114);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(55, 27);
            this.lblEmployeeGender.TabIndex = 2;
            this.lblEmployeeGender.Text = "Phái";
            // 
            // lblEmployeeFullname
            // 
            this.lblEmployeeFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeFullname.AutoSize = true;
            this.lblEmployeeFullname.Location = new System.Drawing.Point(18, 29);
            this.lblEmployeeFullname.Name = "lblEmployeeFullname";
            this.lblEmployeeFullname.Size = new System.Drawing.Size(77, 27);
            this.lblEmployeeFullname.TabIndex = 0;
            this.lblEmployeeFullname.Text = "Họ tên";
            // 
            // txbEmployeeFullname
            // 
            this.txbEmployeeFullname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbEmployeeFullname.Location = new System.Drawing.Point(117, 25);
            this.txbEmployeeFullname.Name = "txbEmployeeFullname";
            this.txbEmployeeFullname.Size = new System.Drawing.Size(246, 35);
            this.txbEmployeeFullname.TabIndex = 1;
            // 
            // cbbEmployeeGender
            // 
            this.cbbEmployeeGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbEmployeeGender.FormattingEnabled = true;
            this.cbbEmployeeGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbEmployeeGender.Location = new System.Drawing.Point(117, 110);
            this.cbbEmployeeGender.Name = "cbbEmployeeGender";
            this.cbbEmployeeGender.Size = new System.Drawing.Size(246, 35);
            this.cbbEmployeeGender.TabIndex = 3;
            // 
            // dtpkDOB
            // 
            this.dtpkDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpkDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDOB.Location = new System.Drawing.Point(117, 195);
            this.dtpkDOB.Name = "dtpkDOB";
            this.dtpkDOB.Size = new System.Drawing.Size(246, 35);
            this.dtpkDOB.TabIndex = 5;
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsertEmployee.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertEmployee.Location = new System.Drawing.Point(323, 434);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(135, 43);
            this.btnInsertEmployee.TabIndex = 16;
            this.btnInsertEmployee.Text = "Thêm";
            this.btnInsertEmployee.UseVisualStyleBackColor = false;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // InsertEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsertEmployeeForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInsertEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblEmployeeFullname;
        private System.Windows.Forms.TextBox txbEmployeeFullname;
        private System.Windows.Forms.Label lblEmployeeDOB;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.ComboBox cbbEmployeeGender;
        private System.Windows.Forms.DateTimePicker dtpkDOB;
        private System.Windows.Forms.TextBox txbEmployeeSalary;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.TextBox txbEmployeeAllowance;
        private System.Windows.Forms.Label lblEmployeeAllowance;
        private System.Windows.Forms.ComboBox cbbUnitName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cbbEmployeeRole;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.TextBox txbEmployeePhone;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.Button btnInsertEmployee;
    }
}