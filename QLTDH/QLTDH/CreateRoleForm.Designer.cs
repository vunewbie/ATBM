namespace QLTDH
{
    partial class CreateRoleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRolePaswordRequired = new System.Windows.Forms.Label();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateRole.Location = new System.Drawing.Point(195, 223);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(126, 39);
            this.btnCreateRole.TabIndex = 17;
            this.btnCreateRole.Text = "Tạo vai trò";
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(159, 113);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(214, 35);
            this.txbPassword.TabIndex = 16;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbRole
            // 
            this.txbRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRole.Location = new System.Drawing.Point(159, 53);
            this.txbRole.Margin = new System.Windows.Forms.Padding(0);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(214, 35);
            this.txbRole.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(48, 115);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 26);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(48, 55);
            this.lblRole.Margin = new System.Windows.Forms.Padding(0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(83, 26);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Vai trò";
            // 
            // lblRolePaswordRequired
            // 
            this.lblRolePaswordRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRolePaswordRequired.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRolePaswordRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRolePaswordRequired.Location = new System.Drawing.Point(139, 160);
            this.lblRolePaswordRequired.Margin = new System.Windows.Forms.Padding(0);
            this.lblRolePaswordRequired.Name = "lblRolePaswordRequired";
            this.lblRolePaswordRequired.Size = new System.Drawing.Size(251, 53);
            this.lblRolePaswordRequired.TabIndex = 18;
            this.lblRolePaswordRequired.Text = "Bỏ trống mật khẩu nếu không cần";
            this.lblRolePaswordRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPassword
            // 
            this.pbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPassword.Image = global::QLTDH.Properties.Resources.eye_off;
            this.pbPassword.Location = new System.Drawing.Point(347, 115);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(25, 21);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 19;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // CreateRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.lblRolePaswordRequired);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm vai trò";
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRolePaswordRequired;
        private System.Windows.Forms.PictureBox pbPassword;
    }
}