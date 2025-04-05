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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ckbSelect = new System.Windows.Forms.CheckBox();
            this.ckbInsert = new System.Windows.Forms.CheckBox();
            this.ckbUpdate = new System.Windows.Forms.CheckBox();
            this.ckbDelete = new System.Windows.Forms.CheckBox();
            this.ckbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.50639F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.49361F));
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
            this.lblUsernameRole.Size = new System.Drawing.Size(170, 119);
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
            this.lblObject.Size = new System.Drawing.Size(170, 119);
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
            this.lblPrivilege.Size = new System.Drawing.Size(170, 121);
            this.lblPrivilege.TabIndex = 2;
            this.lblPrivilege.Text = "Quyền";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUsernamRole
            // 
            this.tbUsernamRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsernamRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernamRole.Location = new System.Drawing.Point(202, 42);
            this.tbUsernamRole.Name = "tbUsernamRole";
            this.tbUsernamRole.Size = new System.Drawing.Size(554, 35);
            this.tbUsernamRole.TabIndex = 3;
            // 
            // cbbObject
            // 
            this.cbbObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(202, 161);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(554, 35);
            this.cbbObject.TabIndex = 4;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRevoke.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRevoke.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.Location = new System.Drawing.Point(244, 22);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(296, 93);
            this.btnRevoke.TabIndex = 0;
            this.btnRevoke.Text = "Thu hồi quyền";
            this.btnRevoke.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(179, 241);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(600, 115);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.ckbUpdate, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.ckbInsert, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ckbSelect, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(594, 51);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.6835F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.3165F));
            this.tableLayoutPanel6.Controls.Add(this.ckbWithGrantOption, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ckbDelete, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(594, 52);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // ckbSelect
            // 
            this.ckbSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ckbSelect.AutoSize = true;
            this.ckbSelect.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSelect.Location = new System.Drawing.Point(56, 22);
            this.ckbSelect.Name = "ckbSelect";
            this.ckbSelect.Size = new System.Drawing.Size(85, 26);
            this.ckbSelect.TabIndex = 0;
            this.ckbSelect.Text = "Select";
            this.ckbSelect.UseVisualStyleBackColor = true;
            // 
            // ckbInsert
            // 
            this.ckbInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ckbInsert.AutoSize = true;
            this.ckbInsert.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbInsert.Location = new System.Drawing.Point(257, 22);
            this.ckbInsert.Name = "ckbInsert";
            this.ckbInsert.Size = new System.Drawing.Size(80, 26);
            this.ckbInsert.TabIndex = 1;
            this.ckbInsert.Text = "Insert";
            this.ckbInsert.UseVisualStyleBackColor = true;
            // 
            // ckbUpdate
            // 
            this.ckbUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ckbUpdate.AutoSize = true;
            this.ckbUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUpdate.Location = new System.Drawing.Point(449, 22);
            this.ckbUpdate.Name = "ckbUpdate";
            this.ckbUpdate.Size = new System.Drawing.Size(92, 26);
            this.ckbUpdate.TabIndex = 2;
            this.ckbUpdate.Text = "Update";
            this.ckbUpdate.UseVisualStyleBackColor = true;
            // 
            // ckbDelete
            // 
            this.ckbDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbDelete.AutoSize = true;
            this.ckbDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDelete.Location = new System.Drawing.Point(109, 3);
            this.ckbDelete.Name = "ckbDelete";
            this.ckbDelete.Size = new System.Drawing.Size(88, 26);
            this.ckbDelete.TabIndex = 1;
            this.ckbDelete.Text = "Delete";
            this.ckbDelete.UseVisualStyleBackColor = true;
            // 
            // ckbWithGrantOption
            // 
            this.ckbWithGrantOption.AutoSize = true;
            this.ckbWithGrantOption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWithGrantOption.Location = new System.Drawing.Point(310, 3);
            this.ckbWithGrantOption.Name = "ckbWithGrantOption";
            this.ckbWithGrantOption.Size = new System.Drawing.Size(181, 26);
            this.ckbWithGrantOption.TabIndex = 2;
            this.ckbWithGrantOption.Text = "With Grant Option";
            this.ckbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // RevokePrivilegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RevokePrivilegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu hồi quyền từ user/role";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox ckbUpdate;
        private System.Windows.Forms.CheckBox ckbInsert;
        private System.Windows.Forms.CheckBox ckbSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox ckbWithGrantOption;
        private System.Windows.Forms.CheckBox ckbDelete;
    }
}