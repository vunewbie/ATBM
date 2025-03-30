namespace QLTDH
{
    partial class CreateRoleForm
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
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblNewRole = new System.Windows.Forms.Label();
            this.lblRolePaswordRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateRole.Location = new System.Drawing.Point(285, 361);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(248, 57);
            this.btnCreateRole.TabIndex = 17;
            this.btnCreateRole.Text = "Tạo vai trò";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(378, 236);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(266, 30);
            this.txbPassword.TabIndex = 16;
            // 
            // txbRole
            // 
            this.txbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRole.Location = new System.Drawing.Point(378, 155);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(266, 30);
            this.txbRole.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(157, 238);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 23);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(157, 153);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(67, 23);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Vai trò";
            // 
            // lblNewRole
            // 
            this.lblNewRole.AutoSize = true;
            this.lblNewRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNewRole.Location = new System.Drawing.Point(302, 59);
            this.lblNewRole.Name = "lblNewRole";
            this.lblNewRole.Size = new System.Drawing.Size(220, 32);
            this.lblNewRole.TabIndex = 12;
            this.lblNewRole.Text = "Thêm vai trò mới";
            // 
            // lblRolePaswordRequired
            // 
            this.lblRolePaswordRequired.AutoSize = true;
            this.lblRolePaswordRequired.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRolePaswordRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRolePaswordRequired.Location = new System.Drawing.Point(203, 294);
            this.lblRolePaswordRequired.Name = "lblRolePaswordRequired";
            this.lblRolePaswordRequired.Size = new System.Drawing.Size(447, 34);
            this.lblRolePaswordRequired.TabIndex = 18;
            this.lblRolePaswordRequired.Text = "Bỏ trống mật khẩu nếu không cần";
            // 
            // CreateRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRolePaswordRequired);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblNewRole);
            this.Name = "CreateRoleForm";
            this.Text = "CreateRoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblNewRole;
        private System.Windows.Forms.Label lblRolePaswordRequired;
    }
}