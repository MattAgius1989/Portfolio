namespace CPR_Project_v2
{
    partial class Admin_Qualification
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
            this.cboQualifications = new System.Windows.Forms.ComboBox();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._30015379DataSet = new CPR_Project_v2._30015379DataSet();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvViewCourses = new System.Windows.Forms.DataGridView();
            this.dgvViewQualification = new System.Windows.Forms.DataGridView();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.cboRemCourseList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQDuration = new System.Windows.Forms.TextBox();
            this.txtQName = new System.Windows.Forms.TextBox();
            this.cboAddCourseList = new System.Windows.Forms.ComboBox();
            this.dgvEditCourses = new System.Windows.Forms.DataGridView();
            this.dgvEditQualification = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnSaveQual = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAddCourse = new System.Windows.Forms.ComboBox();
            this.txtAddDuration = new System.Windows.Forms.TextBox();
            this.txtAddQName = new System.Windows.Forms.TextBox();
            this.txtAddQCode = new System.Windows.Forms.TextBox();
            this.qualificationTableAdapter = new CPR_Project_v2._30015379DataSetTableAdapters.QualificationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._30015379DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewQualification)).BeginInit();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditQualification)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboQualifications
            // 
            this.cboQualifications.DataSource = this.qualificationBindingSource;
            this.cboQualifications.DisplayMember = "QName";
            this.cboQualifications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualifications.FormattingEnabled = true;
            this.cboQualifications.Location = new System.Drawing.Point(12, 12);
            this.cboQualifications.Name = "cboQualifications";
            this.cboQualifications.Size = new System.Drawing.Size(189, 24);
            this.cboQualifications.TabIndex = 0;
            this.cboQualifications.ValueMember = "QCode";
            this.cboQualifications.SelectedIndexChanged += new System.EventHandler(this.cboQualifications_SelectedIndexChanged);
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataMember = "Qualification";
            this.qualificationBindingSource.DataSource = this._30015379DataSet;
            // 
            // _30015379DataSet
            // 
            this._30015379DataSet.DataSetName = "_30015379DataSet";
            this._30015379DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Controls.Add(this.tabEdit);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 556);
            this.tabControl1.TabIndex = 2;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.btnDelete);
            this.tabView.Controls.Add(this.dgvViewCourses);
            this.tabView.Controls.Add(this.dgvViewQualification);
            this.tabView.Location = new System.Drawing.Point(4, 25);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(575, 527);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
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
            this.dgvViewCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCourses.Location = new System.Drawing.Point(3, 219);
            this.dgvViewCourses.Name = "dgvViewCourses";
            this.dgvViewCourses.RowTemplate.Height = 24;
            this.dgvViewCourses.Size = new System.Drawing.Size(569, 255);
            this.dgvViewCourses.TabIndex = 1;
            // 
            // dgvViewQualification
            // 
            this.dgvViewQualification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewQualification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewQualification.Location = new System.Drawing.Point(3, 36);
            this.dgvViewQualification.Name = "dgvViewQualification";
            this.dgvViewQualification.RowTemplate.Height = 24;
            this.dgvViewQualification.Size = new System.Drawing.Size(569, 132);
            this.dgvViewQualification.TabIndex = 0;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.btnRemoveCourse);
            this.tabEdit.Controls.Add(this.btnAddCourse);
            this.tabEdit.Controls.Add(this.cboRemCourseList);
            this.tabEdit.Controls.Add(this.label2);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Controls.Add(this.btnSave);
            this.tabEdit.Controls.Add(this.txtQDuration);
            this.tabEdit.Controls.Add(this.txtQName);
            this.tabEdit.Controls.Add(this.cboAddCourseList);
            this.tabEdit.Controls.Add(this.dgvEditCourses);
            this.tabEdit.Controls.Add(this.dgvEditQualification);
            this.tabEdit.Location = new System.Drawing.Point(4, 25);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(575, 527);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(246, 475);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(119, 24);
            this.btnRemoveCourse.TabIndex = 12;
            this.btnRemoveCourse.Text = "Remove &Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(246, 441);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(119, 24);
            this.btnAddCourse.TabIndex = 11;
            this.btnAddCourse.Text = "&Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // cboRemCourseList
            // 
            this.cboRemCourseList.FormattingEnabled = true;
            this.cboRemCourseList.Location = new System.Drawing.Point(400, 475);
            this.cboRemCourseList.Name = "cboRemCourseList";
            this.cboRemCourseList.Size = new System.Drawing.Size(169, 24);
            this.cboRemCourseList.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qualification Duration: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qualification Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQDuration
            // 
            this.txtQDuration.Location = new System.Drawing.Point(400, 407);
            this.txtQDuration.Name = "txtQDuration";
            this.txtQDuration.Size = new System.Drawing.Size(169, 22);
            this.txtQDuration.TabIndex = 4;
            // 
            // txtQName
            // 
            this.txtQName.Location = new System.Drawing.Point(400, 373);
            this.txtQName.Name = "txtQName";
            this.txtQName.Size = new System.Drawing.Size(169, 22);
            this.txtQName.TabIndex = 3;
            // 
            // cboAddCourseList
            // 
            this.cboAddCourseList.FormattingEnabled = true;
            this.cboAddCourseList.Location = new System.Drawing.Point(400, 441);
            this.cboAddCourseList.Name = "cboAddCourseList";
            this.cboAddCourseList.Size = new System.Drawing.Size(169, 24);
            this.cboAddCourseList.TabIndex = 2;
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
            this.dgvEditCourses.TabIndex = 1;
            // 
            // dgvEditQualification
            // 
            this.dgvEditQualification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditQualification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditQualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditQualification.Location = new System.Drawing.Point(3, 36);
            this.dgvEditQualification.Name = "dgvEditQualification";
            this.dgvEditQualification.RowTemplate.Height = 24;
            this.dgvEditQualification.Size = new System.Drawing.Size(569, 132);
            this.dgvEditQualification.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btnSaveQual);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.cboAddCourse);
            this.tabAdd.Controls.Add(this.txtAddDuration);
            this.tabAdd.Controls.Add(this.txtAddQName);
            this.tabAdd.Controls.Add(this.txtAddQCode);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(575, 527);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnSaveQual
            // 
            this.btnSaveQual.Location = new System.Drawing.Point(29, 326);
            this.btnSaveQual.Name = "btnSaveQual";
            this.btnSaveQual.Size = new System.Drawing.Size(127, 29);
            this.btnSaveQual.TabIndex = 10;
            this.btnSaveQual.Text = "Save";
            this.btnSaveQual.UseVisualStyleBackColor = true;
            this.btnSaveQual.Click += new System.EventHandler(this.btnSaveQual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Course: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Duration: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Qualification Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qualification Code: ";
            // 
            // cboAddCourse
            // 
            this.cboAddCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddCourse.FormattingEnabled = true;
            this.cboAddCourse.Location = new System.Drawing.Point(190, 242);
            this.cboAddCourse.Name = "cboAddCourse";
            this.cboAddCourse.Size = new System.Drawing.Size(161, 24);
            this.cboAddCourse.TabIndex = 3;
            // 
            // txtAddDuration
            // 
            this.txtAddDuration.Location = new System.Drawing.Point(190, 179);
            this.txtAddDuration.Name = "txtAddDuration";
            this.txtAddDuration.Size = new System.Drawing.Size(161, 22);
            this.txtAddDuration.TabIndex = 2;
            // 
            // txtAddQName
            // 
            this.txtAddQName.Location = new System.Drawing.Point(190, 116);
            this.txtAddQName.Name = "txtAddQName";
            this.txtAddQName.Size = new System.Drawing.Size(161, 22);
            this.txtAddQName.TabIndex = 1;
            // 
            // txtAddQCode
            // 
            this.txtAddQCode.Location = new System.Drawing.Point(190, 53);
            this.txtAddQCode.Name = "txtAddQCode";
            this.txtAddQCode.Size = new System.Drawing.Size(161, 22);
            this.txtAddQCode.TabIndex = 0;
            // 
            // qualificationTableAdapter
            // 
            this.qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Qualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 610);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboQualifications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Qualification";
            this.Text = "Qualification";
            this.Load += new System.EventHandler(this.Admin_Qualification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._30015379DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewQualification)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditQualification)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQualifications;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.DataGridView dgvViewCourses;
        private System.Windows.Forms.DataGridView dgvViewQualification;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboAddCourseList;
        private System.Windows.Forms.DataGridView dgvEditCourses;
        private System.Windows.Forms.DataGridView dgvEditQualification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQDuration;
        private System.Windows.Forms.TextBox txtQName;
        private _30015379DataSet _30015379DataSet;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private _30015379DataSetTableAdapters.QualificationTableAdapter qualificationTableAdapter;
        private System.Windows.Forms.ComboBox cboRemCourseList;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txtAddDuration;
        private System.Windows.Forms.TextBox txtAddQName;
        private System.Windows.Forms.TextBox txtAddQCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAddCourse;
        private System.Windows.Forms.Button btnSaveQual;
    }
}