namespace QLTDH
{
    partial class DeleteUserForm
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
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(285, 198);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(250, 30);
            this.txbUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.Location = new System.Drawing.Point(93, 200);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteUser.Location = new System.Drawing.Point(297, 319);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(221, 50);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Xóa người dùng";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDeleteUser.Location = new System.Drawing.Point(326, 79);
            this.lblDeleteUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(209, 32);
            this.lblDeleteUser.TabIndex = 11;
            this.lblDeleteUser.Text = "Xóa người dùng";
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.lblDeleteUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblDeleteUser;
    }
}