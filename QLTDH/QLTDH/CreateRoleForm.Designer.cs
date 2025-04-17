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
            this.pbPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateRole.Location = new System.Drawing.Point(294, 394);
            this.btnCreateRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(214, 54);
            this.btnCreateRole.TabIndex = 17;
            this.btnCreateRole.Text = "Tạo vai trò";
            this.btnCreateRole.UseVisualStyleBackColor = false;
            this.btnCreateRole.Click += new System.EventHandler(this.btnCreateRole_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(294, 228);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(214, 30);
            this.txbPassword.TabIndex = 16;
            // 
            // txbRole
            // 
            this.txbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRole.Location = new System.Drawing.Point(294, 129);
            this.txbRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(214, 30);
            this.txbRole.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(116, 230);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 23);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(116, 131);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(67, 23);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Vai trò";
            // 
            // lblNewRole
            // 
            this.lblNewRole.AutoSize = true;
            this.lblNewRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNewRole.Location = new System.Drawing.Point(301, 55);
            this.lblNewRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewRole.Name = "lblNewRole";
            this.lblNewRole.Size = new System.Drawing.Size(220, 32);
            this.lblNewRole.TabIndex = 12;
            this.lblNewRole.Text = "Thêm vai trò mới";
            // 
            // lblRolePaswordRequired
            // 
            this.lblRolePaswordRequired.AutoSize = true;
            this.lblRolePaswordRequired.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRolePaswordRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRolePaswordRequired.Location = new System.Drawing.Point(234, 322);
            this.lblRolePaswordRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRolePaswordRequired.Name = "lblRolePaswordRequired";
            this.lblRolePaswordRequired.Size = new System.Drawing.Size(407, 32);
            this.lblRolePaswordRequired.TabIndex = 18;
            this.lblRolePaswordRequired.Text = "Bỏ trống mật khẩu nếu không cần";
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::QLTDH.Properties.Resources.eye_off;
            this.pbPassword.Location = new System.Drawing.Point(485, 230);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(23, 23);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 19;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // CreateRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.lblRolePaswordRequired);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblNewRole);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblNewRole;
        private System.Windows.Forms.Label lblRolePaswordRequired;
        private System.Windows.Forms.PictureBox pbPassword;
    }
}