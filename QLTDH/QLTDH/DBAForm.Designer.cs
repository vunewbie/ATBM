namespace QLTDH
{
    partial class DBAForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tctrlDBA = new System.Windows.Forms.TabControl();
            this.tpageUsers = new System.Windows.Forms.TabPage();
            this.tlpUsers = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tlpUsersButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tlpSearchUser = new System.Windows.Forms.TableLayoutPanel();
            this.txbSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.tpageRoles = new System.Windows.Forms.TabPage();
            this.tlpRoles = new System.Windows.Forms.TableLayoutPanel();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.tlpRolesButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.tlpSearchRole = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchRole = new System.Windows.Forms.Button();
            this.txbSearchRole = new System.Windows.Forms.TextBox();
            this.tpagePrivileges = new System.Windows.Forms.TabPage();
            this.tctrlPrivileges = new System.Windows.Forms.TabControl();
            this.tpageTable = new System.Windows.Forms.TabPage();
            this.dgvTablePrivilege = new System.Windows.Forms.DataGridView();
            this.tbl_GRANTEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_OWNER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_GRANTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_PRIVILEGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_GRANTABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_HIERARCHY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_COMMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_INHERITED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpageColumn = new System.Windows.Forms.TabPage();
            this.dgvColumnPrivilege = new System.Windows.Forms.DataGridView();
            this.col_GRANTEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_OWNER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GRANTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PRIVILEGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GRANTABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_COMMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_INHERITED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSearchGrantee = new System.Windows.Forms.Label();
            this.txbSearchGrantee = new System.Windows.Forms.TextBox();
            this.btnRevokePrivilege = new System.Windows.Forms.Button();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tctrlDBA.SuspendLayout();
            this.tpageUsers.SuspendLayout();
            this.tlpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tlpUsersButton.SuspendLayout();
            this.tlpSearchUser.SuspendLayout();
            this.tpageRoles.SuspendLayout();
            this.tlpRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.tlpRolesButton.SuspendLayout();
            this.tlpSearchRole.SuspendLayout();
            this.tpagePrivileges.SuspendLayout();
            this.tctrlPrivileges.SuspendLayout();
            this.tpageTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablePrivilege)).BeginInit();
            this.tpageColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnPrivilege)).BeginInit();
            this.SuspendLayout();
            // 
            // tctrlDBA
            // 
            this.tctrlDBA.Controls.Add(this.tpageUsers);
            this.tctrlDBA.Controls.Add(this.tpageRoles);
            this.tctrlDBA.Controls.Add(this.tpagePrivileges);
            this.tctrlDBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlDBA.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlDBA.ItemSize = new System.Drawing.Size(85, 30);
            this.tctrlDBA.Location = new System.Drawing.Point(0, 0);
            this.tctrlDBA.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tctrlDBA.Name = "tctrlDBA";
            this.tctrlDBA.SelectedIndex = 0;
            this.tctrlDBA.Size = new System.Drawing.Size(1262, 753);
            this.tctrlDBA.TabIndex = 0;
            // 
            // tpageUsers
            // 
            this.tpageUsers.Controls.Add(this.tlpUsers);
            this.tpageUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.tpageUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpageUsers.Location = new System.Drawing.Point(4, 34);
            this.tpageUsers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpageUsers.Name = "tpageUsers";
            this.tpageUsers.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpageUsers.Size = new System.Drawing.Size(1254, 715);
            this.tpageUsers.TabIndex = 0;
            this.tpageUsers.Text = "Users";
            this.tpageUsers.UseVisualStyleBackColor = true;
            this.tpageUsers.Enter += new System.EventHandler(this.tpageUsers_Enter);
            // 
            // tlpUsers
            // 
            this.tlpUsers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpUsers.ColumnCount = 1;
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpUsers.Controls.Add(this.dgvUsers, 0, 0);
            this.tlpUsers.Controls.Add(this.tlpUsersButton, 0, 1);
            this.tlpUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsers.Location = new System.Drawing.Point(5, 6);
            this.tlpUsers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpUsers.Name = "tlpUsers";
            this.tlpUsers.RowCount = 2;
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpUsers.Size = new System.Drawing.Size(1244, 703);
            this.tlpUsers.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(8, 9);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 30;
            this.dgvUsers.Size = new System.Drawing.Size(1228, 473);
            this.dgvUsers.TabIndex = 0;
            // 
            // tlpUsersButton
            // 
            this.tlpUsersButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpUsersButton.ColumnCount = 4;
            this.tlpUsersButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersButton.Controls.Add(this.btnCreateUser, 0, 0);
            this.tlpUsersButton.Controls.Add(this.btnUpdateUser, 1, 0);
            this.tlpUsersButton.Controls.Add(this.btnDeleteUser, 2, 0);
            this.tlpUsersButton.Controls.Add(this.tlpSearchUser, 3, 0);
            this.tlpUsersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsersButton.Location = new System.Drawing.Point(8, 497);
            this.tlpUsersButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpUsersButton.Name = "tlpUsersButton";
            this.tlpUsersButton.RowCount = 1;
            this.tlpUsersButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsersButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tlpUsersButton.Size = new System.Drawing.Size(1228, 197);
            this.tlpUsersButton.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateUser.Location = new System.Drawing.Point(8, 9);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(293, 179);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Tạo người dùng";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateUser.Location = new System.Drawing.Point(314, 9);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(293, 179);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Cập nhật người dùng";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(620, 9);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(293, 179);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Xóa người dùng";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tlpSearchUser
            // 
            this.tlpSearchUser.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpSearchUser.ColumnCount = 1;
            this.tlpSearchUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSearchUser.Controls.Add(this.txbSearchUser, 0, 0);
            this.tlpSearchUser.Controls.Add(this.btnSearchUser, 0, 1);
            this.tlpSearchUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchUser.Location = new System.Drawing.Point(926, 9);
            this.tlpSearchUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpSearchUser.Name = "tlpSearchUser";
            this.tlpSearchUser.RowCount = 2;
            this.tlpSearchUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchUser.Size = new System.Drawing.Size(294, 179);
            this.tlpSearchUser.TabIndex = 3;
            // 
            // txbSearchUser
            // 
            this.txbSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchUser.Location = new System.Drawing.Point(8, 29);
            this.txbSearchUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearchUser.Name = "txbSearchUser";
            this.txbSearchUser.Size = new System.Drawing.Size(278, 32);
            this.txbSearchUser.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchUser.Location = new System.Drawing.Point(8, 97);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(278, 73);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Tìm kiếm";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // tpageRoles
            // 
            this.tpageRoles.BackColor = System.Drawing.SystemColors.Control;
            this.tpageRoles.Controls.Add(this.tlpRoles);
            this.tpageRoles.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpageRoles.Location = new System.Drawing.Point(4, 34);
            this.tpageRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpageRoles.Name = "tpageRoles";
            this.tpageRoles.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpageRoles.Size = new System.Drawing.Size(1254, 715);
            this.tpageRoles.TabIndex = 1;
            this.tpageRoles.Text = "Roles";
            this.tpageRoles.Enter += new System.EventHandler(this.tpageRoles_Enter);
            // 
            // tlpRoles
            // 
            this.tlpRoles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpRoles.ColumnCount = 1;
            this.tlpRoles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpRoles.Controls.Add(this.dgvRoles, 0, 0);
            this.tlpRoles.Controls.Add(this.tlpRolesButton, 0, 1);
            this.tlpRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoles.Location = new System.Drawing.Point(5, 6);
            this.tlpRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpRoles.Name = "tlpRoles";
            this.tlpRoles.RowCount = 2;
            this.tlpRoles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpRoles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRoles.Size = new System.Drawing.Size(1244, 703);
            this.tlpRoles.TabIndex = 0;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(8, 9);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvRoles.MaximumSize = new System.Drawing.Size(2345, 845);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 30;
            this.dgvRoles.Size = new System.Drawing.Size(1228, 473);
            this.dgvRoles.TabIndex = 0;
            // 
            // tlpRolesButton
            // 
            this.tlpRolesButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpRolesButton.ColumnCount = 4;
            this.tlpRolesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRolesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRolesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRolesButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpRolesButton.Controls.Add(this.btnDeleteRole, 2, 0);
            this.tlpRolesButton.Controls.Add(this.btnUpdateRole, 1, 0);
            this.tlpRolesButton.Controls.Add(this.btnCreateRole, 0, 0);
            this.tlpRolesButton.Controls.Add(this.tlpSearchRole, 3, 0);
            this.tlpRolesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRolesButton.Location = new System.Drawing.Point(8, 497);
            this.tlpRolesButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpRolesButton.Name = "tlpRolesButton";
            this.tlpRolesButton.RowCount = 1;
            this.tlpRolesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRolesButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tlpRolesButton.Size = new System.Drawing.Size(1228, 197);
            this.tlpRolesButton.TabIndex = 1;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteRole.Location = new System.Drawing.Point(620, 9);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(293, 179);
            this.btnDeleteRole.TabIndex = 2;
            this.btnDeleteRole.Text = "Xóa vai trò";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateRole.Location = new System.Drawing.Point(314, 9);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(293, 179);
            this.btnUpdateRole.TabIndex = 1;
            this.btnUpdateRole.Text = "Cập nhật vai trò";
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateRole.Location = new System.Drawing.Point(8, 9);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(293, 179);
            this.btnCreateRole.TabIndex = 0;
            this.btnCreateRole.Text = "Tạo vai trò";
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // tlpSearchRole
            // 
            this.tlpSearchRole.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpSearchRole.ColumnCount = 1;
            this.tlpSearchRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSearchRole.Controls.Add(this.btnSearchRole, 0, 1);
            this.tlpSearchRole.Controls.Add(this.txbSearchRole, 0, 0);
            this.tlpSearchRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchRole.Location = new System.Drawing.Point(926, 9);
            this.tlpSearchRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpSearchRole.Name = "tlpSearchRole";
            this.tlpSearchRole.RowCount = 2;
            this.tlpSearchRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchRole.Size = new System.Drawing.Size(294, 179);
            this.tlpSearchRole.TabIndex = 3;
            // 
            // btnSearchRole
            // 
            this.btnSearchRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearchRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchRole.Location = new System.Drawing.Point(8, 97);
            this.btnSearchRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearchRole.Name = "btnSearchRole";
            this.btnSearchRole.Size = new System.Drawing.Size(278, 73);
            this.btnSearchRole.TabIndex = 3;
            this.btnSearchRole.Text = "Tìm kiếm";
            this.btnSearchRole.UseVisualStyleBackColor = false;
            this.btnSearchRole.Click += new System.EventHandler(this.btnSearchRole_Click);
            // 
            // txbSearchRole
            // 
            this.txbSearchRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchRole.Location = new System.Drawing.Point(8, 29);
            this.txbSearchRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearchRole.Name = "txbSearchRole";
            this.txbSearchRole.Size = new System.Drawing.Size(278, 32);
            this.txbSearchRole.TabIndex = 0;
            // 
            // tpagePrivileges
            // 
            this.tpagePrivileges.BackColor = System.Drawing.SystemColors.Control;
            this.tpagePrivileges.Controls.Add(this.btnRefresh);
            this.tpagePrivileges.Controls.Add(this.tctrlPrivileges);
            this.tpagePrivileges.Controls.Add(this.lbSearchGrantee);
            this.tpagePrivileges.Controls.Add(this.txbSearchGrantee);
            this.tpagePrivileges.Controls.Add(this.btnRevokePrivilege);
            this.tpagePrivileges.Controls.Add(this.btnGrantPrivilege);
            this.tpagePrivileges.Location = new System.Drawing.Point(4, 34);
            this.tpagePrivileges.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpagePrivileges.Name = "tpagePrivileges";
            this.tpagePrivileges.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpagePrivileges.Size = new System.Drawing.Size(1254, 715);
            this.tpagePrivileges.TabIndex = 2;
            this.tpagePrivileges.Text = "Privileges";
            this.tpagePrivileges.Enter += new System.EventHandler(this.tpagePrivileges_Enter);
            // 
            // tctrlPrivileges
            // 
            this.tctrlPrivileges.Controls.Add(this.tpageTable);
            this.tctrlPrivileges.Controls.Add(this.tpageColumn);
            this.tctrlPrivileges.Location = new System.Drawing.Point(37, 95);
            this.tctrlPrivileges.Name = "tctrlPrivileges";
            this.tctrlPrivileges.SelectedIndex = 0;
            this.tctrlPrivileges.Size = new System.Drawing.Size(1179, 611);
            this.tctrlPrivileges.TabIndex = 11;
            // 
            // tpageTable
            // 
            this.tpageTable.Controls.Add(this.dgvTablePrivilege);
            this.tpageTable.Location = new System.Drawing.Point(4, 28);
            this.tpageTable.Name = "tpageTable";
            this.tpageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpageTable.Size = new System.Drawing.Size(1171, 579);
            this.tpageTable.TabIndex = 0;
            this.tpageTable.Text = "Table";
            this.tpageTable.UseVisualStyleBackColor = true;
            this.tpageTable.Enter += new System.EventHandler(this.tpageTable_Enter);
            // 
            // dgvTablePrivilege
            // 
            this.dgvTablePrivilege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTablePrivilege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablePrivilege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablePrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablePrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl_GRANTEE,
            this.tbl_OWNER,
            this.tbl_TABLE_NAME,
            this.tbl_GRANTOR,
            this.tbl_PRIVILEGE,
            this.tbl_GRANTABLE,
            this.tbl_HIERARCHY,
            this.tbl_COMMON,
            this.tbl_TYPE,
            this.tbl_INHERITED});
            this.dgvTablePrivilege.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTablePrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablePrivilege.Location = new System.Drawing.Point(3, 3);
            this.dgvTablePrivilege.Name = "dgvTablePrivilege";
            this.dgvTablePrivilege.RowHeadersWidth = 51;
            this.dgvTablePrivilege.RowTemplate.Height = 30;
            this.dgvTablePrivilege.Size = new System.Drawing.Size(1165, 573);
            this.dgvTablePrivilege.TabIndex = 1;
            // 
            // tbl_GRANTEE
            // 
            this.tbl_GRANTEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_GRANTEE.DataPropertyName = "GRANTEE";
            this.tbl_GRANTEE.HeaderText = "GRANTEE";
            this.tbl_GRANTEE.MinimumWidth = 6;
            this.tbl_GRANTEE.Name = "tbl_GRANTEE";
            this.tbl_GRANTEE.ReadOnly = true;
            this.tbl_GRANTEE.Width = 118;
            // 
            // tbl_OWNER
            // 
            this.tbl_OWNER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_OWNER.DataPropertyName = "OWNER";
            this.tbl_OWNER.HeaderText = "OWNER";
            this.tbl_OWNER.MinimumWidth = 6;
            this.tbl_OWNER.Name = "tbl_OWNER";
            this.tbl_OWNER.ReadOnly = true;
            // 
            // tbl_TABLE_NAME
            // 
            this.tbl_TABLE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.tbl_TABLE_NAME.HeaderText = "TABLE_NAME";
            this.tbl_TABLE_NAME.MinimumWidth = 6;
            this.tbl_TABLE_NAME.Name = "tbl_TABLE_NAME";
            this.tbl_TABLE_NAME.ReadOnly = true;
            this.tbl_TABLE_NAME.Width = 152;
            // 
            // tbl_GRANTOR
            // 
            this.tbl_GRANTOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_GRANTOR.DataPropertyName = "GRANTOR";
            this.tbl_GRANTOR.HeaderText = "GRANTOR";
            this.tbl_GRANTOR.MinimumWidth = 6;
            this.tbl_GRANTOR.Name = "tbl_GRANTOR";
            this.tbl_GRANTOR.ReadOnly = true;
            this.tbl_GRANTOR.Width = 121;
            // 
            // tbl_PRIVILEGE
            // 
            this.tbl_PRIVILEGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_PRIVILEGE.DataPropertyName = "PRIVILEGE";
            this.tbl_PRIVILEGE.HeaderText = "PRIVILEGE";
            this.tbl_PRIVILEGE.MinimumWidth = 6;
            this.tbl_PRIVILEGE.Name = "tbl_PRIVILEGE";
            this.tbl_PRIVILEGE.ReadOnly = true;
            this.tbl_PRIVILEGE.Width = 127;
            // 
            // tbl_GRANTABLE
            // 
            this.tbl_GRANTABLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_GRANTABLE.DataPropertyName = "GRANTABLE";
            this.tbl_GRANTABLE.HeaderText = "GRANTABLE";
            this.tbl_GRANTABLE.MinimumWidth = 6;
            this.tbl_GRANTABLE.Name = "tbl_GRANTABLE";
            this.tbl_GRANTABLE.ReadOnly = true;
            this.tbl_GRANTABLE.Width = 141;
            // 
            // tbl_HIERARCHY
            // 
            this.tbl_HIERARCHY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_HIERARCHY.DataPropertyName = "HIERARCHY";
            this.tbl_HIERARCHY.HeaderText = "HIERARCHY";
            this.tbl_HIERARCHY.MinimumWidth = 6;
            this.tbl_HIERARCHY.Name = "tbl_HIERARCHY";
            this.tbl_HIERARCHY.ReadOnly = true;
            this.tbl_HIERARCHY.Width = 138;
            // 
            // tbl_COMMON
            // 
            this.tbl_COMMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_COMMON.DataPropertyName = "COMMON";
            this.tbl_COMMON.HeaderText = "COMMON";
            this.tbl_COMMON.MinimumWidth = 6;
            this.tbl_COMMON.Name = "tbl_COMMON";
            this.tbl_COMMON.ReadOnly = true;
            this.tbl_COMMON.Width = 117;
            // 
            // tbl_TYPE
            // 
            this.tbl_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tbl_TYPE.DataPropertyName = "TYPE";
            this.tbl_TYPE.HeaderText = "TYPE";
            this.tbl_TYPE.MinimumWidth = 6;
            this.tbl_TYPE.Name = "tbl_TYPE";
            this.tbl_TYPE.ReadOnly = true;
            this.tbl_TYPE.Width = 81;
            // 
            // tbl_INHERITED
            // 
            this.tbl_INHERITED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tbl_INHERITED.DataPropertyName = "INHERITED";
            this.tbl_INHERITED.HeaderText = "INHERITED";
            this.tbl_INHERITED.MinimumWidth = 6;
            this.tbl_INHERITED.Name = "tbl_INHERITED";
            this.tbl_INHERITED.ReadOnly = true;
            this.tbl_INHERITED.Width = 131;
            // 
            // tpageColumn
            // 
            this.tpageColumn.Controls.Add(this.dgvColumnPrivilege);
            this.tpageColumn.Location = new System.Drawing.Point(4, 28);
            this.tpageColumn.Name = "tpageColumn";
            this.tpageColumn.Padding = new System.Windows.Forms.Padding(3);
            this.tpageColumn.Size = new System.Drawing.Size(1171, 579);
            this.tpageColumn.TabIndex = 1;
            this.tpageColumn.Text = "Column";
            this.tpageColumn.UseVisualStyleBackColor = true;
            this.tpageColumn.Enter += new System.EventHandler(this.tpageColumn_Enter);
            // 
            // dgvColumnPrivilege
            // 
            this.dgvColumnPrivilege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvColumnPrivilege.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColumnPrivilege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColumnPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_GRANTEE,
            this.col_OWNER,
            this.col_TABLE_NAME,
            this.col_COLUMN_NAME,
            this.col_GRANTOR,
            this.col_PRIVILEGE,
            this.col_GRANTABLE,
            this.col_COMMON,
            this.col_INHERITED});
            this.dgvColumnPrivilege.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvColumnPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumnPrivilege.Location = new System.Drawing.Point(3, 3);
            this.dgvColumnPrivilege.Name = "dgvColumnPrivilege";
            this.dgvColumnPrivilege.RowHeadersWidth = 51;
            this.dgvColumnPrivilege.RowTemplate.Height = 30;
            this.dgvColumnPrivilege.Size = new System.Drawing.Size(1165, 573);
            this.dgvColumnPrivilege.TabIndex = 5;
            // 
            // col_GRANTEE
            // 
            this.col_GRANTEE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_GRANTEE.DataPropertyName = "GRANTEE";
            this.col_GRANTEE.HeaderText = "GRANTEE";
            this.col_GRANTEE.MinimumWidth = 6;
            this.col_GRANTEE.Name = "col_GRANTEE";
            this.col_GRANTEE.ReadOnly = true;
            this.col_GRANTEE.Width = 118;
            // 
            // col_OWNER
            // 
            this.col_OWNER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_OWNER.DataPropertyName = "OWNER";
            this.col_OWNER.HeaderText = "OWNER";
            this.col_OWNER.MinimumWidth = 6;
            this.col_OWNER.Name = "col_OWNER";
            this.col_OWNER.ReadOnly = true;
            // 
            // col_TABLE_NAME
            // 
            this.col_TABLE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.col_TABLE_NAME.HeaderText = "TABLE_NAME";
            this.col_TABLE_NAME.MinimumWidth = 6;
            this.col_TABLE_NAME.Name = "col_TABLE_NAME";
            this.col_TABLE_NAME.ReadOnly = true;
            this.col_TABLE_NAME.Width = 152;
            // 
            // col_COLUMN_NAME
            // 
            this.col_COLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            this.col_COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.col_COLUMN_NAME.Name = "col_COLUMN_NAME";
            this.col_COLUMN_NAME.ReadOnly = true;
            this.col_COLUMN_NAME.Width = 173;
            // 
            // col_GRANTOR
            // 
            this.col_GRANTOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_GRANTOR.DataPropertyName = "GRANTOR";
            this.col_GRANTOR.HeaderText = "GRANTOR";
            this.col_GRANTOR.MinimumWidth = 6;
            this.col_GRANTOR.Name = "col_GRANTOR";
            this.col_GRANTOR.ReadOnly = true;
            this.col_GRANTOR.Width = 121;
            // 
            // col_PRIVILEGE
            // 
            this.col_PRIVILEGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_PRIVILEGE.DataPropertyName = "PRIVILEGE";
            this.col_PRIVILEGE.HeaderText = "PRIVILEGE";
            this.col_PRIVILEGE.MinimumWidth = 6;
            this.col_PRIVILEGE.Name = "col_PRIVILEGE";
            this.col_PRIVILEGE.ReadOnly = true;
            this.col_PRIVILEGE.Width = 127;
            // 
            // col_GRANTABLE
            // 
            this.col_GRANTABLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_GRANTABLE.DataPropertyName = "GRANTABLE";
            this.col_GRANTABLE.HeaderText = "GRANTABLE";
            this.col_GRANTABLE.MinimumWidth = 6;
            this.col_GRANTABLE.Name = "col_GRANTABLE";
            this.col_GRANTABLE.ReadOnly = true;
            this.col_GRANTABLE.Width = 141;
            // 
            // col_COMMON
            // 
            this.col_COMMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_COMMON.DataPropertyName = "COMMON";
            this.col_COMMON.HeaderText = "COMMON";
            this.col_COMMON.MinimumWidth = 6;
            this.col_COMMON.Name = "col_COMMON";
            this.col_COMMON.ReadOnly = true;
            this.col_COMMON.Width = 117;
            // 
            // col_INHERITED
            // 
            this.col_INHERITED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_INHERITED.DataPropertyName = "INHERITED";
            this.col_INHERITED.HeaderText = "INHERITED";
            this.col_INHERITED.MinimumWidth = 6;
            this.col_INHERITED.Name = "col_INHERITED";
            this.col_INHERITED.ReadOnly = true;
            this.col_INHERITED.Width = 131;
            // 
            // lbSearchGrantee
            // 
            this.lbSearchGrantee.AutoSize = true;
            this.lbSearchGrantee.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearchGrantee.Location = new System.Drawing.Point(1031, 6);
            this.lbSearchGrantee.Name = "lbSearchGrantee";
            this.lbSearchGrantee.Size = new System.Drawing.Size(178, 20);
            this.lbSearchGrantee.TabIndex = 9;
            this.lbSearchGrantee.Text = "Tìm kiếm theo Grantee";
            // 
            // txbSearchGrantee
            // 
            this.txbSearchGrantee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchGrantee.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchGrantee.Location = new System.Drawing.Point(1035, 32);
            this.txbSearchGrantee.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearchGrantee.Name = "txbSearchGrantee";
            this.txbSearchGrantee.Size = new System.Drawing.Size(174, 27);
            this.txbSearchGrantee.TabIndex = 8;
            this.txbSearchGrantee.TextChanged += new System.EventHandler(this.txbSearchGrantee_TextChanged);
            // 
            // btnRevokePrivilege
            // 
            this.btnRevokePrivilege.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRevokePrivilege.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokePrivilege.Location = new System.Drawing.Point(359, 0);
            this.btnRevokePrivilege.Name = "btnRevokePrivilege";
            this.btnRevokePrivilege.Size = new System.Drawing.Size(254, 76);
            this.btnRevokePrivilege.TabIndex = 6;
            this.btnRevokePrivilege.Text = "Thu hồi quyền của user/role";
            this.btnRevokePrivilege.UseVisualStyleBackColor = false;
            this.btnRevokePrivilege.Click += new System.EventHandler(this.btnRevokePrivilege_Click);
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrantPrivilege.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivilege.Location = new System.Drawing.Point(41, 0);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(276, 76);
            this.btnGrantPrivilege.TabIndex = 5;
            this.btnGrantPrivilege.Text = "Cấp quyền cho user/role";
            this.btnGrantPrivilege.UseVisualStyleBackColor = false;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(1134, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 28);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DBAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.tctrlDBA);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DBAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quản trị";
            this.tctrlDBA.ResumeLayout(false);
            this.tpageUsers.ResumeLayout(false);
            this.tlpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tlpUsersButton.ResumeLayout(false);
            this.tlpSearchUser.ResumeLayout(false);
            this.tlpSearchUser.PerformLayout();
            this.tpageRoles.ResumeLayout(false);
            this.tlpRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.tlpRolesButton.ResumeLayout(false);
            this.tlpSearchRole.ResumeLayout(false);
            this.tlpSearchRole.PerformLayout();
            this.tpagePrivileges.ResumeLayout(false);
            this.tpagePrivileges.PerformLayout();
            this.tctrlPrivileges.ResumeLayout(false);
            this.tpageTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablePrivilege)).EndInit();
            this.tpageColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnPrivilege)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlDBA;
        private System.Windows.Forms.TabPage tpageUsers;
        private System.Windows.Forms.TabPage tpageRoles;
        private System.Windows.Forms.TableLayoutPanel tlpRoles;
        private System.Windows.Forms.TableLayoutPanel tlpUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tpagePrivileges;
        private System.Windows.Forms.TableLayoutPanel tlpUsersButton;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TableLayoutPanel tlpSearchUser;
        private System.Windows.Forms.TextBox txbSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TableLayoutPanel tlpRolesButton;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.TableLayoutPanel tlpSearchRole;
        private System.Windows.Forms.Button btnSearchRole;
        private System.Windows.Forms.TextBox txbSearchRole;
        private System.Windows.Forms.Button btnRevokePrivilege;
        private System.Windows.Forms.Button btnGrantPrivilege;
        private System.Windows.Forms.TextBox txbSearchGrantee;
        private System.Windows.Forms.Label lbSearchGrantee;
        private System.Windows.Forms.TabControl tctrlPrivileges;
        private System.Windows.Forms.TabPage tpageTable;
        private System.Windows.Forms.TabPage tpageColumn;
        private System.Windows.Forms.DataGridView dgvTablePrivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_GRANTEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_OWNER;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_GRANTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_PRIVILEGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_GRANTABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_HIERARCHY;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_COMMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_INHERITED;
        private System.Windows.Forms.DataGridView dgvColumnPrivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GRANTEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_OWNER;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_COLUMN_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GRANTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PRIVILEGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GRANTABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_COMMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_INHERITED;
        private System.Windows.Forms.Button btnRefresh;
    }
}