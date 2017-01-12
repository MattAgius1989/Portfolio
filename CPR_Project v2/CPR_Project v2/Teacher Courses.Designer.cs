namespace CPR_Project_v2
{
    partial class Teacher_Courses
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
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvViewTQualifications = new System.Windows.Forms.DataGridView();
            this.dgvTCourseView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEditSemesters = new System.Windows.Forms.TextBox();
            this.txtEditYears = new System.Windows.Forms.TextBox();
            this.cboEditTeacher = new System.Windows.Forms.ComboBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTEditQualification = new System.Windows.Forms.DataGridView();
            this.dgvTEditCourses = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddQualification = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.cboAddQualifications = new System.Windows.Forms.ComboBox();
            this.cboTeachers = new System.Windows.Forms.ComboBox();
            this.cboQualifications = new System.Windows.Forms.ComboBox();
            this.txtSemesters = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTQualifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCourseView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTEditQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTEditCourses)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCourses
            // 
            this.cboCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Location = new System.Drawing.Point(12, 12);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(189, 24);
            this.cboCourses.TabIndex = 0;
            this.cboCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourses_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(445, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 33);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return to &Function";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 556);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.dgvViewTQualifications);
            this.tabPage1.Controls.Add(this.dgvTCourseView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvViewTQualifications
            // 
            this.dgvViewTQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewTQualifications.Location = new System.Drawing.Point(6, 219);
            this.dgvViewTQualifications.Name = "dgvViewTQualifications";
            this.dgvViewTQualifications.RowTemplate.Height = 24;
            this.dgvViewTQualifications.Size = new System.Drawing.Size(563, 255);
            this.dgvViewTQualifications.TabIndex = 1;
            // 
            // dgvTCourseView
            // 
            this.dgvTCourseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTCourseView.Location = new System.Drawing.Point(3, 36);
            this.dgvTCourseView.Name = "dgvTCourseView";
            this.dgvTCourseView.RowTemplate.Height = 24;
            this.dgvTCourseView.Size = new System.Drawing.Size(566, 132);
            this.dgvTCourseView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEditSemesters);
            this.tabPage2.Controls.Add(this.txtEditYears);
            this.tabPage2.Controls.Add(this.cboEditTeacher);
            this.tabPage2.Controls.Add(this.btnSaveEdit);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvTEditQualification);
            this.tabPage2.Controls.Add(this.dgvTEditCourses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEditSemesters
            // 
            this.txtEditSemesters.Location = new System.Drawing.Point(429, 467);
            this.txtEditSemesters.Name = "txtEditSemesters";
            this.txtEditSemesters.Size = new System.Drawing.Size(121, 22);
            this.txtEditSemesters.TabIndex = 9;
            // 
            // txtEditYears
            // 
            this.txtEditYears.Location = new System.Drawing.Point(429, 424);
            this.txtEditYears.Name = "txtEditYears";
            this.txtEditYears.Size = new System.Drawing.Size(121, 22);
            this.txtEditYears.TabIndex = 8;
            // 
            // cboEditTeacher
            // 
            this.cboEditTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditTeacher.FormattingEnabled = true;
            this.cboEditTeacher.Location = new System.Drawing.Point(429, 381);
            this.cboEditTeacher.Name = "cboEditTeacher";
            this.cboEditTeacher.Size = new System.Drawing.Size(121, 24);
            this.cboEditTeacher.TabIndex = 7;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(6, 488);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(150, 33);
            this.btnSaveEdit.TabIndex = 6;
            this.btnSaveEdit.Text = "&Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. of Semesters: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. of Years: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teacher: ";
            // 
            // dgvTEditQualification
            // 
            this.dgvTEditQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTEditQualification.Location = new System.Drawing.Point(3, 219);
            this.dgvTEditQualification.Name = "dgvTEditQualification";
            this.dgvTEditQualification.RowTemplate.Height = 24;
            this.dgvTEditQualification.Size = new System.Drawing.Size(569, 132);
            this.dgvTEditQualification.TabIndex = 2;
            // 
            // dgvTEditCourses
            // 
            this.dgvTEditCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTEditCourses.Location = new System.Drawing.Point(3, 36);
            this.dgvTEditCourses.Name = "dgvTEditCourses";
            this.dgvTEditCourses.RowTemplate.Height = 24;
            this.dgvTEditCourses.Size = new System.Drawing.Size(569, 132);
            this.dgvTEditCourses.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddQualification);
            this.tabPage3.Controls.Add(this.btnAddCourse);
            this.tabPage3.Controls.Add(this.cboAddQualifications);
            this.tabPage3.Controls.Add(this.cboTeachers);
            this.tabPage3.Controls.Add(this.cboQualifications);
            this.tabPage3.Controls.Add(this.txtSemesters);
            this.tabPage3.Controls.Add(this.txtYear);
            this.tabPage3.Controls.Add(this.txtCName);
            this.tabPage3.Controls.Add(this.txtCID);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddQualification
            // 
            this.btnAddQualification.Location = new System.Drawing.Point(371, 417);
            this.btnAddQualification.Name = "btnAddQualification";
            this.btnAddQualification.Size = new System.Drawing.Size(185, 29);
            this.btnAddQualification.TabIndex = 15;
            this.btnAddQualification.Text = "S&ave Additional Courses";
            this.btnAddQualification.UseVisualStyleBackColor = true;
            this.btnAddQualification.Click += new System.EventHandler(this.btnAddQualification_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(10, 417);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(127, 29);
            this.btnAddCourse.TabIndex = 14;
            this.btnAddCourse.Text = "&Save";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // cboAddQualifications
            // 
            this.cboAddQualifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddQualifications.FormattingEnabled = true;
            this.cboAddQualifications.Location = new System.Drawing.Point(429, 335);
            this.cboAddQualifications.Name = "cboAddQualifications";
            this.cboAddQualifications.Size = new System.Drawing.Size(140, 24);
            this.cboAddQualifications.TabIndex = 13;
            // 
            // cboTeachers
            // 
            this.cboTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeachers.FormattingEnabled = true;
            this.cboTeachers.Location = new System.Drawing.Point(105, 335);
            this.cboTeachers.Name = "cboTeachers";
            this.cboTeachers.Size = new System.Drawing.Size(161, 24);
            this.cboTeachers.TabIndex = 12;
            // 
            // cboQualifications
            // 
            this.cboQualifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualifications.FormattingEnabled = true;
            this.cboQualifications.Location = new System.Drawing.Point(105, 270);
            this.cboQualifications.Name = "cboQualifications";
            this.cboQualifications.Size = new System.Drawing.Size(161, 24);
            this.cboQualifications.TabIndex = 11;
            // 
            // txtSemesters
            // 
            this.txtSemesters.Location = new System.Drawing.Point(105, 205);
            this.txtSemesters.Name = "txtSemesters";
            this.txtSemesters.Size = new System.Drawing.Size(161, 22);
            this.txtSemesters.TabIndex = 10;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(105, 142);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(161, 22);
            this.txtYear.TabIndex = 9;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(105, 79);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(161, 22);
            this.txtCName.TabIndex = 8;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(105, 16);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(161, 22);
            this.txtCID.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Additional Qualification:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Teacher:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Qualification:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Semesters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Years:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course ID:";
            // 
            // Teacher_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 610);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Teacher_Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Teacher_Courses_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTQualifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTCourseView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTEditQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTEditCourses)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvViewTQualifications;
        private System.Windows.Forms.DataGridView dgvTCourseView;
        private System.Windows.Forms.DataGridView dgvTEditCourses;
        private System.Windows.Forms.DataGridView dgvTEditQualification;
        private System.Windows.Forms.TextBox txtEditSemesters;
        private System.Windows.Forms.TextBox txtEditYears;
        private System.Windows.Forms.ComboBox cboEditTeacher;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddQualification;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox cboAddQualifications;
        private System.Windows.Forms.ComboBox cboTeachers;
        private System.Windows.Forms.ComboBox cboQualifications;
        private System.Windows.Forms.TextBox txtSemesters;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCID;
    }
}