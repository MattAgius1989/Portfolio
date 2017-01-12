namespace CPR_Project_v2
{
    partial class Admin_Courses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._30015379DataSet = new CPR_Project_v2._30015379DataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvViewCQualification = new System.Windows.Forms.DataGridView();
            this.dgvViewCourses = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboTeacherList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditSemesters = new System.Windows.Forms.TextBox();
            this.txtEditYears = new System.Windows.Forms.TextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.dgvEditCQualification = new System.Windows.Forms.DataGridView();
            this.dgvEditCourses = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddExtraQualification = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.cboAddExtraQualifications = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAddCTeacher = new System.Windows.Forms.ComboBox();
            this.cboAddCQualification = new System.Windows.Forms.ComboBox();
            this.txtAddSemesters = new System.Windows.Forms.TextBox();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.txtaddCName = new System.Windows.Forms.TextBox();
            this.txtAddCourseID = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.courseTableAdapter = new CPR_Project_v2._30015379DataSetTableAdapters.CourseTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationTableAdapter = new CPR_Project_v2._30015379DataSetTableAdapters.QualificationTableAdapter();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._30015379DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCourses)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
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
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this._30015379DataSet;
            // 
            // _30015379DataSet
            // 
            this._30015379DataSet.DataSetName = "_30015379DataSet";
            this._30015379DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this._30015379DataSet;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(583, 556);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.dgvViewCQualification);
            this.tabPage1.Controls.Add(this.dgvViewCourses);
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
            this.toolTip4.SetToolTip(this.btnDelete, "Press to Delete Selected Course");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvViewCQualification
            // 
            this.dgvViewCQualification.AllowUserToAddRows = false;
            this.dgvViewCQualification.AllowUserToDeleteRows = false;
            this.dgvViewCQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCQualification.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvViewCQualification.Location = new System.Drawing.Point(6, 219);
            this.dgvViewCQualification.Name = "dgvViewCQualification";
            this.dgvViewCQualification.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewCQualification.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewCQualification.RowTemplate.Height = 24;
            this.dgvViewCQualification.Size = new System.Drawing.Size(563, 255);
            this.dgvViewCQualification.TabIndex = 1;
            // 
            // dgvViewCourses
            // 
            this.dgvViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCourses.Location = new System.Drawing.Point(3, 36);
            this.dgvViewCourses.Name = "dgvViewCourses";
            this.dgvViewCourses.RowTemplate.Height = 24;
            this.dgvViewCourses.Size = new System.Drawing.Size(566, 132);
            this.dgvViewCourses.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboTeacherList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtEditSemesters);
            this.tabPage2.Controls.Add(this.txtEditYears);
            this.tabPage2.Controls.Add(this.btnSaveEdit);
            this.tabPage2.Controls.Add(this.dgvEditCQualification);
            this.tabPage2.Controls.Add(this.dgvEditCourses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboTeacherList
            // 
            this.cboTeacherList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeacherList.FormattingEnabled = true;
            this.cboTeacherList.Location = new System.Drawing.Point(429, 381);
            this.cboTeacherList.Name = "cboTeacherList";
            this.cboTeacherList.Size = new System.Drawing.Size(121, 24);
            this.cboTeacherList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "No. of Semesters: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "No. of Years: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Teacher: ";
            // 
            // txtEditSemesters
            // 
            this.txtEditSemesters.Location = new System.Drawing.Point(429, 467);
            this.txtEditSemesters.Name = "txtEditSemesters";
            this.txtEditSemesters.Size = new System.Drawing.Size(121, 22);
            this.txtEditSemesters.TabIndex = 5;
            // 
            // txtEditYears
            // 
            this.txtEditYears.Location = new System.Drawing.Point(429, 424);
            this.txtEditYears.Name = "txtEditYears";
            this.txtEditYears.Size = new System.Drawing.Size(121, 22);
            this.txtEditYears.TabIndex = 4;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(6, 488);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(150, 33);
            this.btnSaveEdit.TabIndex = 2;
            this.btnSaveEdit.Text = "&Save";
            this.toolTip3.SetToolTip(this.btnSaveEdit, "Save Edits to Course");
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click_1);
            // 
            // dgvEditCQualification
            // 
            this.dgvEditCQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCQualification.Location = new System.Drawing.Point(3, 219);
            this.dgvEditCQualification.Name = "dgvEditCQualification";
            this.dgvEditCQualification.RowTemplate.Height = 24;
            this.dgvEditCQualification.Size = new System.Drawing.Size(569, 132);
            this.dgvEditCQualification.TabIndex = 1;
            // 
            // dgvEditCourses
            // 
            this.dgvEditCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCourses.Location = new System.Drawing.Point(3, 36);
            this.dgvEditCourses.Name = "dgvEditCourses";
            this.dgvEditCourses.RowTemplate.Height = 24;
            this.dgvEditCourses.Size = new System.Drawing.Size(569, 132);
            this.dgvEditCourses.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddExtraQualification);
            this.tabPage3.Controls.Add(this.btnAddCourse);
            this.tabPage3.Controls.Add(this.cboAddExtraQualifications);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.cboAddCTeacher);
            this.tabPage3.Controls.Add(this.cboAddCQualification);
            this.tabPage3.Controls.Add(this.txtAddSemesters);
            this.tabPage3.Controls.Add(this.txtAddYear);
            this.tabPage3.Controls.Add(this.txtaddCName);
            this.tabPage3.Controls.Add(this.txtAddCourseID);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddExtraQualification
            // 
            this.btnAddExtraQualification.Location = new System.Drawing.Point(367, 417);
            this.btnAddExtraQualification.Name = "btnAddExtraQualification";
            this.btnAddExtraQualification.Size = new System.Drawing.Size(189, 29);
            this.btnAddExtraQualification.TabIndex = 15;
            this.btnAddExtraQualification.Text = "S&ave Additional Courses";
            this.toolTip1.SetToolTip(this.btnAddExtraQualification, "Save Additional Qualifications to Course");
            this.btnAddExtraQualification.UseVisualStyleBackColor = true;
            this.btnAddExtraQualification.Click += new System.EventHandler(this.btnAddExtraQualification_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(10, 417);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(127, 29);
            this.btnAddCourse.TabIndex = 14;
            this.btnAddCourse.Text = "&Save";
            this.toolTip2.SetToolTip(this.btnAddCourse, "Save Course");
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // cboAddExtraQualifications
            // 
            this.cboAddExtraQualifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddExtraQualifications.FormattingEnabled = true;
            this.cboAddExtraQualifications.Location = new System.Drawing.Point(430, 335);
            this.cboAddExtraQualifications.Name = "cboAddExtraQualifications";
            this.cboAddExtraQualifications.Size = new System.Drawing.Size(140, 24);
            this.cboAddExtraQualifications.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Additional Qualification:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Teacher:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Qualification:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Semesters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course ID:";
            // 
            // cboAddCTeacher
            // 
            this.cboAddCTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddCTeacher.FormattingEnabled = true;
            this.cboAddCTeacher.Location = new System.Drawing.Point(105, 333);
            this.cboAddCTeacher.Name = "cboAddCTeacher";
            this.cboAddCTeacher.Size = new System.Drawing.Size(161, 24);
            this.cboAddCTeacher.TabIndex = 5;
            // 
            // cboAddCQualification
            // 
            this.cboAddCQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddCQualification.FormattingEnabled = true;
            this.cboAddCQualification.Location = new System.Drawing.Point(105, 270);
            this.cboAddCQualification.Name = "cboAddCQualification";
            this.cboAddCQualification.Size = new System.Drawing.Size(161, 24);
            this.cboAddCQualification.TabIndex = 4;
            // 
            // txtAddSemesters
            // 
            this.txtAddSemesters.Location = new System.Drawing.Point(105, 205);
            this.txtAddSemesters.Name = "txtAddSemesters";
            this.txtAddSemesters.Size = new System.Drawing.Size(161, 22);
            this.txtAddSemesters.TabIndex = 3;
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(105, 142);
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(161, 22);
            this.txtAddYear.TabIndex = 2;
            // 
            // txtaddCName
            // 
            this.txtaddCName.Location = new System.Drawing.Point(105, 79);
            this.txtaddCName.Name = "txtaddCName";
            this.txtaddCName.Size = new System.Drawing.Size(161, 22);
            this.txtaddCName.TabIndex = 1;
            // 
            // txtAddCourseID
            // 
            this.txtAddCourseID.Location = new System.Drawing.Point(105, 16);
            this.txtAddCourseID.Name = "txtAddCourseID";
            this.txtAddCourseID.ReadOnly = true;
            this.txtAddCourseID.Size = new System.Drawing.Size(161, 22);
            this.txtAddCourseID.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(445, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 33);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to &Function";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataMember = "Qualification";
            this.qualificationBindingSource.DataSource = this._30015379DataSet;
            // 
            // qualificationTableAdapter
            // 
            this.qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 610);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cboCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Admin_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._30015379DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCourses)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvViewCQualification;
        private System.Windows.Forms.DataGridView dgvViewCourses;
        private _30015379DataSet _30015379DataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private _30015379DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridView dgvEditCQualification;
        private System.Windows.Forms.DataGridView dgvEditCourses;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.ComboBox cboTeacherList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditSemesters;
        private System.Windows.Forms.TextBox txtEditYears;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button btnAddExtraQualification;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox cboAddExtraQualifications;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAddCTeacher;
        private System.Windows.Forms.ComboBox cboAddCQualification;
        private System.Windows.Forms.TextBox txtAddSemesters;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.TextBox txtaddCName;
        private System.Windows.Forms.TextBox txtAddCourseID;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private _30015379DataSetTableAdapters.QualificationTableAdapter qualificationTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}