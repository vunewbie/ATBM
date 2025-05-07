namespace QLTDH
{
    partial class InsertRegisterForm
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
            this.lbInsertStudent = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbStudentID = new System.Windows.Forms.ComboBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbOpenSubjectID = new System.Windows.Forms.Label();
            this.cbbOpenSubjectID = new System.Windows.Forms.ComboBox();
            this.btnInsertEmployee = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbInsertStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertEmployee, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 271);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbInsertStudent
            // 
            this.lbInsertStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInsertStudent.AutoSize = true;
            this.lbInsertStudent.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsertStudent.Location = new System.Drawing.Point(166, 14);
            this.lbInsertStudent.Name = "lbInsertStudent";
            this.lbInsertStudent.Size = new System.Drawing.Size(148, 25);
            this.lbInsertStudent.TabIndex = 0;
            this.lbInsertStudent.Text = "Thêm đăng ký";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.cbbStudentID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbStudentID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbOpenSubjectID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbOpenSubjectID, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 117);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cbbStudentID
            // 
            this.cbbStudentID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbStudentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStudentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStudentID.FormattingEnabled = true;
            this.cbbStudentID.Location = new System.Drawing.Point(98, 48);
            this.cbbStudentID.Name = "cbbStudentID";
            this.cbbStudentID.Size = new System.Drawing.Size(136, 27);
            this.cbbStudentID.TabIndex = 13;
            // 
            // lbStudentID
            // 
            this.lbStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(20, 49);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(54, 19);
            this.lbStudentID.TabIndex = 8;
            this.lbStudentID.Text = "Mã SV";
            // 
            // lbOpenSubjectID
            // 
            this.lbOpenSubjectID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbOpenSubjectID.AutoSize = true;
            this.lbOpenSubjectID.Location = new System.Drawing.Point(253, 49);
            this.lbOpenSubjectID.Name = "lbOpenSubjectID";
            this.lbOpenSubjectID.Size = new System.Drawing.Size(62, 19);
            this.lbOpenSubjectID.TabIndex = 14;
            this.lbOpenSubjectID.Text = "Mã MM";
            // 
            // cbbOpenSubjectID
            // 
            this.cbbOpenSubjectID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbOpenSubjectID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbOpenSubjectID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbOpenSubjectID.FormattingEnabled = true;
            this.cbbOpenSubjectID.Location = new System.Drawing.Point(335, 48);
            this.cbbOpenSubjectID.Name = "cbbOpenSubjectID";
            this.cbbOpenSubjectID.Size = new System.Drawing.Size(137, 27);
            this.cbbOpenSubjectID.TabIndex = 15;
            // 
            // btnInsertEmployee
            // 
            this.btnInsertEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsertEmployee.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertEmployee.Location = new System.Drawing.Point(173, 202);
            this.btnInsertEmployee.Name = "btnInsertEmployee";
            this.btnInsertEmployee.Size = new System.Drawing.Size(135, 43);
            this.btnInsertEmployee.TabIndex = 16;
            this.btnInsertEmployee.Text = "Thêm";
            this.btnInsertEmployee.UseVisualStyleBackColor = false;
            this.btnInsertEmployee.Click += new System.EventHandler(this.btnInsertEmployee_Click);
            // 
            // InsertRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InsertRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm đăng ký";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsertRegisterForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbInsertStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInsertEmployee;
        private System.Windows.Forms.ComboBox cbbStudentID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbOpenSubjectID;
        private System.Windows.Forms.ComboBox cbbOpenSubjectID;
    }
}