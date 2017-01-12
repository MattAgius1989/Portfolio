using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Windows.Forms;


namespace CPR_Project_v2
{
    public partial class Admin_Courses : Form
    {
        NewDataClassesDataContext DB = new NewDataClassesDataContext();
       
        public Admin_Courses()
        {
            InitializeComponent();
        }

        private void Admin_Courses_Load(object sender, EventArgs e)
        {
            var courseList = (from c in DB.Courses select c);

            var teacherList = (from t in DB.Persons
                               where t.Type == "Teacher"
                               select new { t.ID, FullName = t.FName + ' ' + t.LName }).ToList();

            var qualificationList = (from q in DB.Qualifications select q);

            cboCourses.DisplayMember = "CName";
            cboCourses.ValueMember = "CID";
            cboCourses.DataSource = courseList;

            cboAddCQualification.DisplayMember = "QCode";
            cboAddCQualification.ValueMember = "QCode";
            cboAddCQualification.DataSource = qualificationList;

            cboAddExtraQualifications.DisplayMember = "QCode";
            cboAddExtraQualifications.ValueMember = "QCode";
            cboAddExtraQualifications.DataSource = qualificationList;

            cboAddCTeacher.DisplayMember = "FullName";
            cboAddCTeacher.ValueMember = "ID";
            cboAddCTeacher.DataSource = teacherList;

            cboTeacherList.DisplayMember = "FullName";
            cboTeacherList.ValueMember = "ID";
            cboTeacherList.DataSource = teacherList;
        }

        private void courseDataReset()
        {

            var courseList = (from c in DB.Courses select c);

            var teacherList = (from t in DB.Persons
                               where t.Type == "Teacher"
                               select new { t.ID, FullName = t.FName + ' ' + t.LName }).ToList();

            var qualificationList = (from q in DB.Qualifications select q);

            var chooseCourse = (from c in DB.Courses
                                where c.CName == cboCourses.Text
                                select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var courseQualification = (from q in DB.Qualification_Courses
                                       where q.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                       join qc in DB.Qualifications on q.QCode equals qc.QCode
                                       join ci in DB.Courses on q.CID equals ci.CID
                                       join p in DB.Persons on ci.TID equals p.ID
                                       select new { Course = ci.CName, qc.QCode, Qualification = qc.QName, ci.TID, Teacher = p.FName + ' ' + p.LName });

            var editCourse = (from ec in DB.Courses
                              where ec.CID == Convert.ToInt32(cboCourses.SelectedValue)
                              select new { ec.CID, Course = ec.CName, ec.Year, Semesters = ec.Semester, ec.TID });

            cboCourses.DisplayMember = "CName";
            cboCourses.ValueMember = "CID";
            cboCourses.DataSource = courseList;

            cboAddCQualification.DisplayMember = "QCode";
            cboAddCQualification.ValueMember = "QCode";
            cboAddCQualification.DataSource = qualificationList;

            cboAddExtraQualifications.DisplayMember = "QCode";
            cboAddExtraQualifications.ValueMember = "QCode";
            cboAddExtraQualifications.DataSource = qualificationList;

            cboAddCTeacher.DisplayMember = "FullName";
            cboAddCTeacher.ValueMember = "ID";
            cboAddCTeacher.DataSource = teacherList;

            cboTeacherList.DisplayMember = "FullName";
            cboTeacherList.ValueMember = "ID";

            cboTeacherList.DataSource = teacherList;
            dgvViewCourses.DataSource = chooseCourse;
            dgvViewCourses.DataSource = chooseCourse;
            dgvEditCourses.DataSource = editCourse;
            dgvViewCQualification.DataSource = courseQualification;
            dgvEditCQualification.DataSource = courseQualification;
        }

        private void refresh()
        {
            dgvViewCourses.Refresh();
            dgvViewCQualification.Refresh();
            dgvEditCQualification.Refresh();
            dgvEditCourses.Refresh();
            txtaddCName.Clear();
            txtAddCourseID.Clear();
            txtAddSemesters.Clear();
            txtAddYear.Clear();
            cboCourses.Refresh();
            courseDataReset();
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var chooseCourse = (from c in DB.Courses 
                                where c.CName == cboCourses.Text 
                                select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var courseQualification = (from q in DB.Qualification_Courses
                                       where q.CID == Convert.ToInt32((cboCourses.SelectedValue).ToString())
                                       join qc in DB.Qualifications on q.QCode equals qc.QCode
                                       join ci in DB.Courses on q.CID equals ci.CID
                                       join p in DB.Persons on ci.TID equals p.ID
                                       select new {Course = ci.CName, qc.QCode, Qualification = qc.QName, ci.TID, Teacher = p.FName + ' ' + p.LName });
           
            dgvViewCourses.DataSource = chooseCourse;
            dgvEditCourses.DataSource = chooseCourse;
            dgvViewCQualification.DataSource = courseQualification;
            dgvEditCQualification.DataSource = courseQualification;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Close();
            admin.ShowDialog();
        }

        private void btnSaveEdit_Click_1(object sender, EventArgs e)
        {
            var saveEdits = (from q in DB.Courses
                             where q.CID == Convert.ToInt32(cboCourses.SelectedValue)
                             select q).First();
            try
            {
                if (Convert.ToInt32(txtEditYears.Text) <= 1 && Convert.ToInt32(txtEditYears.Text) >= 100)
                {
                    try
                    {
                        if (cboTeacherList.Text != "")
                        {
                            saveEdits.TID = Convert.ToInt32(cboTeacherList.SelectedValue);
                        }
                        if (txtEditYears.Text != "")
                        {
                            saveEdits.Year = Convert.ToInt32(txtEditYears.Text);
                        }
                        if (txtEditSemesters.Text != "")
                        {
                            saveEdits.Semester = txtEditSemesters.Text.ToString();
                        }

                        DB.SubmitChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Please ensure all fields and filled correctly!", "Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            refresh();
            courseDataReset();

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course addCourse = new Course();

            try
            {
                if (Convert.ToInt32(txtAddYear.Text) >= 1 && Convert.ToInt32(txtAddYear.Text) <= 100)
                {
                    try
                    {
                        var index = (from i in DB.Courses orderby i.CID descending select i.CID).First();
                        txtAddCourseID.Text = index.ToString();

                        addCourse.CID = Convert.ToInt32(txtAddCourseID.Text) + 1;
                        addCourse.CName = txtaddCName.Text;
                        addCourse.Year = Convert.ToInt32(txtAddYear.Text);
                        addCourse.Semester = txtAddSemesters.Text;
                        addCourse.TID = Convert.ToInt32(cboTeacherList.SelectedValue);

                        DB.Courses.InsertOnSubmit(addCourse);
                        DB.SubmitChanges();

                        Qualification_Course addQC = new Qualification_Course();
                        addQC.CID = Convert.ToInt32(txtAddCourseID.Text) + 1;
                        addQC.QCode = cboAddCQualification.SelectedValue.ToString();


                        DB.Qualification_Courses.InsertOnSubmit(addQC);
                        DB.SubmitChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Please ensure all fields are filled correctly!", "Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cboAddCQualification.SelectedIndex = 0;
            cboAddExtraQualifications.SelectedIndex = 0;
            cboTeacherList.SelectedIndex = 0;

            refresh();
            courseDataReset();
        }

        private void btnAddExtraQualification_Click(object sender, EventArgs e)
        {
            Qualification_Course addQC = new Qualification_Course();

            try
            {
                addQC.CID = Convert.ToInt32(cboCourses.SelectedValue);
                addQC.QCode = cboAddExtraQualifications.SelectedValue.ToString();

                DB.Qualification_Courses.InsertOnSubmit(addQC);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            refresh();
            courseDataReset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var courseDelete = (from c in DB.Courses
                                where c.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                select c).First();

            var qualDelete = (from q in DB.Qualification_Courses
                              where q.CID == Convert.ToInt32(cboCourses.SelectedValue)
                              select q).ToList();

            var stucourseDelete = (from s in DB.Student_Courses
                                   where s.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                   select s).ToList();
            try
            {

                foreach (var s in stucourseDelete)
                {
                    DB.Student_Courses.DeleteOnSubmit(s);
                }

                foreach (var q in qualDelete)
                {
                    DB.Qualification_Courses.DeleteOnSubmit(q);
                }

                DB.Courses.DeleteOnSubmit(courseDelete);
                DB.SubmitChanges();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            refresh();
            courseDataReset();
        }
    }
}