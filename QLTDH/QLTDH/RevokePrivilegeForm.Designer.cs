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
            this.cbbObject = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ckbUpdate = new System.Windows.Forms.CheckBox();
            this.ckbInsert = new System.Windows.Forms.CheckBox();
            this.ckbSelect = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ckbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.ckbDelete = new System.Windows.Forms.CheckBox();
            this.cbbUserRole = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.ckbExecute = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.72662F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.27338F));
            this.tableLayoutPanel2.Controls.Add(this.lblUsernameRole, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblObject, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrivilege, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbObject, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbUserRole, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.69626F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89252F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.41121F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(521, 233);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblUsernameRole
            // 
            this.lblUsernameRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsernameRole.AutoSize = true;
            this.lblUsernameRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameRole.Location = new System.Drawing.Point(2, 0);
            this.lblUsernameRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameRole.Name = "lblUsernameRole";
            this.lblUsernameRole.Size = new System.Drawing.Size(109, 80);
            this.lblUsernameRole.TabIndex = 0;
            this.lblUsernameRole.Text = "User/Role";
            this.lblUsernameRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblObject
            // 
            this.lblObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.Location = new System.Drawing.Point(2, 80);
            this.lblObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(109, 74);
            this.lblObject.TabIndex = 1;
            this.lblObject.Text = "Đối tượng";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.Location = new System.Drawing.Point(2, 154);
            this.lblPrivilege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(109, 79);
            this.lblPrivilege.TabIndex = 2;
            this.lblPrivilege.Text = "Quyền";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbObject
            // 
            this.cbbObject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbObject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbObject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(131, 103);
            this.cbbObject.Margin = new System.Windows.Forms.Padding(2);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(371, 27);
            this.cbbObject.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(115, 156);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(404, 75);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(400, 33);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // ckbUpdate
            // 
            this.ckbUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbUpdate.AutoSize = true;
            this.ckbUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUpdate.Location = new System.Drawing.Point(300, 6);
            this.ckbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.ckbUpdate.Name = "ckbUpdate";
            this.ckbUpdate.Size = new System.Drawing.Size(65, 20);
            this.ckbUpdate.TabIndex = 2;
            this.ckbUpdate.Text = "Update";
            this.ckbUpdate.UseVisualStyleBackColor = true;
            // 
            // ckbInsert
            // 
            this.ckbInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbInsert.AutoSize = true;
            this.ckbInsert.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbInsert.Location = new System.Drawing.Point(170, 6);
            this.ckbInsert.Margin = new System.Windows.Forms.Padding(2);
            this.ckbInsert.Name = "ckbInsert";
            this.ckbInsert.Size = new System.Drawing.Size(59, 20);
            this.ckbInsert.TabIndex = 1;
            this.ckbInsert.Text = "Insert";
            this.ckbInsert.UseVisualStyleBackColor = true;
            // 
            // ckbSelect
            // 
            this.ckbSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbSelect.AutoSize = true;
            this.ckbSelect.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSelect.Location = new System.Drawing.Point(36, 6);
            this.ckbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.ckbSelect.Name = "ckbSelect";
            this.ckbSelect.Size = new System.Drawing.Size(60, 20);
            this.ckbSelect.TabIndex = 0;
            this.ckbSelect.Text = "Select";
            this.ckbSelect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Controls.Add(this.ckbExecute, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.ckbWithGrantOption, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ckbDelete, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 39);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(400, 34);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // ckbWithGrantOption
            // 
            this.ckbWithGrantOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbWithGrantOption.AutoSize = true;
            this.ckbWithGrantOption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWithGrantOption.Location = new System.Drawing.Point(135, 7);
            this.ckbWithGrantOption.Margin = new System.Windows.Forms.Padding(2);
            this.ckbWithGrantOption.Name = "ckbWithGrantOption";
            this.ckbWithGrantOption.Size = new System.Drawing.Size(130, 20);
            this.ckbWithGrantOption.TabIndex = 2;
            this.ckbWithGrantOption.Text = "With Grant Option";
            this.ckbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // ckbDelete
            // 
            this.ckbDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbDelete.AutoSize = true;
            this.ckbDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDelete.Location = new System.Drawing.Point(29, 7);
            this.ckbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDelete.Name = "ckbDelete";
            this.ckbDelete.Size = new System.Drawing.Size(61, 20);
            this.ckbDelete.TabIndex = 1;
            this.ckbDelete.Text = "Delete";
            this.ckbDelete.UseVisualStyleBackColor = true;
            // 
            // cbbUserRole
            // 
            this.cbbUserRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbUserRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUserRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUserRole.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUserRole.FormattingEnabled = true;
            this.cbbUserRole.ItemHeight = 19;
            this.cbbUserRole.Location = new System.Drawing.Point(133, 26);
            this.cbbUserRole.Name = "cbbUserRole";
            this.cbbUserRole.Size = new System.Drawing.Size(368, 27);
            this.cbbUserRole.TabIndex = 6;
            this.cbbUserRole.SelectedValueChanged += new System.EventHandler(this.cbbUserRole_SelectedValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnRevoke, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 235);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(517, 90);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRevoke.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRevoke.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevoke.Location = new System.Drawing.Point(160, 15);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(2);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(197, 60);
            this.btnRevoke.TabIndex = 0;
            this.btnRevoke.Text = "Thu hồi quyền";
            this.btnRevoke.UseVisualStyleBackColor = false;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // ckbExecute
            // 
            this.ckbExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbExecute.AutoSize = true;
            this.ckbExecute.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbExecute.Location = new System.Drawing.Point(304, 7);
            this.ckbExecute.Margin = new System.Windows.Forms.Padding(2);
            this.ckbExecute.Name = "ckbExecute";
            this.ckbExecute.Size = new System.Drawing.Size(71, 20);
            this.ckbExecute.TabIndex = 3;
            this.ckbExecute.Text = "Execute";
            this.ckbExecute.UseVisualStyleBackColor = true;
            // 
            // RevokePrivilegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 327);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RevokePrivilegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu hồi quyền từ user/role";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsernameRole;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.ComboBox cbbObject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox ckbUpdate;
        private System.Windows.Forms.CheckBox ckbInsert;
        private System.Windows.Forms.CheckBox ckbSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox ckbWithGrantOption;
        private System.Windows.Forms.CheckBox ckbDelete;
        private System.Windows.Forms.ComboBox cbbUserRole;
        private System.Windows.Forms.CheckBox ckbExecute;
    }
}