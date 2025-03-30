namespace QLTDH
{
    partial class UpdateUserStatusForm
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblUpdateUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(270, 192);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(298, 30);
            this.txbUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.Location = new System.Drawing.Point(59, 194);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Location = new System.Drawing.Point(59, 294);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Trạng Thái";
            // 
            // cbbStatus
            // 
            this.cbbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "OPEN",
            "LOCK"});
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "LOCK",
            "UNLOCK"});
            this.cbbStatus.Location = new System.Drawing.Point(270, 292);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(298, 30);
            this.cbbStatus.TabIndex = 7;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(320, 391);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(179, 65);
            this.btnUpdateStatus.TabIndex = 8;
            this.btnUpdateStatus.Text = "Cập Nhật";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblUpdateUser
            // 
            this.lblUpdateUser.AutoSize = true;
            this.lblUpdateUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUpdateUser.Location = new System.Drawing.Point(314, 77);
            this.lblUpdateUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateUser.Name = "lblUpdateUser";
            this.lblUpdateUser.Size = new System.Drawing.Size(273, 32);
            this.lblUpdateUser.TabIndex = 20;
            this.lblUpdateUser.Text = "Cập nhật người dùng";
            // 
            // UpdateUserStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.lblUpdateUser);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateUserStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUserStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblUpdateUser;
    }
}