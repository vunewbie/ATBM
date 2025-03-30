namespace QLTDH
{
    partial class UpdateRolePasswordForm
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
            this.lblRolePaswordRequired = new System.Windows.Forms.Label();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUpdateRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRolePaswordRequired
            // 
            this.lblRolePaswordRequired.AutoSize = true;
            this.lblRolePaswordRequired.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRolePaswordRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRolePaswordRequired.Location = new System.Drawing.Point(200, 281);
            this.lblRolePaswordRequired.Name = "lblRolePaswordRequired";
            this.lblRolePaswordRequired.Size = new System.Drawing.Size(447, 34);
            this.lblRolePaswordRequired.TabIndex = 25;
            this.lblRolePaswordRequired.Text = "Bỏ trống mật khẩu nếu không cần";
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateRole.Location = new System.Drawing.Point(282, 348);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(248, 57);
            this.btnUpdateRole.TabIndex = 24;
            this.btnUpdateRole.Text = "Cập nhật vai trò";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(375, 223);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(266, 30);
            this.txbPassword.TabIndex = 23;
            // 
            // txbRole
            // 
            this.txbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRole.Location = new System.Drawing.Point(375, 142);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(266, 30);
            this.txbRole.TabIndex = 22;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(154, 225);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 23);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(154, 140);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(67, 23);
            this.lblRole.TabIndex = 20;
            this.lblRole.Text = "Vai trò";
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.AutoSize = true;
            this.lblUpdateRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUpdateRole.Location = new System.Drawing.Point(299, 46);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(211, 32);
            this.lblUpdateRole.TabIndex = 19;
            this.lblUpdateRole.Text = "Cập nhật vai trò";
            // 
            // UpdateRolePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRolePaswordRequired);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUpdateRole);
            this.Name = "UpdateRolePasswordForm";
            this.Text = "UpdateRoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRolePaswordRequired;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUpdateRole;
    }
}