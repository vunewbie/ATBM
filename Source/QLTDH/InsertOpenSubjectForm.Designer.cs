namespace QLTDH
{
    partial class InsertOpenSubjectForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubjectID = new System.Windows.Forms.Label();
            this.cbbSubjectID = new System.Windows.Forms.ComboBox();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.cbbTeacherID = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cbbSemester = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txbYear = new System.Windows.Forms.TextBox();
            this.btnInsertOpenSubject = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertOpenSubject, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.52631F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 482);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.07253F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.92747F));
            this.tableLayoutPanel2.Controls.Add(this.lblYear, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbbSemester, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSemester, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbTeacherID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTeacherID, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSubjectID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbSubjectID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbYear, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 339);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm mở môn";
            // 
            // lblSubjectID
            // 
            this.lblSubjectID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubjectID.AutoSize = true;
            this.lblSubjectID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectID.Location = new System.Drawing.Point(75, 28);
            this.lblSubjectID.Name = "lblSubjectID";
            this.lblSubjectID.Size = new System.Drawing.Size(138, 27);
            this.lblSubjectID.TabIndex = 2;
            this.lblSubjectID.Text = "Mã học phần";
            // 
            // cbbSubjectID
            // 
            this.cbbSubjectID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbSubjectID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSubjectID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSubjectID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSubjectID.FormattingEnabled = true;
            this.cbbSubjectID.Location = new System.Drawing.Point(291, 28);
            this.cbbSubjectID.Name = "cbbSubjectID";
            this.cbbSubjectID.Size = new System.Drawing.Size(270, 33);
            this.cbbSubjectID.TabIndex = 3;
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.Location = new System.Drawing.Point(70, 112);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(148, 27);
            this.lblTeacherID.TabIndex = 4;
            this.lblTeacherID.Text = "Mã giảng viên";
            // 
            // cbbTeacherID
            // 
            this.cbbTeacherID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbTeacherID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTeacherID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTeacherID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTeacherID.FormattingEnabled = true;
            this.cbbTeacherID.Location = new System.Drawing.Point(291, 109);
            this.cbbTeacherID.Name = "cbbTeacherID";
            this.cbbTeacherID.Size = new System.Drawing.Size(270, 33);
            this.cbbTeacherID.TabIndex = 5;
            // 
            // lblSemester
            // 
            this.lblSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(103, 196);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(82, 27);
            this.lblSemester.TabIndex = 6;
            this.lblSemester.Text = "Học kỳ";
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbSemester.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbSemester.Location = new System.Drawing.Point(291, 193);
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(270, 33);
            this.cbbSemester.TabIndex = 7;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(115, 282);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 27);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Năm";
            // 
            // txbYear
            // 
            this.txbYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbYear.Location = new System.Drawing.Point(291, 278);
            this.txbYear.Name = "txbYear";
            this.txbYear.Size = new System.Drawing.Size(270, 35);
            this.txbYear.TabIndex = 9;
            // 
            // btnInsertOpenSubject
            // 
            this.btnInsertOpenSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertOpenSubject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInsertOpenSubject.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOpenSubject.Location = new System.Drawing.Point(266, 414);
            this.btnInsertOpenSubject.Name = "btnInsertOpenSubject";
            this.btnInsertOpenSubject.Size = new System.Drawing.Size(129, 51);
            this.btnInsertOpenSubject.TabIndex = 2;
            this.btnInsertOpenSubject.Text = "Thêm";
            this.btnInsertOpenSubject.UseVisualStyleBackColor = false;
            this.btnInsertOpenSubject.Click += new System.EventHandler(this.btnInsertOpenSubject_Click);
            // 
            // InsertOpenSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 482);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertOpenSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mở môn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsertOpenSubjectForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTeacherID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblSubjectID;
        private System.Windows.Forms.ComboBox cbbSubjectID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txbYear;
        private System.Windows.Forms.Button btnInsertOpenSubject;
    }
}