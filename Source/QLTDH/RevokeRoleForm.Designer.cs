namespace QLTDH
{
    partial class RevokeRoleForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.btnRevokeRole = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRevokeRole, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 248);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.37847F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.62153F));
            this.tableLayoutPanel2.Controls.Add(this.cbbRole, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRole, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbUser, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 169);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbbRole
            // 
            this.cbbRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(133, 116);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(188, 27);
            this.cbbRole.TabIndex = 3;
            this.cbbRole.SelectedIndexChanged += new System.EventHandler(this.cbbRole_SelectedIndexChanged);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(47, 117);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 19);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(46, 32);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // cbbUser
            // 
            this.cbbUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(133, 31);
            this.cbbUser.Margin = new System.Windows.Forms.Padding(2);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(188, 27);
            this.cbbUser.TabIndex = 1;
            this.cbbUser.SelectedIndexChanged += new System.EventHandler(this.cbbUser_SelectedIndexChanged);
            // 
            // btnRevokeRole
            // 
            this.btnRevokeRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRevokeRole.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRevokeRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokeRole.Location = new System.Drawing.Point(136, 191);
            this.btnRevokeRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevokeRole.Name = "btnRevokeRole";
            this.btnRevokeRole.Size = new System.Drawing.Size(92, 39);
            this.btnRevokeRole.TabIndex = 1;
            this.btnRevokeRole.Text = "Thu hồi";
            this.btnRevokeRole.UseVisualStyleBackColor = false;
            this.btnRevokeRole.Click += new System.EventHandler(this.btnRevokeRole_Click);
            // 
            // RevokeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 248);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RevokeRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thu hồi Role của User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RevokeRole_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnRevokeRole;
    }
}