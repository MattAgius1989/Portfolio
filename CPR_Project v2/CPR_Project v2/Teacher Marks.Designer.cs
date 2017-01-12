namespace CPR_Project_v2
{
    partial class Teacher_Marks
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.btnCNewMarks = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCNMarks = new System.Windows.Forms.TextBox();
            this.cboCNMCourse = new System.Windows.Forms.ComboBox();
            this.cboCNMStudent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteFromCourse = new System.Windows.Forms.Button();
            this.btnSaveStudentEdit = new System.Windows.Forms.Button();
            this.txtStudentMark = new System.Windows.Forms.TextBox();
            this.cboSelectedStudents = new System.Windows.Forms.ComboBox();
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.btnSNewMarks = new System.Windows.Forms.Button();
            this.txtSNMarks = new System.Windows.Forms.TextBox();
            this.cboSNMStudent = new System.Windows.Forms.ComboBox();
            this.cboSNMCourse = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFromStudent = new System.Windows.Forms.Button();
            this.btnSaveCourseEdit = new System.Windows.Forms.Button();
            this.txtCourseMark = new System.Windows.Forms.TextBox();
            this.cboSelectedCourses = new System.Windows.Forms.ComboBox();
            this.cboStudents = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(445, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 33);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "&Return to Function";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 556);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCourse);
            this.tabPage1.Controls.Add(this.btnCNewMarks);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtCNMarks);
            this.tabPage1.Controls.Add(this.cboCNMCourse);
            this.tabPage1.Controls.Add(this.cboCNMStudent);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDeleteFromCourse);
            this.tabPage1.Controls.Add(this.btnSaveStudentEdit);
            this.tabPage1.Controls.Add(this.txtStudentMark);
            this.tabPage1.Controls.Add(this.cboSelectedStudents);
            this.tabPage1.Controls.Add(this.cboCourses);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search by Course";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCourse
            // 
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Location = new System.Drawing.Point(3, 44);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 24;
            this.dgvCourse.Size = new System.Drawing.Size(569, 132);
            this.dgvCourse.TabIndex = 45;
            // 
            // btnCNewMarks
            // 
            this.btnCNewMarks.Location = new System.Drawing.Point(150, 488);
            this.btnCNewMarks.Name = "btnCNewMarks";
            this.btnCNewMarks.Size = new System.Drawing.Size(150, 33);
            this.btnCNewMarks.TabIndex = 44;
            this.btnCNewMarks.Text = "S&ave";
            this.btnCNewMarks.UseVisualStyleBackColor = true;
            this.btnCNewMarks.Click += new System.EventHandler(this.btnCNewMarks_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Enter Marks:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Select Course:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Select Student:";
            // 
            // txtCNMarks
            // 
            this.txtCNMarks.Location = new System.Drawing.Point(137, 444);
            this.txtCNMarks.Name = "txtCNMarks";
            this.txtCNMarks.Size = new System.Drawing.Size(163, 22);
            this.txtCNMarks.TabIndex = 40;
            // 
            // cboCNMCourse
            // 
            this.cboCNMCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCNMCourse.FormattingEnabled = true;
            this.cboCNMCourse.Location = new System.Drawing.Point(137, 398);
            this.cboCNMCourse.Name = "cboCNMCourse";
            this.cboCNMCourse.Size = new System.Drawing.Size(163, 24);
            this.cboCNMCourse.TabIndex = 39;
            // 
            // cboCNMStudent
            // 
            this.cboCNMStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCNMStudent.FormattingEnabled = true;
            this.cboCNMStudent.Location = new System.Drawing.Point(137, 352);
            this.cboCNMStudent.Name = "cboCNMStudent";
            this.cboCNMStudent.Size = new System.Drawing.Size(163, 24);
            this.cboCNMStudent.TabIndex = 38;
            this.cboCNMStudent.SelectedIndexChanged += new System.EventHandler(this.cboCNMStudent_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Add Marks:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Search by Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mark:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Select Student:";
            // 
            // btnDeleteFromCourse
            // 
            this.btnDeleteFromCourse.Location = new System.Drawing.Point(174, 227);
            this.btnDeleteFromCourse.Name = "btnDeleteFromCourse";
            this.btnDeleteFromCourse.Size = new System.Drawing.Size(150, 33);
            this.btnDeleteFromCourse.TabIndex = 30;
            this.btnDeleteFromCourse.Text = "&Delete";
            this.btnDeleteFromCourse.UseVisualStyleBackColor = true;
            this.btnDeleteFromCourse.Click += new System.EventHandler(this.btnDeleteFromCourse_Click_1);
            // 
            // btnSaveStudentEdit
            // 
            this.btnSaveStudentEdit.Location = new System.Drawing.Point(9, 227);
            this.btnSaveStudentEdit.Name = "btnSaveStudentEdit";
            this.btnSaveStudentEdit.Size = new System.Drawing.Size(150, 33);
            this.btnSaveStudentEdit.TabIndex = 29;
            this.btnSaveStudentEdit.Text = "&Save";
            this.btnSaveStudentEdit.UseVisualStyleBackColor = true;
            this.btnSaveStudentEdit.Click += new System.EventHandler(this.btnSaveStudentEdit_Click_1);
            // 
            // txtStudentMark
            // 
            this.txtStudentMark.Location = new System.Drawing.Point(389, 182);
            this.txtStudentMark.Name = "txtStudentMark";
            this.txtStudentMark.Size = new System.Drawing.Size(100, 22);
            this.txtStudentMark.TabIndex = 26;
            // 
            // cboSelectedStudents
            // 
            this.cboSelectedStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedStudents.FormattingEnabled = true;
            this.cboSelectedStudents.Location = new System.Drawing.Point(137, 182);
            this.cboSelectedStudents.Name = "cboSelectedStudents";
            this.cboSelectedStudents.Size = new System.Drawing.Size(163, 24);
            this.cboSelectedStudents.TabIndex = 24;
            // 
            // cboCourses
            // 
            this.cboCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Location = new System.Drawing.Point(137, 14);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(163, 24);
            this.cboCourses.TabIndex = 22;
            this.cboCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourses_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMarks);
            this.tabPage2.Controls.Add(this.btnSNewMarks);
            this.tabPage2.Controls.Add(this.txtSNMarks);
            this.tabPage2.Controls.Add(this.cboSNMStudent);
            this.tabPage2.Controls.Add(this.cboSNMCourse);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDeleteFromStudent);
            this.tabPage2.Controls.Add(this.btnSaveCourseEdit);
            this.tabPage2.Controls.Add(this.txtCourseMark);
            this.tabPage2.Controls.Add(this.cboSelectedCourses);
            this.tabPage2.Controls.Add(this.cboStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search by Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(3, 44);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.RowTemplate.Height = 24;
            this.dgvMarks.Size = new System.Drawing.Size(569, 132);
            this.dgvMarks.TabIndex = 53;
            // 
            // btnSNewMarks
            // 
            this.btnSNewMarks.Location = new System.Drawing.Point(150, 488);
            this.btnSNewMarks.Name = "btnSNewMarks";
            this.btnSNewMarks.Size = new System.Drawing.Size(150, 33);
            this.btnSNewMarks.TabIndex = 52;
            this.btnSNewMarks.Text = "S&ave";
            this.btnSNewMarks.UseVisualStyleBackColor = true;
            this.btnSNewMarks.Click += new System.EventHandler(this.btnSNewMarks_Click);
            // 
            // txtSNMarks
            // 
            this.txtSNMarks.Location = new System.Drawing.Point(137, 444);
            this.txtSNMarks.Name = "txtSNMarks";
            this.txtSNMarks.Size = new System.Drawing.Size(163, 22);
            this.txtSNMarks.TabIndex = 51;
            // 
            // cboSNMStudent
            // 
            this.cboSNMStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSNMStudent.FormattingEnabled = true;
            this.cboSNMStudent.Location = new System.Drawing.Point(137, 398);
            this.cboSNMStudent.Name = "cboSNMStudent";
            this.cboSNMStudent.Size = new System.Drawing.Size(163, 24);
            this.cboSNMStudent.TabIndex = 50;
            // 
            // cboSNMCourse
            // 
            this.cboSNMCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSNMCourse.FormattingEnabled = true;
            this.cboSNMCourse.Location = new System.Drawing.Point(137, 352);
            this.cboSNMCourse.Name = "cboSNMCourse";
            this.cboSNMCourse.Size = new System.Drawing.Size(163, 24);
            this.cboSNMCourse.TabIndex = 49;
            this.cboSNMCourse.SelectedIndexChanged += new System.EventHandler(this.cboSNMCourse_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Enter Marks:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Select Student:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Select Course:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Add Marks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Search by Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mark:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Select Course:";
            // 
            // btnDeleteFromStudent
            // 
            this.btnDeleteFromStudent.Location = new System.Drawing.Point(174, 227);
            this.btnDeleteFromStudent.Name = "btnDeleteFromStudent";
            this.btnDeleteFromStudent.Size = new System.Drawing.Size(150, 33);
            this.btnDeleteFromStudent.TabIndex = 41;
            this.btnDeleteFromStudent.Text = "&Delete";
            this.btnDeleteFromStudent.UseVisualStyleBackColor = true;
            this.btnDeleteFromStudent.Click += new System.EventHandler(this.btnDeleteFromStudent_Click);
            // 
            // btnSaveCourseEdit
            // 
            this.btnSaveCourseEdit.Location = new System.Drawing.Point(9, 227);
            this.btnSaveCourseEdit.Name = "btnSaveCourseEdit";
            this.btnSaveCourseEdit.Size = new System.Drawing.Size(150, 33);
            this.btnSaveCourseEdit.TabIndex = 40;
            this.btnSaveCourseEdit.Text = "&Save";
            this.btnSaveCourseEdit.UseVisualStyleBackColor = true;
            this.btnSaveCourseEdit.Click += new System.EventHandler(this.btnSaveCourseEdit_Click_1);
            // 
            // txtCourseMark
            // 
            this.txtCourseMark.Location = new System.Drawing.Point(389, 182);
            this.txtCourseMark.Name = "txtCourseMark";
            this.txtCourseMark.Size = new System.Drawing.Size(100, 22);
            this.txtCourseMark.TabIndex = 39;
            // 
            // cboSelectedCourses
            // 
            this.cboSelectedCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectedCourses.FormattingEnabled = true;
            this.cboSelectedCourses.Location = new System.Drawing.Point(137, 182);
            this.cboSelectedCourses.Name = "cboSelectedCourses";
            this.cboSelectedCourses.Size = new System.Drawing.Size(163, 24);
            this.cboSelectedCourses.TabIndex = 38;
            // 
            // cboStudents
            // 
            this.cboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudents.FormattingEnabled = true;
            this.cboStudents.Location = new System.Drawing.Point(137, 14);
            this.cboStudents.Name = "cboStudents";
            this.cboStudents.Size = new System.Drawing.Size(163, 24);
            this.cboStudents.TabIndex = 37;
            this.cboStudents.SelectedIndexChanged += new System.EventHandler(this.cboStudents_SelectedIndexChanged);
            // 
            // Teacher_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 610);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Teacher_Marks";
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.Teacher_Marks_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteFromCourse;
        private System.Windows.Forms.Button btnSaveStudentEdit;
        private System.Windows.Forms.TextBox txtStudentMark;
        private System.Windows.Forms.ComboBox cboSelectedStudents;
        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFromStudent;
        private System.Windows.Forms.Button btnSaveCourseEdit;
        private System.Windows.Forms.TextBox txtCourseMark;
        private System.Windows.Forms.ComboBox cboSelectedCourses;
        private System.Windows.Forms.ComboBox cboStudents;
        private System.Windows.Forms.Button btnCNewMarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCNMarks;
        private System.Windows.Forms.ComboBox cboCNMCourse;
        private System.Windows.Forms.ComboBox cboCNMStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSNMarks;
        private System.Windows.Forms.ComboBox cboSNMStudent;
        private System.Windows.Forms.ComboBox cboSNMCourse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSNewMarks;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridView dgvMarks;
    }
}