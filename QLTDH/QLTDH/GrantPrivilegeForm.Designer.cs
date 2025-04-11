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
            this.cbbObjectType = new System.Windows.Forms.ComboBox();
            this.lblUsernameRole = new System.Windows.Forms.Label();
            this.cbbPrivilege = new System.Windows.Forms.ComboBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txbUsernameRole = new System.Windows.Forms.TextBox();
            this.lblResultCheck = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.cbbObject = new System.Windows.Forms.ComboBox();
            this.ckbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGrantPrivilege = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cklbAttribute = new System.Windows.Forms.CheckedListBox();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.74169F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.25831F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.95029F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0497F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(782, 503);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.23376F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.76624F));
            this.tableLayoutPanel1.Controls.Add(this.cbbObjectType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblUsernameRole, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbbPrivilege, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblObjectType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPrivilege, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblResult, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbUsernameRole, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblResultCheck, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblObject, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbbObject, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ckbWithGrantOption, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbbObjectType
            // 
            this.cbbObjectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbObjectType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObjectType.FormattingEnabled = true;
            this.cbbObjectType.Location = new System.Drawing.Point(219, 216);
            this.cbbObjectType.Name = "cbbObjectType";
            this.cbbObjectType.Size = new System.Drawing.Size(247, 35);
            this.cbbObjectType.TabIndex = 4;
            this.cbbObjectType.SelectedIndexChanged += new System.EventHandler(this.cbbObjectType_SelectedIndexChanged);
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
            this.lblUsernameRole.Size = new System.Drawing.Size(210, 52);
            this.lblUsernameRole.TabIndex = 0;
            this.lblUsernameRole.Text = "Username/Role";
            this.lblUsernameRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbPrivilege
            // 
            this.cbbPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPrivilege.FormattingEnabled = true;
            this.cbbPrivilege.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "EXECUTE"});
            this.cbbPrivilege.Location = new System.Drawing.Point(219, 164);
            this.cbbPrivilege.Name = "cbbPrivilege";
            this.cbbPrivilege.Size = new System.Drawing.Size(247, 35);
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
            this.lblObjectType.Location = new System.Drawing.Point(3, 208);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(210, 52);
            this.lblObjectType.TabIndex = 1;
            this.lblObjectType.Text = "Loại đối tượng";
            this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilege.Location = new System.Drawing.Point(3, 156);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(210, 52);
            this.lblPrivilege.TabIndex = 1;
            this.lblPrivilege.Text = "Quyền";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(3, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(210, 52);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Kết quả";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.14009F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.85991F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCheck, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(216, 52);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(253, 52);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(137, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 46);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(3, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(128, 46);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txbUsernameRole
            // 
            this.txbUsernameRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsernameRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsernameRole.Location = new System.Drawing.Point(219, 8);
            this.txbUsernameRole.Name = "txbUsernameRole";
            this.txbUsernameRole.Size = new System.Drawing.Size(247, 35);
            this.txbUsernameRole.TabIndex = 0;
            // 
            // lblResultCheck
            // 
            this.lblResultCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultCheck.AutoSize = true;
            this.lblResultCheck.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultCheck.ForeColor = System.Drawing.Color.Red;
            this.lblResultCheck.Location = new System.Drawing.Point(342, 119);
            this.lblResultCheck.Name = "lblResultCheck";
            this.lblResultCheck.Size = new System.Drawing.Size(0, 22);
            this.lblResultCheck.TabIndex = 5;
            // 
            // lblObject
            // 
            this.lblObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObject.AutoSize = true;
            this.lblObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObject.Location = new System.Drawing.Point(3, 260);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(210, 52);
            this.lblObject.TabIndex = 6;
            this.lblObject.Text = "Đối tượng";
            this.lblObject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbObject
            // 
            this.cbbObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbObject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(219, 268);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(247, 35);
            this.cbbObject.TabIndex = 5;
            this.cbbObject.SelectedIndexChanged += new System.EventHandler(this.cbbObject_SelectedIndexChanged);
            // 
            // ckbWithGrantOption
            // 
            this.ckbWithGrantOption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckbWithGrantOption.AutoSize = true;
            this.ckbWithGrantOption.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbWithGrantOption.Location = new System.Drawing.Point(219, 328);
            this.ckbWithGrantOption.Name = "ckbWithGrantOption";
            this.ckbWithGrantOption.Size = new System.Drawing.Size(181, 26);
            this.ckbWithGrantOption.TabIndex = 6;
            this.ckbWithGrantOption.Text = "With Grant Option";
            this.ckbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnGrantPrivilege, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblWarning, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 377);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.95238F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.04762F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(475, 126);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnGrantPrivilege
            // 
            this.btnGrantPrivilege.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrantPrivilege.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrantPrivilege.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivilege.Location = new System.Drawing.Point(128, 52);
            this.btnGrantPrivilege.Name = "btnGrantPrivilege";
            this.btnGrantPrivilege.Size = new System.Drawing.Size(218, 59);
            this.btnGrantPrivilege.TabIndex = 1;
            this.btnGrantPrivilege.Text = "Cấp quyền";
            this.btnGrantPrivilege.UseVisualStyleBackColor = false;
            this.btnGrantPrivilege.Click += new System.EventHandler(this.btnGrantPrivilege_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(3, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(469, 38);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Vui lòng nhấn nút \"Kiểm tra\"  để có thể cấp quyền";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(675, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cklbAttribute, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblAttribute, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(505, 30);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.08683F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.91316F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(247, 317);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // cklbAttribute
            // 
            this.cklbAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cklbAttribute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklbAttribute.FormattingEnabled = true;
            this.cklbAttribute.Location = new System.Drawing.Point(3, 57);
            this.cklbAttribute.Name = "cklbAttribute";
            this.cklbAttribute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cklbAttribute.Size = new System.Drawing.Size(241, 257);
            this.cklbAttribute.TabIndex = 0;
            // 
            // lblAttribute
            // 
            this.lblAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttribute.Location = new System.Drawing.Point(3, 0);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(241, 54);
            this.lblAttribute.TabIndex = 1;
            this.lblAttribute.Text = "Thuộc tính";
            this.lblAttribute.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GrantPrivilegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrantPrivilegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấp quyền cho user/role";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUsernameRole;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.ComboBox cbbObjectType;
        private System.Windows.Forms.ComboBox cbbPrivilege;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txbUsernameRole;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnGrantPrivilege;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckedListBox cklbAttribute;
        private System.Windows.Forms.Label lblAttribute;
        private System.Windows.Forms.Label lblResultCheck;
        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.ComboBox cbbObject;
        private System.Windows.Forms.CheckBox ckbWithGrantOption;
    }
}