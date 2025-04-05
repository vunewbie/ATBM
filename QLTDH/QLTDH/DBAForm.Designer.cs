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
            this.btnRevokePrivilege = new System.Windows.Forms.Button();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.txbColumnPrivilege = new System.Windows.Forms.TextBox();
            this.txbTablePrivilege = new System.Windows.Forms.TextBox();
            this.dgvColumnPrivilege = new System.Windows.Forms.DataGridView();
            this.dgvTablePrivilege = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnPrivilege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablePrivilege)).BeginInit();
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
            this.tctrlDBA.UseWaitCursor = true;
            // 
            // tpageUsers
            // 
            this.tpageUsers.Controls.Add(this.tlpUsers);
            this.tpageUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpageUsers.Location = new System.Drawing.Point(4, 34);
            this.tpageUsers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpageUsers.Name = "tpageUsers";
            this.tpageUsers.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpageUsers.Size = new System.Drawing.Size(1254, 715);
            this.tpageUsers.TabIndex = 0;
            this.tpageUsers.Text = "Users";
            this.tpageUsers.UseVisualStyleBackColor = true;
            this.tpageUsers.UseWaitCursor = true;
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
            this.tlpUsers.UseWaitCursor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(8, 9);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1228, 473);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.UseWaitCursor = true;
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
            this.tlpUsersButton.UseWaitCursor = true;
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
            this.btnCreateUser.UseWaitCursor = true;
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
            this.btnUpdateUser.UseWaitCursor = true;
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
            this.btnDeleteUser.UseWaitCursor = true;
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
            this.tlpSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchUser.Location = new System.Drawing.Point(926, 9);
            this.tlpSearchUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpSearchUser.Name = "tlpSearchUser";
            this.tlpSearchUser.RowCount = 2;
            this.tlpSearchUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchUser.Size = new System.Drawing.Size(294, 179);
            this.tlpSearchUser.TabIndex = 3;
            this.tlpSearchUser.UseWaitCursor = true;
            // 
            // txbSearchUser
            // 
            this.txbSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchUser.Location = new System.Drawing.Point(8, 23);
            this.txbSearchUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearchUser.Name = "txbSearchUser";
            this.txbSearchUser.Size = new System.Drawing.Size(278, 45);
            this.txbSearchUser.TabIndex = 0;
            this.txbSearchUser.UseWaitCursor = true;
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
            this.btnSearchUser.UseWaitCursor = true;
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
            this.tpageRoles.UseWaitCursor = true;
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
            this.tlpRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoles.Location = new System.Drawing.Point(5, 6);
            this.tlpRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tlpRoles.Name = "tlpRoles";
            this.tlpRoles.RowCount = 2;
            this.tlpRoles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpRoles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRoles.Size = new System.Drawing.Size(1244, 703);
            this.tlpRoles.TabIndex = 0;
            this.tlpRoles.UseWaitCursor = true;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(8, 9);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvRoles.MaximumSize = new System.Drawing.Size(2345, 845);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(1228, 473);
            this.dgvRoles.TabIndex = 0;
            this.dgvRoles.UseWaitCursor = true;
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
            this.tlpRolesButton.UseWaitCursor = true;
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
            this.btnDeleteRole.UseWaitCursor = true;
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
            this.btnUpdateRole.UseWaitCursor = true;
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
            this.btnCreateRole.UseWaitCursor = true;
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
            this.tlpSearchRole.UseWaitCursor = true;
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
            this.btnSearchRole.UseWaitCursor = true;
            this.btnSearchRole.Click += new System.EventHandler(this.btnSearchRole_Click);
            // 
            // txbSearchRole
            // 
            this.txbSearchRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchRole.Location = new System.Drawing.Point(8, 23);
            this.txbSearchRole.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearchRole.Name = "txbSearchRole";
            this.txbSearchRole.Size = new System.Drawing.Size(278, 45);
            this.txbSearchRole.TabIndex = 0;
            this.txbSearchRole.UseWaitCursor = true;
            // 
            // tpagePrivileges
            // 
            this.tpagePrivileges.BackColor = System.Drawing.SystemColors.Control;
            this.tpagePrivileges.Controls.Add(this.btnRevokePrivilege);
            this.tpagePrivileges.Controls.Add(this.btnGrantPrivilege);
            this.tpagePrivileges.Controls.Add(this.txbColumnPrivilege);
            this.tpagePrivileges.Controls.Add(this.txbTablePrivilege);
            this.tpagePrivileges.Controls.Add(this.dgvColumnPrivilege);
            this.tpagePrivileges.Controls.Add(this.dgvTablePrivilege);
            this.tpagePrivileges.Location = new System.Drawing.Point(4, 34);
            this.tpagePrivileges.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpagePrivileges.Name = "tpagePrivileges";
            this.tpagePrivileges.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tpagePrivileges.Size = new System.Drawing.Size(1254, 715);
            this.tpagePrivileges.TabIndex = 2;
            this.tpagePrivileges.Text = "Privileges";
            this.tpagePrivileges.UseWaitCursor = true;
            // 
            // btnRevokePrivilege
            // 
            this.btnRevokePrivilege.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRevokePrivilege.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokePrivilege.Location = new System.Drawing.Point(327, 4);
            this.btnRevokePrivilege.Name = "btnRevokePrivilege";
            this.btnRevokePrivilege.Size = new System.Drawing.Size(226, 84);
            this.btnRevokePrivilege.TabIndex = 5;
            this.btnRevokePrivilege.Text = "Hủy quyền của user/role";
            this.btnRevokePrivilege.UseVisualStyleBackColor = false;
            this.btnRevokePrivilege.UseWaitCursor = true;
            this.btnRevokePrivilege.Click += new System.EventHandler(this.btnRevokePrivilege_Click);
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrantPrivilege.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivilege.Location = new System.Drawing.Point(67, 4);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(231, 84);
            this.btnGrantPrivilege.TabIndex = 4;
            this.btnGrantPrivilege.Text = "Cấp quyền cho user/role";
            this.btnGrantPrivilege.UseVisualStyleBackColor = false;
            this.btnGrantPrivilege.UseWaitCursor = true;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // txbColumnPrivilege
            // 
            this.txbColumnPrivilege.BackColor = System.Drawing.SystemColors.Control;
            this.txbColumnPrivilege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbColumnPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbColumnPrivilege.Location = new System.Drawing.Point(67, 391);
            this.txbColumnPrivilege.Name = "txbColumnPrivilege";
            this.txbColumnPrivilege.Size = new System.Drawing.Size(132, 28);
            this.txbColumnPrivilege.TabIndex = 3;
            this.txbColumnPrivilege.Text = "COLUMN";
            this.txbColumnPrivilege.UseWaitCursor = true;
            // 
            // txbTablePrivilege
            // 
            this.txbTablePrivilege.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txbTablePrivilege.BackColor = System.Drawing.SystemColors.Control;
            this.txbTablePrivilege.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTablePrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTablePrivilege.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbTablePrivilege.Location = new System.Drawing.Point(67, 94);
            this.txbTablePrivilege.Name = "txbTablePrivilege";
            this.txbTablePrivilege.Size = new System.Drawing.Size(93, 28);
            this.txbTablePrivilege.TabIndex = 2;
            this.txbTablePrivilege.Text = "TABLE";
            this.txbTablePrivilege.UseWaitCursor = true;
            // 
            // dgvColumnPrivilege
            // 
            this.dgvColumnPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnPrivilege.Location = new System.Drawing.Point(67, 424);
            this.dgvColumnPrivilege.Name = "dgvColumnPrivilege";
            this.dgvColumnPrivilege.RowHeadersWidth = 62;
            this.dgvColumnPrivilege.Size = new System.Drawing.Size(1130, 256);
            this.dgvColumnPrivilege.TabIndex = 1;
            this.dgvColumnPrivilege.UseWaitCursor = true;
            // 
            // dgvTablePrivilege
            // 
            this.dgvTablePrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablePrivilege.Location = new System.Drawing.Point(67, 124);
            this.dgvTablePrivilege.Name = "dgvTablePrivilege";
            this.dgvTablePrivilege.RowHeadersWidth = 62;
            this.dgvTablePrivilege.Size = new System.Drawing.Size(1130, 256);
            this.dgvTablePrivilege.TabIndex = 0;
            this.dgvTablePrivilege.UseWaitCursor = true;
            // 
            // DBAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.tctrlDBA);
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DBAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBAForm";
            this.Load += new System.EventHandler(this.DBAForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnPrivilege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablePrivilege)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTablePrivilege;
        private System.Windows.Forms.TextBox txbTablePrivilege;
        private System.Windows.Forms.DataGridView dgvColumnPrivilege;
        private System.Windows.Forms.TextBox txbColumnPrivilege;
        private System.Windows.Forms.Button btnGrantPrivilege;
        private System.Windows.Forms.Button btnRevokePrivilege;
    }
}