namespace QLTDH
{
    partial class InsertStudentForm
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
            this.lbInsertStudent = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbStudentDepartment = new System.Windows.Forms.ComboBox();
            this.lbStudentAddress = new System.Windows.Forms.Label();
            this.lbStudentPhone = new System.Windows.Forms.Label();
            this.txbStudentPhone = new System.Windows.Forms.TextBox();
            this.lbStudentDepartment = new System.Windows.Forms.Label();
            this.lbStudentDOB = new System.Windows.Forms.Label();
            this.lbStudentGender = new System.Windows.Forms.Label();
            this.lbStudentFullname = new System.Windows.Forms.Label();
            this.txbStudentFullname = new System.Windows.Forms.TextBox();
            this.cbbStudentGender = new System.Windows.Forms.ComboBox();
            this.dtpkStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.txbStudentAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbInsertStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertEmployee, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.40342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.59658F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 511);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbInsertStudent
            // 
            this.lbInsertStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInsertStudent.AutoSize = true;
            this.lbInsertStudent.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsertStudent.Location = new System.Drawing.Point(313, 19);
            this.lbInsertStudent.Name = "lbInsertStudent";
            this.lbInsertStudent.Size = new System.Drawing.Size(158, 25);
            this.lbInsertStudent.TabIndex = 0;
            this.lbInsertStudent.Text = "Thêm sinh viên";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.81959F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.98969F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33505F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.1134F));
            this.tableLayoutPanel2.Controls.Add(this.txbStudentAddress, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentAddress, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbStudentPhone, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentDOB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentGender, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentFullname, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbStudentFullname, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbStudentGender, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpkStudentDOB, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentPhone, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentDepartment, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbStudentDepartment, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 347);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbbStudentDepartment
            // 
            this.cbbStudentDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbStudentDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStudentDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStudentDepartment.FormattingEnabled = true;
            this.cbbStudentDepartment.Location = new System.Drawing.Point(492, 159);
            this.cbbStudentDepartment.Name = "cbbStudentDepartment";
            this.cbbStudentDepartment.Size = new System.Drawing.Size(246, 27);
            this.cbbStudentDepartment.TabIndex = 13;
            // 
            // lbStudentAddress
            // 
            this.lbStudentAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentAddress.AutoSize = true;
            this.lbStudentAddress.Location = new System.Drawing.Point(404, 279);
            this.lbStudentAddress.Name = "lbStudentAddress";
            this.lbStudentAddress.Size = new System.Drawing.Size(51, 19);
            this.lbStudentAddress.TabIndex = 12;
            this.lbStudentAddress.Text = "Địa chỉ";
            // 
            // lbStudentPhone
            // 
            this.lbStudentPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentPhone.AutoSize = true;
            this.lbStudentPhone.Location = new System.Drawing.Point(395, 48);
            this.lbStudentPhone.Name = "lbStudentPhone";
            this.lbStudentPhone.Size = new System.Drawing.Size(70, 19);
            this.lbStudentPhone.TabIndex = 10;
            this.lbStudentPhone.Text = "Điện thoại";
            // 
            // txbStudentPhone
            // 
            this.txbStudentPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbStudentPhone.Location = new System.Drawing.Point(492, 44);
            this.txbStudentPhone.Name = "txbStudentPhone";
            this.txbStudentPhone.Size = new System.Drawing.Size(246, 26);
            this.txbStudentPhone.TabIndex = 9;
            // 
            // lbStudentDepartment
            // 
            this.lbStudentDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentDepartment.AutoSize = true;
            this.lbStudentDepartment.Location = new System.Drawing.Point(408, 163);
            this.lbStudentDepartment.Name = "lbStudentDepartment";
            this.lbStudentDepartment.Size = new System.Drawing.Size(43, 19);
            this.lbStudentDepartment.TabIndex = 8;
            this.lbStudentDepartment.Text = "Khoa";
            // 
            // lbStudentDOB
            // 
            this.lbStudentDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentDOB.AutoSize = true;
            this.lbStudentDOB.Location = new System.Drawing.Point(23, 279);
            this.lbStudentDOB.Name = "lbStudentDOB";
            this.lbStudentDOB.Size = new System.Drawing.Size(69, 19);
            this.lbStudentDOB.TabIndex = 4;
            this.lbStudentDOB.Text = "Ngày sinh";
            // 
            // lbStudentGender
            // 
            this.lbStudentGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentGender.AutoSize = true;
            this.lbStudentGender.Location = new System.Drawing.Point(40, 163);
            this.lbStudentGender.Name = "lbStudentGender";
            this.lbStudentGender.Size = new System.Drawing.Size(35, 19);
            this.lbStudentGender.TabIndex = 2;
            this.lbStudentGender.Text = "Phái";
            // 
            // lbStudentFullname
            // 
            this.lbStudentFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentFullname.AutoSize = true;
            this.lbStudentFullname.Location = new System.Drawing.Point(32, 48);
            this.lbStudentFullname.Name = "lbStudentFullname";
            this.lbStudentFullname.Size = new System.Drawing.Size(50, 19);
            this.lbStudentFullname.TabIndex = 0;
            this.lbStudentFullname.Text = "Họ tên";
            // 
            // txbStudentFullname
            // 
            this.txbStudentFullname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbStudentFullname.Location = new System.Drawing.Point(118, 44);
            this.txbStudentFullname.Name = "txbStudentFullname";
            this.txbStudentFullname.Size = new System.Drawing.Size(246, 26);
            this.txbStudentFullname.TabIndex = 1;
            // 
            // cbbStudentGender
            // 
            this.cbbStudentGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbStudentGender.FormattingEnabled = true;
            this.cbbStudentGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbStudentGender.Location = new System.Drawing.Point(118, 159);
            this.cbbStudentGender.Name = "cbbStudentGender";
            this.cbbStudentGender.Size = new System.Drawing.Size(246, 27);
            this.cbbStudentGender.TabIndex = 3;
            // 
            // dtpkStudentDOB
            // 
            this.dtpkStudentDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpkStudentDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkStudentDOB.Location = new System.Drawing.Point(118, 275);
            this.dtpkStudentDOB.Name = "dtpkStudentDOB";
            this.dtpkStudentDOB.Size = new System.Drawing.Size(246, 26);
            this.dtpkStudentDOB.TabIndex = 5;
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsertEmployee.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertEmployee.Location = new System.Drawing.Point(324, 442);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(135, 43);
            this.btnInsertEmployee.TabIndex = 16;
            this.btnInsertEmployee.Text = "Thêm";
            this.btnInsertEmployee.UseVisualStyleBackColor = false;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // txbStudentAddress
            // 
            this.txbStudentAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbStudentAddress.Location = new System.Drawing.Point(492, 275);
            this.txbStudentAddress.Name = "txbStudentAddress";
            this.txbStudentAddress.Size = new System.Drawing.Size(246, 26);
            this.txbStudentAddress.TabIndex = 16;
            // 
            // InsertStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InsertStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsertStudentForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbInsertStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbbStudentDepartment;
        private System.Windows.Forms.Label lbStudentAddress;
        private System.Windows.Forms.Label lbStudentPhone;
        private System.Windows.Forms.TextBox txbStudentPhone;
        private System.Windows.Forms.Label lbStudentDepartment;
        private System.Windows.Forms.Label lbStudentDOB;
        private System.Windows.Forms.Label lbStudentGender;
        private System.Windows.Forms.Label lbStudentFullname;
        private System.Windows.Forms.TextBox txbStudentFullname;
        private System.Windows.Forms.ComboBox cbbStudentGender;
        private System.Windows.Forms.DateTimePicker dtpkStudentDOB;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.TextBox txbStudentAddress;
    }
}