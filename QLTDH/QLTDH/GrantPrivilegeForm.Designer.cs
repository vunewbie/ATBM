namespace QLTDH
{
    partial class GrantPrivilegeForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsernameRole = new System.Windows.Forms.Label();
            this.cbbUserRole = new System.Windows.Forms.ComboBox();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.cbbPrivilege = new System.Windows.Forms.ComboBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.cbbObjectType = new System.Windows.Forms.ComboBox();
            this.lblObject = new System.Windows.Forms.Label();
            this.cbbObject = new System.Windows.Forms.ComboBox();
            this.ckbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cklbAttribute = new System.Windows.Forms.CheckedListBox();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.71943F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.28057F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGrantPrivilege, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.95029F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0497F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(587, 409);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.05769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.94231F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsernameRole, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbUserRole, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrivilege, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbPrivilege, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblObjectType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbbObjectType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblObject, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbObject, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckbWithGrantOption, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 304);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.lblUsernameRole.Size = new System.Drawing.Size(122, 60);
            this.lblUsernameRole.TabIndex = 0;
            this.lblUsernameRole.Text = "Username/Role";
            this.lblUsernameRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbUserRole
            // 
            this.cbbUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbUserRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbUserRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbUserRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUserRole.FormattingEnabled = true;
            this.cbbUserRole.Location = new System.Drawing.Point(128, 16);
            this.cbbUserRole.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbUserRole.Name = "cbbUserRole";
            this.cbbUserRole.Size = new System.Drawing.Size(222, 27);
            this.cbbUserRole.TabIndex = 0;
            this.cbbUserRole.SelectedIndexChanged += new System.EventHandler(this.cbbUserRole_SelectedIndexChanged);
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.Location = new System.Drawing.Point(2, 60);
            this.lblPrivilege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(122, 60);
            this.lblPrivilege.TabIndex = 1;
            this.lblPrivilege.Text = "Quyền";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbPrivilege
            // 
            this.cbbPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivilege.FormattingEnabled = true;
            this.cbbPrivilege.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "EXECUTE"});
            this.cbbPrivilege.Location = new System.Drawing.Point(128, 76);
            this.cbbPrivilege.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbbPrivilege.Name = "cbbPrivilege";
            this.cbbPrivilege.Size = new System.Drawing.Size(222, 27);
            this.cbbPrivilege.TabIndex = 3;
            this.cbbPrivilege.SelectedIndexChanged += new System.EventHandler(this.cbbPrivilege_SelectedIndexChanged);
            // 
            // lblObjectType
            // 
            this.lblObjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectType.Location = new System.Drawing.Point(2, 120);
            this.lblObjectType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(122, 60);
            this.lblObjectType.TabIndex = 1;
            this.lblObjectType.Text = "Loại đối tượng";
            this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbObjectType
            // 
            this.cbbObjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbObjectType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObjectType.FormattingEnabled = true;
            this.cbbObjectType.Location = new System.Drawing.Point(128, 136);
            this.cbbObjectType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbbObjectType.Name = "cbbObjectType";
            this.cbbObjectType.Size = new System.Drawing.Size(222, 27);
            this.cbbObjectType.TabIndex = 4;
            this.cbbObjectType.SelectedIndexChanged += new System.EventHandler(this.cbbObjectType_SelectedIndexChanged);
            // 
            // lblObject
            // 
            this.lblObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.Location = new System.Drawing.Point(2, 180);
            this.lblObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(122, 60);
            this.lblObject.TabIndex = 6;
            this.lblObject.Text = "Đối tượng";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbObject
            // 
            this.cbbObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(128, 196);
            this.cbbObject.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(222, 27);
            this.cbbObject.TabIndex = 5;
            this.cbbObject.SelectedIndexChanged += new System.EventHandler(this.cbbObject_SelectedIndexChanged);
            // 
            // ckbWithGrantOption
            // 
            this.ckbWithGrantOption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckbWithGrantOption.AutoSize = true;
            this.ckbWithGrantOption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWithGrantOption.Location = new System.Drawing.Point(128, 262);
            this.ckbWithGrantOption.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ckbWithGrantOption.Name = "ckbWithGrantOption";
            this.ckbWithGrantOption.Size = new System.Drawing.Size(130, 20);
            this.ckbWithGrantOption.TabIndex = 6;
            this.ckbWithGrantOption.Text = "With Grant Option";
            this.ckbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cklbAttribute, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblAttribute, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(379, 25);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.08683F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.91316F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(185, 256);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // cklbAttribute
            // 
            this.cklbAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cklbAttribute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklbAttribute.FormattingEnabled = true;
            this.cklbAttribute.Location = new System.Drawing.Point(2, 44);
            this.cklbAttribute.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cklbAttribute.Name = "cklbAttribute";
            this.cklbAttribute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cklbAttribute.Size = new System.Drawing.Size(181, 211);
            this.cklbAttribute.TabIndex = 0;
            // 
            // lblAttribute
            // 
            this.lblAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttribute.Location = new System.Drawing.Point(2, 0);
            this.lblAttribute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(181, 43);
            this.lblAttribute.TabIndex = 1;
            this.lblAttribute.Text = "Thuộc tính";
            this.lblAttribute.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGrantPrivilege.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrantPrivilege.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivilege.Location = new System.Drawing.Point(204, 330);
            this.btnGrantPrivilege.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(150, 55);
            this.btnGrantPrivilege.TabIndex = 1;
            this.btnGrantPrivilege.Text = "Cấp quyền";
            this.btnGrantPrivilege.UseVisualStyleBackColor = false;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // GrantPrivilegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 409);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrantPrivilegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền cho user/role";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GrantPrivilegeForm_FormClosed);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsernameRole;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.ComboBox cbbObjectType;
        private System.Windows.Forms.ComboBox cbbPrivilege;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckedListBox cklbAttribute;
        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.ComboBox cbbObject;
        private System.Windows.Forms.CheckBox ckbWithGrantOption;
        private System.Windows.Forms.ComboBox cbbUserRole;
        private System.Windows.Forms.Button btnGrantPrivilege;
    }
}