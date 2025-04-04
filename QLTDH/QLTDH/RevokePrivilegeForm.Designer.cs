namespace QLTDH
{
    partial class RevokePrivilegeForm
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
            this.lblUsernameRole = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.tbUsernamRole = new System.Windows.Forms.TextBox();
            this.cbbObject = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.37177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.62823F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36573F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.63427F));
            this.tableLayoutPanel2.Controls.Add(this.lblUsernameRole, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblObject, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrivilege, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbUsernamRole, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbObject, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(782, 359);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblUsernameRole
            // 
            this.lblUsernameRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsernameRole.AutoSize = true;
            this.lblUsernameRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameRole.Location = new System.Drawing.Point(3, 0);
            this.lblUsernameRole.Name = "lblUsernameRole";
            this.lblUsernameRole.Size = new System.Drawing.Size(208, 119);
            this.lblUsernameRole.TabIndex = 0;
            this.lblUsernameRole.Text = "Username/Role";
            this.lblUsernameRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObject
            // 
            this.lblObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.Location = new System.Drawing.Point(3, 119);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(208, 119);
            this.lblObject.TabIndex = 1;
            this.lblObject.Text = "Đối tượng";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.Location = new System.Drawing.Point(3, 238);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(208, 121);
            this.lblPrivilege.TabIndex = 2;
            this.lblPrivilege.Text = "Quyền";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUsernamRole
            // 
            this.tbUsernamRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsernamRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernamRole.Location = new System.Drawing.Point(221, 42);
            this.tbUsernamRole.Name = "tbUsernamRole";
            this.tbUsernamRole.Size = new System.Drawing.Size(554, 35);
            this.tbUsernamRole.TabIndex = 3;
            // 
            // cbbObject
            // 
            this.cbbObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(221, 161);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(554, 35);
            this.cbbObject.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.48746F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5914F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.92115F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2043F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.61649F));
            this.tableLayoutPanel3.Controls.Add(this.cbWithGrantOption, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbDelete, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbUpdate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbInsert, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbSelect, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(217, 241);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(562, 115);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // cbWithGrantOption
            // 
            this.cbWithGrantOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbWithGrantOption.AutoSize = true;
            this.cbWithGrantOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbWithGrantOption.Location = new System.Drawing.Point(378, 44);
            this.cbWithGrantOption.Name = "cbWithGrantOption";
            this.cbWithGrantOption.Size = new System.Drawing.Size(181, 26);
            this.cbWithGrantOption.TabIndex = 4;
            this.cbWithGrantOption.Text = "With Grant Option";
            this.cbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDelete.AutoSize = true;
            this.cbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDelete.Location = new System.Drawing.Point(283, 44);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(88, 26);
            this.cbDelete.TabIndex = 3;
            this.cbDelete.Text = "Delete";
            this.cbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbUpdate.Location = new System.Drawing.Point(183, 44);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(92, 26);
            this.cbUpdate.TabIndex = 2;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbInsert
            // 
            this.cbInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInsert.AutoSize = true;
            this.cbInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbInsert.Location = new System.Drawing.Point(95, 44);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(80, 26);
            this.cbInsert.TabIndex = 1;
            this.cbInsert.Text = "Insert";
            this.cbInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSelect.AutoSize = true;
            this.cbSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbSelect.Location = new System.Drawing.Point(3, 44);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(85, 26);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.Text = "Select";
            this.cbSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSelect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.97423F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.02577F));
            this.tableLayoutPanel4.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRevoke, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 362);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(776, 138);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRevoke.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRevoke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.Location = new System.Drawing.Point(167, 32);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(209, 73);
            this.btnRevoke.TabIndex = 0;
            this.btnRevoke.Text = "Thu hồi quyền";
            this.btnRevoke.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(659, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // RevokePrivilegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RevokePrivilegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu hồi quyền từ user/role";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsernameRole;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.TextBox tbUsernamRole;
        private System.Windows.Forms.ComboBox cbbObject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.CheckBox cbWithGrantOption;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRevoke;
    }
}