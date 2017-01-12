namespace CPR_Project_v2
{
    partial class Admin_Personnel
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
            this.cboSelector = new System.Windows.Forms.ComboBox();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.cboQualification = new System.Windows.Forms.ComboBox();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._30015379DataSet = new CPR_Project_v2._30015379DataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.qualificationTableAdapter = new CPR_Project_v2._30015379DataSetTableAdapters.QualificationTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cboAdminRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._30015379DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSelector
            // 
            this.cboSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelector.FormattingEnabled = true;
            this.cboSelector.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.cboSelector.Location = new System.Drawing.Point(142, 12);
            this.cboSelector.Name = "cboSelector";
            this.cboSelector.Size = new System.Drawing.Size(168, 24);
            this.cboSelector.TabIndex = 0;
            this.cboSelector.SelectedIndexChanged += new System.EventHandler(this.cboSelector_SelectedIndexChanged);
            // 
            // cboID
            // 
            this.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(142, 56);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(168, 24);
            this.cboID.TabIndex = 1;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(142, 98);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(168, 22);
            this.txtFName.TabIndex = 2;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(142, 151);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(168, 22);
            this.txtLName.TabIndex = 3;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(142, 310);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(168, 22);
            this.txtAdd1.TabIndex = 6;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(142, 363);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(168, 22);
            this.txtAdd2.TabIndex = 7;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(142, 416);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(168, 22);
            this.txtSuburb.TabIndex = 8;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(142, 469);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(168, 22);
            this.txtState.TabIndex = 9;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(142, 524);
            this.txtPostcode.MaxLength = 4;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(168, 22);
            this.txtPostcode.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Surname: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Address 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Suburb:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Postcode:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(142, 202);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(168, 22);
            this.dtpDOB.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save edits made to entry");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(324, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "&Delete";
            this.toolTip2.SetToolTip(this.btnDelete, "Delete current entry");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(445, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 33);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return to &Function";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboQualification
            // 
            this.cboQualification.DataSource = this.qualificationBindingSource;
            this.cboQualification.DisplayMember = "QName";
            this.cboQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQualification.FormattingEnabled = true;
            this.cboQualification.Location = new System.Drawing.Point(427, 469);
            this.cboQualification.Name = "cboQualification";
            this.cboQualification.Size = new System.Drawing.Size(168, 24);
            this.cboQualification.TabIndex = 11;
            this.cboQualification.ValueMember = "QCode";
            this.cboQualification.Visible = false;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Qualification:";
            this.label11.Visible = false;
            // 
            // qualificationTableAdapter
            // 
            this.qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Personnel Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 565);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 527);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Course:";
            this.label13.Visible = false;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(427, 524);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(168, 24);
            this.cboCourse.TabIndex = 12;
            this.cboCourse.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(427, 524);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(168, 22);
            this.txtPassword.TabIndex = 35;
            this.txtPassword.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Password";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(335, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "Role:";
            this.label15.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 257);
            this.txtPhone.Mask = "(99) 0000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 22);
            this.txtPhone.TabIndex = 39;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cboAdminRole
            // 
            this.cboAdminRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdminRole.FormattingEnabled = true;
            this.cboAdminRole.Location = new System.Drawing.Point(427, 469);
            this.cboAdminRole.Name = "cboAdminRole";
            this.cboAdminRole.Size = new System.Drawing.Size(168, 24);
            this.cboAdminRole.TabIndex = 40;
            // 
            // Admin_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 610);
            this.Controls.Add(this.cboAdminRole);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboQualification);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.cboSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin_Personnel";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.Admin_Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._30015379DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelector;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboQualification;
        private System.Windows.Forms.Label label11;
        private _30015379DataSet _30015379DataSet;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private _30015379DataSetTableAdapters.QualificationTableAdapter qualificationTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ComboBox cboAdminRole;
    }
}