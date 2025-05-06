namespace QLTDH
{
    partial class UserDashboardForm
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
            this.tctrlUserDashboard = new System.Windows.Forms.TabControl();
            this.tpgEmployee = new System.Windows.Forms.TabPage();
            this.tlpEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.txbEmployeeSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbEmployeePhone = new System.Windows.Forms.TextBox();
            this.lblEmployeePhone = new System.Windows.Forms.Label();
            this.cbbUnitID = new System.Windows.Forms.ComboBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.cbbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.txbEmployeeAllowance = new System.Windows.Forms.TextBox();
            this.lblEmployeeAllowance = new System.Windows.Forms.Label();
            this.cbbEmployeeGender = new System.Windows.Forms.ComboBox();
            this.lblEmployeeSalary = new System.Windows.Forms.Label();
            this.dtpkDOB = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeDOB = new System.Windows.Forms.Label();
            this.txbEmployeeSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.txbEmployeeFullname = new System.Windows.Forms.TextBox();
            this.lblEmployeeFullname = new System.Windows.Forms.Label();
            this.txbEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tpgSubject = new System.Windows.Forms.TabPage();
            this.tlpOpenSubject = new System.Windows.Forms.TableLayoutPanel();
            this.lblOpenSubject = new System.Windows.Forms.Label();
            this.dtgvOpenSubject = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteOpenSubject = new System.Windows.Forms.Button();
            this.btnUpdateOpenSubject = new System.Windows.Forms.Button();
            this.btnInsertOpenSubject = new System.Windows.Forms.Button();
            this.btnSelectOpenSubject = new System.Windows.Forms.Button();
            this.txbOpenSubjectSearch = new System.Windows.Forms.TextBox();
            this.lblSubjectSearch = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cbbTeacherID = new System.Windows.Forms.ComboBox();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.cbbSubjectID = new System.Windows.Forms.ComboBox();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.txbOpenSubjectID = new System.Windows.Forms.TextBox();
            this.lblOpenSubjectID = new System.Windows.Forms.Label();
            this.tpgStudent = new System.Windows.Forms.TabPage();
            this.tpgRegister = new System.Windows.Forms.TabPage();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.tctrlUserDashboard.SuspendLayout();
            this.tpgEmployee.SuspendLayout();
            this.tlpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpgSubject.SuspendLayout();
            this.tlpOpenSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOpenSubject)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlUserDashboard
            // 
            this.tctrlUserDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctrlUserDashboard.Controls.Add(this.tpgEmployee);
            this.tctrlUserDashboard.Controls.Add(this.tpgSubject);
            this.tctrlUserDashboard.Controls.Add(this.tpgStudent);
            this.tctrlUserDashboard.Controls.Add(this.tpgRegister);
            this.tctrlUserDashboard.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlUserDashboard.ItemSize = new System.Drawing.Size(85, 30);
            this.tctrlUserDashboard.Location = new System.Drawing.Point(0, 14);
            this.tctrlUserDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tctrlUserDashboard.Name = "tctrlUserDashboard";
            this.tctrlUserDashboard.SelectedIndex = 0;
            this.tctrlUserDashboard.Size = new System.Drawing.Size(1260, 701);
            this.tctrlUserDashboard.TabIndex = 0;
            // 
            // tpgEmployee
            // 
            this.tpgEmployee.Controls.Add(this.tlpEmployee);
            this.tpgEmployee.Location = new System.Drawing.Point(4, 34);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEmployee.Size = new System.Drawing.Size(1252, 663);
            this.tpgEmployee.TabIndex = 0;
            this.tpgEmployee.Text = "Nhân viên";
            this.tpgEmployee.UseVisualStyleBackColor = true;
            // 
            // tlpEmployee
            // 
            this.tlpEmployee.ColumnCount = 2;
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.13965F));
            this.tlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86035F));
            this.tlpEmployee.Controls.Add(this.lblEmployee, 0, 0);
            this.tlpEmployee.Controls.Add(this.dtgvEmployee, 0, 1);
            this.tlpEmployee.Controls.Add(this.panel1, 1, 1);
            this.tlpEmployee.Controls.Add(this.panel2, 0, 2);
            this.tlpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployee.Location = new System.Drawing.Point(3, 3);
            this.tlpEmployee.Name = "tlpEmployee";
            this.tlpEmployee.RowCount = 3;
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.421053F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.57895F));
            this.tlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpEmployee.Size = new System.Drawing.Size(1246, 657);
            this.tlpEmployee.TabIndex = 0;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(3, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(1005, 42);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "BẢNG NHÂN VIÊN";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvEmployee.Location = new System.Drawing.Point(3, 45);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersVisible = false;
            this.dtgvEmployee.RowHeadersWidth = 62;
            this.dtgvEmployee.RowTemplate.Height = 28;
            this.dtgvEmployee.Size = new System.Drawing.Size(1005, 458);
            this.dtgvEmployee.TabIndex = 1;
            this.dtgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmployee_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteEmployee);
            this.panel1.Controls.Add(this.btnUpdateEmployee);
            this.panel1.Controls.Add(this.btnInsertEmployee);
            this.panel1.Controls.Add(this.btnSelectEmployee);
            this.panel1.Controls.Add(this.txbEmployeeSearch);
            this.panel1.Controls.Add(this.lblEmployeeSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1014, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 458);
            this.panel1.TabIndex = 2;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(36, 316);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(157, 45);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "Xóa dữ liệu";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(37, 240);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(157, 49);
            this.btnUpdateEmployee.TabIndex = 4;
            this.btnUpdateEmployee.Text = "Cập nhật";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsertEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertEmployee.Location = new System.Drawing.Point(37, 169);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(157, 49);
            this.btnInsertEmployee.TabIndex = 3;
            this.btnInsertEmployee.Text = "Thêm dữ liệu";
            this.btnInsertEmployee.UseVisualStyleBackColor = false;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelectEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectEmployee.Location = new System.Drawing.Point(37, 101);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(157, 46);
            this.btnSelectEmployee.TabIndex = 2;
            this.btnSelectEmployee.Text = "Lấy dữ liệu";
            this.btnSelectEmployee.UseVisualStyleBackColor = false;
            this.btnSelectEmployee.Click += new System.EventHandler(this.btnSelectEmployee_Click);
            // 
            // txbEmployeeSearch
            // 
            this.txbEmployeeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmployeeSearch.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeSearch.Location = new System.Drawing.Point(3, 48);
            this.txbEmployeeSearch.Name = "txbEmployeeSearch";
            this.txbEmployeeSearch.Size = new System.Drawing.Size(223, 37);
            this.txbEmployeeSearch.TabIndex = 1;
            this.txbEmployeeSearch.TextChanged += new System.EventHandler(this.txbEmployeeSearch_TextChanged);
            // 
            // lblEmployeeSearch
            // 
            this.lblEmployeeSearch.AutoSize = true;
            this.lblEmployeeSearch.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSearch.Location = new System.Drawing.Point(2, 10);
            this.lblEmployeeSearch.Name = "lblEmployeeSearch";
            this.lblEmployeeSearch.Size = new System.Drawing.Size(205, 29);
            this.lblEmployeeSearch.TabIndex = 0;
            this.lblEmployeeSearch.Text = "Tìm kiếm theo tên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbEmployeePhone);
            this.panel2.Controls.Add(this.lblEmployeePhone);
            this.panel2.Controls.Add(this.cbbUnitID);
            this.panel2.Controls.Add(this.lblUnitID);
            this.panel2.Controls.Add(this.cbbEmployeeRole);
            this.panel2.Controls.Add(this.lblEmployeeRole);
            this.panel2.Controls.Add(this.txbEmployeeAllowance);
            this.panel2.Controls.Add(this.lblEmployeeAllowance);
            this.panel2.Controls.Add(this.cbbEmployeeGender);
            this.panel2.Controls.Add(this.lblEmployeeSalary);
            this.panel2.Controls.Add(this.dtpkDOB);
            this.panel2.Controls.Add(this.lblEmployeeDOB);
            this.panel2.Controls.Add(this.txbEmployeeSalary);
            this.panel2.Controls.Add(this.lblEmployeeGender);
            this.panel2.Controls.Add(this.txbEmployeeFullname);
            this.panel2.Controls.Add(this.lblEmployeeFullname);
            this.panel2.Controls.Add(this.txbEmployeeID);
            this.panel2.Controls.Add(this.lblEmployeeID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 145);
            this.panel2.TabIndex = 3;
            // 
            // txbEmployeePhone
            // 
            this.txbEmployeePhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeePhone.Location = new System.Drawing.Point(767, 7);
            this.txbEmployeePhone.Name = "txbEmployeePhone";
            this.txbEmployeePhone.Size = new System.Drawing.Size(223, 35);
            this.txbEmployeePhone.TabIndex = 13;
            // 
            // lblEmployeePhone
            // 
            this.lblEmployeePhone.AutoSize = true;
            this.lblEmployeePhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePhone.Location = new System.Drawing.Point(679, 13);
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.Size = new System.Drawing.Size(55, 27);
            this.lblEmployeePhone.TabIndex = 16;
            this.lblEmployeePhone.Text = "SDT";
            // 
            // cbbUnitID
            // 
            this.cbbUnitID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUnitID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUnitID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUnitID.FormattingEnabled = true;
            this.cbbUnitID.Location = new System.Drawing.Point(766, 98);
            this.cbbUnitID.Name = "cbbUnitID";
            this.cbbUnitID.Size = new System.Drawing.Size(223, 35);
            this.cbbUnitID.TabIndex = 17;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.Location = new System.Drawing.Point(679, 102);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(83, 27);
            this.lblUnitID.TabIndex = 14;
            this.lblUnitID.Text = "Mã ĐV";
            // 
            // cbbEmployeeRole
            // 
            this.cbbEmployeeRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbEmployeeRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEmployeeRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEmployeeRole.FormattingEnabled = true;
            this.cbbEmployeeRole.Items.AddRange(new object[] {
            "NVCB",
            "GV",
            "NV PĐT",
            "NV PKT",
            "NV TCHC",
            "NV CTSV",
            "TRGĐV"});
            this.cbbEmployeeRole.Location = new System.Drawing.Point(766, 53);
            this.cbbEmployeeRole.Name = "cbbEmployeeRole";
            this.cbbEmployeeRole.Size = new System.Drawing.Size(223, 35);
            this.cbbEmployeeRole.TabIndex = 15;
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRole.Location = new System.Drawing.Point(679, 56);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(75, 27);
            this.lblEmployeeRole.TabIndex = 12;
            this.lblEmployeeRole.Text = "Vai trò";
            // 
            // txbEmployeeAllowance
            // 
            this.txbEmployeeAllowance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeAllowance.Location = new System.Drawing.Point(450, 97);
            this.txbEmployeeAllowance.Name = "txbEmployeeAllowance";
            this.txbEmployeeAllowance.Size = new System.Drawing.Size(223, 35);
            this.txbEmployeeAllowance.TabIndex = 11;
            // 
            // lblEmployeeAllowance
            // 
            this.lblEmployeeAllowance.AutoSize = true;
            this.lblEmployeeAllowance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAllowance.Location = new System.Drawing.Point(334, 102);
            this.lblEmployeeAllowance.Name = "lblEmployeeAllowance";
            this.lblEmployeeAllowance.Size = new System.Drawing.Size(90, 27);
            this.lblEmployeeAllowance.TabIndex = 10;
            this.lblEmployeeAllowance.Text = "Phụ cấp";
            // 
            // cbbEmployeeGender
            // 
            this.cbbEmployeeGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEmployeeGender.FormattingEnabled = true;
            this.cbbEmployeeGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbEmployeeGender.Location = new System.Drawing.Point(97, 99);
            this.cbbEmployeeGender.Name = "cbbEmployeeGender";
            this.cbbEmployeeGender.Size = new System.Drawing.Size(223, 35);
            this.cbbEmployeeGender.TabIndex = 9;
            // 
            // lblEmployeeSalary
            // 
            this.lblEmployeeSalary.AutoSize = true;
            this.lblEmployeeSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeSalary.Location = new System.Drawing.Point(337, 56);
            this.lblEmployeeSalary.Name = "lblEmployeeSalary";
            this.lblEmployeeSalary.Size = new System.Drawing.Size(76, 27);
            this.lblEmployeeSalary.TabIndex = 8;
            this.lblEmployeeSalary.Text = "Lương";
            // 
            // dtpkDOB
            // 
            this.dtpkDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDOB.Location = new System.Drawing.Point(450, 7);
            this.dtpkDOB.Name = "dtpkDOB";
            this.dtpkDOB.Size = new System.Drawing.Size(223, 35);
            this.dtpkDOB.TabIndex = 7;
            // 
            // lblEmployeeDOB
            // 
            this.lblEmployeeDOB.AutoSize = true;
            this.lblEmployeeDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDOB.Location = new System.Drawing.Point(335, 11);
            this.lblEmployeeDOB.Name = "lblEmployeeDOB";
            this.lblEmployeeDOB.Size = new System.Drawing.Size(108, 27);
            this.lblEmployeeDOB.TabIndex = 6;
            this.lblEmployeeDOB.Text = "Ngày sinh";
            // 
            // txbEmployeeSalary
            // 
            this.txbEmployeeSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeSalary.Location = new System.Drawing.Point(450, 53);
            this.txbEmployeeSalary.Name = "txbEmployeeSalary";
            this.txbEmployeeSalary.Size = new System.Drawing.Size(223, 35);
            this.txbEmployeeSalary.TabIndex = 5;
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.AutoSize = true;
            this.lblEmployeeGender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeGender.Location = new System.Drawing.Point(10, 104);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(55, 27);
            this.lblEmployeeGender.TabIndex = 4;
            this.lblEmployeeGender.Text = "Phái";
            // 
            // txbEmployeeFullname
            // 
            this.txbEmployeeFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeFullname.Location = new System.Drawing.Point(97, 53);
            this.txbEmployeeFullname.Name = "txbEmployeeFullname";
            this.txbEmployeeFullname.Size = new System.Drawing.Size(223, 35);
            this.txbEmployeeFullname.TabIndex = 3;
            // 
            // lblEmployeeFullname
            // 
            this.lblEmployeeFullname.AutoSize = true;
            this.lblEmployeeFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeFullname.Location = new System.Drawing.Point(10, 59);
            this.lblEmployeeFullname.Name = "lblEmployeeFullname";
            this.lblEmployeeFullname.Size = new System.Drawing.Size(77, 27);
            this.lblEmployeeFullname.TabIndex = 2;
            this.lblEmployeeFullname.Text = "Họ tên";
            // 
            // txbEmployeeID
            // 
            this.txbEmployeeID.Enabled = false;
            this.txbEmployeeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmployeeID.Location = new System.Drawing.Point(97, 7);
            this.txbEmployeeID.Name = "txbEmployeeID";
            this.txbEmployeeID.Size = new System.Drawing.Size(223, 35);
            this.txbEmployeeID.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(10, 11);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(83, 27);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Mã NV";
            // 
            // tpgSubject
            // 
            this.tpgSubject.Controls.Add(this.tlpOpenSubject);
            this.tpgSubject.Location = new System.Drawing.Point(4, 34);
            this.tpgSubject.Name = "tpgSubject";
            this.tpgSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSubject.Size = new System.Drawing.Size(1252, 663);
            this.tpgSubject.TabIndex = 1;
            this.tpgSubject.Text = "Mở môn";
            this.tpgSubject.UseVisualStyleBackColor = true;
            // 
            // tlpOpenSubject
            // 
            this.tlpOpenSubject.ColumnCount = 2;
            this.tlpOpenSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.14F));
            this.tlpOpenSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.86F));
            this.tlpOpenSubject.Controls.Add(this.lblOpenSubject, 0, 0);
            this.tlpOpenSubject.Controls.Add(this.dtgvOpenSubject, 0, 1);
            this.tlpOpenSubject.Controls.Add(this.panel3, 1, 1);
            this.tlpOpenSubject.Controls.Add(this.panel4, 0, 2);
            this.tlpOpenSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOpenSubject.Location = new System.Drawing.Point(3, 3);
            this.tlpOpenSubject.Name = "tlpOpenSubject";
            this.tlpOpenSubject.RowCount = 3;
            this.tlpOpenSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.42F));
            this.tlpOpenSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.58F));
            this.tlpOpenSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpOpenSubject.Size = new System.Drawing.Size(1246, 657);
            this.tlpOpenSubject.TabIndex = 0;
            // 
            // lblOpenSubject
            // 
            this.lblOpenSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpenSubject.AutoSize = true;
            this.lblOpenSubject.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenSubject.Location = new System.Drawing.Point(392, 5);
            this.lblOpenSubject.Name = "lblOpenSubject";
            this.lblOpenSubject.Size = new System.Drawing.Size(226, 32);
            this.lblOpenSubject.TabIndex = 0;
            this.lblOpenSubject.Text = "BẢNG MỞ MÔN";
            // 
            // dtgvOpenSubject
            // 
            this.dtgvOpenSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvOpenSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOpenSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvOpenSubject.Location = new System.Drawing.Point(3, 45);
            this.dtgvOpenSubject.Name = "dtgvOpenSubject";
            this.dtgvOpenSubject.RowHeadersVisible = false;
            this.dtgvOpenSubject.RowHeadersWidth = 62;
            this.dtgvOpenSubject.RowTemplate.Height = 28;
            this.dtgvOpenSubject.Size = new System.Drawing.Size(1005, 458);
            this.dtgvOpenSubject.TabIndex = 1;
            this.dtgvOpenSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOpenSubject_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteOpenSubject);
            this.panel3.Controls.Add(this.btnUpdateOpenSubject);
            this.panel3.Controls.Add(this.btnInsertOpenSubject);
            this.panel3.Controls.Add(this.btnSelectOpenSubject);
            this.panel3.Controls.Add(this.txbOpenSubjectSearch);
            this.panel3.Controls.Add(this.lblSubjectSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1014, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 458);
            this.panel3.TabIndex = 2;
            // 
            // btnDeleteOpenSubject
            // 
            this.btnDeleteOpenSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOpenSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteOpenSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOpenSubject.Location = new System.Drawing.Point(36, 316);
            this.btnDeleteOpenSubject.Name = "btnDeleteOpenSubject";
            this.btnDeleteOpenSubject.Size = new System.Drawing.Size(157, 45);
            this.btnDeleteOpenSubject.TabIndex = 10;
            this.btnDeleteOpenSubject.Text = "Xóa dữ liệu";
            this.btnDeleteOpenSubject.UseVisualStyleBackColor = false;
            this.btnDeleteOpenSubject.Click += new System.EventHandler(this.btnDeleteOpenSubject_Click);
            // 
            // btnUpdateOpenSubject
            // 
            this.btnUpdateOpenSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateOpenSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateOpenSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOpenSubject.Location = new System.Drawing.Point(37, 240);
            this.btnUpdateOpenSubject.Name = "btnUpdateOpenSubject";
            this.btnUpdateOpenSubject.Size = new System.Drawing.Size(157, 49);
            this.btnUpdateOpenSubject.TabIndex = 9;
            this.btnUpdateOpenSubject.Text = "Cập nhật";
            this.btnUpdateOpenSubject.UseVisualStyleBackColor = false;
            this.btnUpdateOpenSubject.Click += new System.EventHandler(this.btnUpdateOpenSubject_Click);
            // 
            // btnInsertOpenSubject
            // 
            this.btnInsertOpenSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertOpenSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsertOpenSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOpenSubject.Location = new System.Drawing.Point(37, 169);
            this.btnInsertOpenSubject.Name = "btnInsertOpenSubject";
            this.btnInsertOpenSubject.Size = new System.Drawing.Size(157, 49);
            this.btnInsertOpenSubject.TabIndex = 8;
            this.btnInsertOpenSubject.Text = "Thêm dữ liệu";
            this.btnInsertOpenSubject.UseVisualStyleBackColor = false;
            this.btnInsertOpenSubject.Click += new System.EventHandler(this.btnInsertOpenSubject_Click);
            // 
            // btnSelectOpenSubject
            // 
            this.btnSelectOpenSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectOpenSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSelectOpenSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOpenSubject.Location = new System.Drawing.Point(37, 101);
            this.btnSelectOpenSubject.Name = "btnSelectOpenSubject";
            this.btnSelectOpenSubject.Size = new System.Drawing.Size(157, 46);
            this.btnSelectOpenSubject.TabIndex = 7;
            this.btnSelectOpenSubject.Text = "Lấy dữ liệu";
            this.btnSelectOpenSubject.UseVisualStyleBackColor = false;
            this.btnSelectOpenSubject.Click += new System.EventHandler(this.btnSelectOpenSubject_Click);
            // 
            // txbOpenSubjectSearch
            // 
            this.txbOpenSubjectSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbOpenSubjectSearch.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOpenSubjectSearch.Location = new System.Drawing.Point(3, 48);
            this.txbOpenSubjectSearch.Name = "txbOpenSubjectSearch";
            this.txbOpenSubjectSearch.Size = new System.Drawing.Size(223, 37);
            this.txbOpenSubjectSearch.TabIndex = 6;
            this.txbOpenSubjectSearch.TextChanged += new System.EventHandler(this.txbOpenSubjectSearch_TextChanged);
            // 
            // lblSubjectSearch
            // 
            this.lblSubjectSearch.AutoSize = true;
            this.lblSubjectSearch.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectSearch.Location = new System.Drawing.Point(2, 10);
            this.lblSubjectSearch.Name = "lblSubjectSearch";
            this.lblSubjectSearch.Size = new System.Drawing.Size(205, 29);
            this.lblSubjectSearch.TabIndex = 1;
            this.lblSubjectSearch.Text = "Tìm kiếm theo tên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbYear);
            this.panel4.Controls.Add(this.lblYear);
            this.panel4.Controls.Add(this.cbbSemester);
            this.panel4.Controls.Add(this.lblSemester);
            this.panel4.Controls.Add(this.cbbTeacherID);
            this.panel4.Controls.Add(this.lblTeacherID);
            this.panel4.Controls.Add(this.cbbSubjectID);
            this.panel4.Controls.Add(this.lblSubjectID);
            this.panel4.Controls.Add(this.txbOpenSubjectID);
            this.panel4.Controls.Add(this.lblOpenSubjectID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 145);
            this.panel4.TabIndex = 3;
            // 
            // txbYear
            // 
            this.txbYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbYear.Location = new System.Drawing.Point(669, 57);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(220, 35);
            this.txbYear.TabIndex = 10;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(581, 63);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 27);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Năm";
            // 
            // cbbSemester
            // 
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.Location = new System.Drawing.Point(669, 5);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(220, 41);
            this.cbbSemester.TabIndex = 8;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(581, 9);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(82, 27);
            this.lblSemester.TabIndex = 7;
            this.lblSemester.Text = "Học kỳ";
            // 
            // cbbTeacherID
            // 
            this.cbbTeacherID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTeacherID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTeacherID.FormattingEnabled = true;
            this.cbbTeacherID.Location = new System.Drawing.Point(149, 98);
            this.cbbTeacherID.Name = "cbbTeacherID";
            this.cbbTeacherID.Size = new System.Drawing.Size(220, 41);
            this.cbbTeacherID.TabIndex = 6;
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(51, 105);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(83, 27);
            this.lblTeacherID.TabIndex = 5;
            this.lblTeacherID.Text = "Mã GV";
            // 
            // cbbSubjectID
            // 
            this.cbbSubjectID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSubjectID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSubjectID.FormattingEnabled = true;
            this.cbbSubjectID.Location = new System.Drawing.Point(149, 49);
            this.cbbSubjectID.Name = "cbbSubjectID";
            this.cbbSubjectID.Size = new System.Drawing.Size(220, 41);
            this.cbbSubjectID.TabIndex = 4;
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(51, 57);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(81, 27);
            this.lblSubjectID.TabIndex = 3;
            this.lblSubjectID.Text = "Mã HP";
            // 
            // txbOpenSubjectID
            // 
            this.txbOpenSubjectID.Enabled = false;
            this.txbOpenSubjectID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOpenSubjectID.Location = new System.Drawing.Point(151, 5);
            this.txbOpenSubjectID.Name = "txbOpenSubjectID";
            this.txbOpenSubjectID.Size = new System.Drawing.Size(218, 35);
            this.txbOpenSubjectID.TabIndex = 2;
            // 
            // lblOpenSubjectID
            // 
            this.lblOpenSubjectID.AutoSize = true;
            this.lblOpenSubjectID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenSubjectID.Location = new System.Drawing.Point(51, 9);
            this.lblOpenSubjectID.Name = "lblOpenSubjectID";
            this.lblOpenSubjectID.Size = new System.Drawing.Size(92, 27);
            this.lblOpenSubjectID.TabIndex = 1;
            this.lblOpenSubjectID.Text = "Mã MM";
            // 
            // tpgStudent
            // 
            this.tpgStudent.Location = new System.Drawing.Point(4, 34);
            this.tpgStudent.Name = "tpgStudent";
            this.tpgStudent.Size = new System.Drawing.Size(1252, 663);
            this.tpgStudent.TabIndex = 2;
            this.tpgStudent.Text = "Sinh viên";
            this.tpgStudent.UseVisualStyleBackColor = true;
            // 
            // tpgRegister
            // 
            this.tpgRegister.Location = new System.Drawing.Point(4, 34);
            this.tpgRegister.Name = "tpgRegister";
            this.tpgRegister.Size = new System.Drawing.Size(1252, 663);
            this.tpgRegister.TabIndex = 3;
            this.tpgRegister.Text = "Đăng ký";
            this.tpgRegister.UseVisualStyleBackColor = true;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.RowsToFetchPerRoundTrip = ((long)(0));
            this.oracleCommand1.Transaction = null;
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 715);
            this.Controls.Add(this.tctrlUserDashboard);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang người dùng";
            this.tctrlUserDashboard.ResumeLayout(false);
            this.tpgEmployee.ResumeLayout(false);
            this.tlpEmployee.ResumeLayout(false);
            this.tlpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpgSubject.ResumeLayout(false);
            this.tlpOpenSubject.ResumeLayout(false);
            this.tlpOpenSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOpenSubject)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlUserDashboard;
        private System.Windows.Forms.TabPage tpgEmployee;
        private System.Windows.Forms.TabPage tpgSubject;
        private System.Windows.Forms.TabPage tpgStudent;
        private System.Windows.Forms.TabPage tpgRegister;
        private System.Windows.Forms.TableLayoutPanel tlpEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.TextBox txbEmployeeSearch;
        private System.Windows.Forms.Label lblEmployeeSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.TextBox txbEmployeeFullname;
        private System.Windows.Forms.Label lblEmployeeFullname;
        private System.Windows.Forms.DateTimePicker dtpkDOB;
        private System.Windows.Forms.Label lblEmployeeDOB;
        private System.Windows.Forms.TextBox txbEmployeeSalary;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeSalary;
        private System.Windows.Forms.Label lblEmployeeAllowance;
        private System.Windows.Forms.ComboBox cbbEmployeeGender;
        private System.Windows.Forms.TextBox txbEmployeeAllowance;
        private System.Windows.Forms.ComboBox cbbEmployeeRole;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.ComboBox cbbUnitID;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.Label lblEmployeePhone;
        private System.Windows.Forms.TextBox txbEmployeePhone;
        private System.Windows.Forms.TableLayoutPanel tlpOpenSubject;
        private System.Windows.Forms.Label lblOpenSubject;
        private System.Windows.Forms.DataGridView dtgvOpenSubject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteOpenSubject;
        private System.Windows.Forms.Button btnUpdateOpenSubject;
        private System.Windows.Forms.Button btnInsertOpenSubject;
        private System.Windows.Forms.Button btnSelectOpenSubject;
        private System.Windows.Forms.TextBox txbOpenSubjectSearch;
        private System.Windows.Forms.Label lblSubjectSearch;
        private System.Windows.Forms.TextBox txbOpenSubjectID;
        private System.Windows.Forms.Label lblOpenSubjectID;
        private System.Windows.Forms.ComboBox cbbSubjectID;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cbbTeacherID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.Label lblYear;
    }
}