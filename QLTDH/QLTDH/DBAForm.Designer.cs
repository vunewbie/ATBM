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
            this.tctrlDBA = new System.Windows.Forms.TabControl();
            this.tpageUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tlpUsersExecution = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tlpSearchUser = new System.Windows.Forms.TableLayoutPanel();
            this.txbSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.tpageRoles = new System.Windows.Forms.TabPage();
            this.tlpRoles = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tctrlDBA.SuspendLayout();
            this.tpageUsers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tlpUsersExecution.SuspendLayout();
            this.tlpSearchUser.SuspendLayout();
            this.tpageRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlDBA
            // 
            this.tctrlDBA.Controls.Add(this.tpageUsers);
            this.tctrlDBA.Controls.Add(this.tpageRoles);
            this.tctrlDBA.Controls.Add(this.tabPage1);
            this.tctrlDBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlDBA.ItemSize = new System.Drawing.Size(85, 30);
            this.tctrlDBA.Location = new System.Drawing.Point(0, 0);
            this.tctrlDBA.Name = "tctrlDBA";
            this.tctrlDBA.SelectedIndex = 0;
            this.tctrlDBA.Size = new System.Drawing.Size(1293, 712);
            this.tctrlDBA.TabIndex = 0;
            // 
            // tpageUsers
            // 
            this.tpageUsers.Controls.Add(this.tableLayoutPanel1);
            this.tpageUsers.Location = new System.Drawing.Point(4, 34);
            this.tpageUsers.Name = "tpageUsers";
            this.tpageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpageUsers.Size = new System.Drawing.Size(1285, 674);
            this.tpageUsers.TabIndex = 0;
            this.tpageUsers.Text = "Users";
            this.tpageUsers.UseVisualStyleBackColor = true;
            this.tpageUsers.Enter += new System.EventHandler(this.tpageUsers_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvUsers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpUsersExecution, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 668);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1273, 461);
            this.dgvUsers.TabIndex = 0;
            // 
            // tlpUsersExecution
            // 
            this.tlpUsersExecution.ColumnCount = 4;
            this.tlpUsersExecution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersExecution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersExecution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersExecution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpUsersExecution.Controls.Add(this.btnCreateUser, 0, 0);
            this.tlpUsersExecution.Controls.Add(this.btnUpdateUser, 1, 0);
            this.tlpUsersExecution.Controls.Add(this.btnDeleteUser, 2, 0);
            this.tlpUsersExecution.Controls.Add(this.tlpSearchUser, 3, 0);
            this.tlpUsersExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsersExecution.Location = new System.Drawing.Point(3, 470);
            this.tlpUsersExecution.Name = "tlpUsersExecution";
            this.tlpUsersExecution.RowCount = 1;
            this.tlpUsersExecution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsersExecution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tlpUsersExecution.Size = new System.Drawing.Size(1273, 195);
            this.tlpUsersExecution.TabIndex = 1;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateUser.Location = new System.Drawing.Point(3, 3);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(312, 189);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateUser.Location = new System.Drawing.Point(321, 3);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(312, 189);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Update User\'s Status";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(639, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(312, 189);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tlpSearchUser
            // 
            this.tlpSearchUser.ColumnCount = 1;
            this.tlpSearchUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSearchUser.Controls.Add(this.txbSearchUser, 0, 0);
            this.tlpSearchUser.Controls.Add(this.btnSearchUser, 0, 1);
            this.tlpSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchUser.Location = new System.Drawing.Point(957, 3);
            this.tlpSearchUser.Name = "tlpSearchUser";
            this.tlpSearchUser.RowCount = 2;
            this.tlpSearchUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchUser.Size = new System.Drawing.Size(313, 189);
            this.tlpSearchUser.TabIndex = 3;
            // 
            // txbSearchUser
            // 
            this.txbSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearchUser.Location = new System.Drawing.Point(3, 27);
            this.txbSearchUser.Name = "txbSearchUser";
            this.txbSearchUser.Size = new System.Drawing.Size(307, 39);
            this.txbSearchUser.TabIndex = 0;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchUser.Location = new System.Drawing.Point(3, 97);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(307, 89);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // tpageRoles
            // 
            this.tpageRoles.Controls.Add(this.tlpRoles);
            this.tpageRoles.Location = new System.Drawing.Point(4, 34);
            this.tpageRoles.Name = "tpageRoles";
            this.tpageRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tpageRoles.Size = new System.Drawing.Size(1285, 674);
            this.tpageRoles.TabIndex = 1;
            this.tpageRoles.Text = "Roles";
            this.tpageRoles.UseVisualStyleBackColor = true;
            // 
            // tlpRoles
            // 
            this.tlpRoles.ColumnCount = 1;
            this.tlpRoles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoles.Location = new System.Drawing.Point(3, 3);
            this.tlpRoles.Name = "tlpRoles";
            this.tlpRoles.RowCount = 2;
            this.tlpRoles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpRoles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRoles.Size = new System.Drawing.Size(1279, 668);
            this.tlpRoles.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1285, 674);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DBAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 712);
            this.Controls.Add(this.tctrlDBA);
            this.Name = "DBAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBAForm";
            this.Load += new System.EventHandler(this.DBAForm_Load);
            this.tctrlDBA.ResumeLayout(false);
            this.tpageUsers.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tlpUsersExecution.ResumeLayout(false);
            this.tlpSearchUser.ResumeLayout(false);
            this.tlpSearchUser.PerformLayout();
            this.tpageRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlDBA;
        private System.Windows.Forms.TabPage tpageUsers;
        private System.Windows.Forms.TabPage tpageRoles;
        private System.Windows.Forms.TableLayoutPanel tlpRoles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpUsersExecution;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TableLayoutPanel tlpSearchUser;
        private System.Windows.Forms.TextBox txbSearchUser;
        private System.Windows.Forms.Button btnSearchUser;
    }
}