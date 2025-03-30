namespace QLTDH
{
    partial class DeleteRoleForm
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
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDeleteRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteRole.Location = new System.Drawing.Point(314, 310);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(168, 47);
            this.btnDeleteRole.TabIndex = 9;
            this.btnDeleteRole.Text = "Xóa vai trò";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // txbRole
            // 
            this.txbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRole.Location = new System.Drawing.Point(267, 187);
            this.txbRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(267, 30);
            this.txbRole.TabIndex = 8;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRole.Location = new System.Drawing.Point(131, 189);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(102, 23);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Tên vai trò";
            // 
            // lblDeleteRole
            // 
            this.lblDeleteRole.AutoSize = true;
            this.lblDeleteRole.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDeleteRole.Location = new System.Drawing.Point(335, 53);
            this.lblDeleteRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteRole.Name = "lblDeleteRole";
            this.lblDeleteRole.Size = new System.Drawing.Size(147, 32);
            this.lblDeleteRole.TabIndex = 10;
            this.lblDeleteRole.Text = "Xóa vai trò";
            // 
            // DeleteRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.lblDeleteRole);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.lblRole);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDeleteRole;
    }
}