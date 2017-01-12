namespace CPR_Project_v2
{
    partial class Teacher_Qualification
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
            this.cboQualifications = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvViewCourses = new System.Windows.Forms.DataGridView();
            this.dgvViewQualifications = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEditDuration = new System.Windows.Forms.TextBox();
            this.txtEditQName = new System.Windows.Forms.TextBox();
            this.cboEditRemoveCourseList = new System.Windows.Forms.ComboBox();
            this.cboEditAddCourseList = new System.Windows.Forms.ComboBox();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvEditQualifications = new System.Windows.Forms.DataGridView();
            this.dgvEditCourses = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboAddCourse = new System.Windows.Forms.ComboBox();
            this.txtAddDuration = new System.Windows.Forms.TextBox();
            this.txtAddQName = new System.Windows.Forms.TextBox();
            this.txtAddQCode = new System.Windows.Forms.TextBox();
            this.btnAddQualification = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewQualifications)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditQualifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCourses)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboQualifications
            // 
            this.cboQualifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualifications.FormattingEnabled = true;
            this.cboQualifications.Location = new System.Drawing.Point(12, 12);
            this.cboQualifications.Name = "cboQualifications";
            this.cboQualifications.Size = new System.Drawing.Size(189, 24);
            this.cboQualifications.TabIndex = 0;
            this.cboQualifications.SelectedIndexChanged += new System.EventHandler(this.cboQualifications_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(445, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 33);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "&Return to Function";
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
            this.tabPage1.Controls.Add(this.dgvViewCourses);
            this.tabPage1.Controls.Add(this.dgvViewQualifications);
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
            this.btnDelete.Location = new System.Drawing.Point(7, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvViewCourses
            // 
            this.dgvViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCourses.Location = new System.Drawing.Point(3, 219);
            this.dgvViewCourses.Name = "dgvViewCourses";
            this.dgvViewCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvViewCourses.RowTemplate.Height = 24;
            this.dgvViewCourses.Size = new System.Drawing.Size(569, 255);
            this.dgvViewCourses.TabIndex = 1;
            // 
            // dgvViewQualifications
            // 
            this.dgvViewQualifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewQualifications.Location = new System.Drawing.Point(3, 36);
            this.dgvViewQualifications.Name = "dgvViewQualifications";
            this.dgvViewQualifications.RowTemplate.Height = 24;
            this.dgvViewQualifications.Size = new System.Drawing.Size(569, 132);
            this.dgvViewQualifications.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtEditDuration);
            this.tabPage2.Controls.Add(this.txtEditQName);
            this.tabPage2.Controls.Add(this.cboEditRemoveCourseList);
            this.tabPage2.Controls.Add(this.cboEditAddCourseList);
            this.tabPage2.Controls.Add(this.btnRemoveCourse);
            this.tabPage2.Controls.Add(this.btnAddCourse);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvEditQualifications);
            this.tabPage2.Controls.Add(this.dgvEditCourses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtEditDuration
            // 
            this.txtEditDuration.Location = new System.Drawing.Point(400, 407);
            this.txtEditDuration.Name = "txtEditDuration";
            this.txtEditDuration.Size = new System.Drawing.Size(169, 22);
            this.txtEditDuration.TabIndex = 12;
            // 
            // txtEditQName
            // 
            this.txtEditQName.Location = new System.Drawing.Point(400, 373);
            this.txtEditQName.Name = "txtEditQName";
            this.txtEditQName.Size = new System.Drawing.Size(169, 22);
            this.txtEditQName.TabIndex = 11;
            // 
            // cboEditRemoveCourseList
            // 
            this.cboEditRemoveCourseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditRemoveCourseList.FormattingEnabled = true;
            this.cboEditRemoveCourseList.Location = new System.Drawing.Point(400, 475);
            this.cboEditRemoveCourseList.Name = "cboEditRemoveCourseList";
            this.cboEditRemoveCourseList.Size = new System.Drawing.Size(169, 24);
            this.cboEditRemoveCourseList.TabIndex = 10;
            // 
            // cboEditAddCourseList
            // 
            this.cboEditAddCourseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditAddCourseList.FormattingEnabled = true;
            this.cboEditAddCourseList.Location = new System.Drawing.Point(400, 441);
            this.cboEditAddCourseList.Name = "cboEditAddCourseList";
            this.cboEditAddCourseList.Size = new System.Drawing.Size(169, 24);
            this.cboEditAddCourseList.TabIndex = 9;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(246, 475);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(119, 24);
            this.btnRemoveCourse.TabIndex = 8;
            this.btnRemoveCourse.Text = "Remove &Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(246, 441);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(119, 24);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "&Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Qualification Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Qualification Name:";
            // 
            // dgvEditQualifications
            // 
            this.dgvEditQualifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditQualifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditQualifications.Location = new System.Drawing.Point(3, 36);
            this.dgvEditQualifications.Name = "dgvEditQualifications";
            this.dgvEditQualifications.RowTemplate.Height = 24;
            this.dgvEditQualifications.Size = new System.Drawing.Size(569, 132);
            this.dgvEditQualifications.TabIndex = 1;
            // 
            // dgvEditCourses
            // 
            this.dgvEditCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditCourses.Location = new System.Drawing.Point(3, 219);
            this.dgvEditCourses.Name = "dgvEditCourses";
            this.dgvEditCourses.RowTemplate.Height = 24;
            this.dgvEditCourses.Size = new System.Drawing.Size(569, 132);
            this.dgvEditCourses.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cboAddCourse);
            this.tabPage3.Controls.Add(this.txtAddDuration);
            this.tabPage3.Controls.Add(this.txtAddQName);
            this.tabPage3.Controls.Add(this.txtAddQCode);
            this.tabPage3.Controls.Add(this.btnAddQualification);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboAddCourse
            // 
            this.cboAddCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddCourse.FormattingEnabled = true;
            this.cboAddCourse.Location = new System.Drawing.Point(190, 242);
            this.cboAddCourse.Name = "cboAddCourse";
            this.cboAddCourse.Size = new System.Drawing.Size(161, 24);
            this.cboAddCourse.TabIndex = 8;
            // 
            // txtAddDuration
            // 
            this.txtAddDuration.Location = new System.Drawing.Point(190, 179);
            this.txtAddDuration.Name = "txtAddDuration";
            this.txtAddDuration.Size = new System.Drawing.Size(161, 22);
            this.txtAddDuration.TabIndex = 7;
            // 
            // txtAddQName
            // 
            this.txtAddQName.Location = new System.Drawing.Point(190, 116);
            this.txtAddQName.Name = "txtAddQName";
            this.txtAddQName.Size = new System.Drawing.Size(161, 22);
            this.txtAddQName.TabIndex = 6;
            // 
            // txtAddQCode
            // 
            this.txtAddQCode.Location = new System.Drawing.Point(190, 53);
            this.txtAddQCode.Name = "txtAddQCode";
            this.txtAddQCode.Size = new System.Drawing.Size(161, 22);
            this.txtAddQCode.TabIndex = 5;
            // 
            // btnAddQualification
            // 
            this.btnAddQualification.Location = new System.Drawing.Point(29, 326);
            this.btnAddQualification.Name = "btnAddQualification";
            this.btnAddQualification.Size = new System.Drawing.Size(127, 29);
            this.btnAddQualification.TabIndex = 4;
            this.btnAddQualification.Text = "&Save";
            this.btnAddQualification.UseVisualStyleBackColor = true;
            this.btnAddQualification.Click += new System.EventHandler(this.btnAddQualification_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qualification Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qualification Code:";
            // 
            // Teacher_Qualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 610);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboQualifications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Teacher_Qualification";
            this.Text = "Qualification";
            this.Load += new System.EventHandler(this.Teacher_Qualification_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewQualifications)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditQualifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCourses)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQualifications;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddQualification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAddCourse;
        private System.Windows.Forms.TextBox txtAddDuration;
        private System.Windows.Forms.TextBox txtAddQName;
        private System.Windows.Forms.TextBox txtAddQCode;
        private System.Windows.Forms.TextBox txtEditDuration;
        private System.Windows.Forms.TextBox txtEditQName;
        private System.Windows.Forms.ComboBox cboEditRemoveCourseList;
        private System.Windows.Forms.ComboBox cboEditAddCourseList;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEditQualifications;
        private System.Windows.Forms.DataGridView dgvEditCourses;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvViewCourses;
        private System.Windows.Forms.DataGridView dgvViewQualifications;
    }
}