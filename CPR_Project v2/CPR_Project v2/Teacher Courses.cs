using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPR_Project_v2
{
    public partial class Teacher_Courses : Form
    {
        NewDataClassesDataContext DB = new NewDataClassesDataContext();

        public Teacher_Courses()
        {
            InitializeComponent();
        }

        private void Teacher_Courses_Load(object sender, EventArgs e)
        {
            var courses = (from c in DB.Courses select c).ToList();

            var teachers = (from t in DB.Persons
                            where t.Type == "Teacher"
                            select new { t.ID, FullName = t.FName + ' ' + t.LName }).ToList();

            var qualifications = (from q in DB.Qualifications select q).ToList();

            var currentqualifications = (from cq in DB.Qualification_Courses
                                         where cq.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                         join q in DB.Qualifications on cq.QCode equals q.QCode
                                         select q);

            var addqcourselist = (from aq in DB.Qualification_Courses
                                  where aq.CID != Convert.ToInt32(cboCourses.SelectedValue)
                                  join q in DB.Qualifications on aq.QCode equals q.QCode
                                  select q).Except(currentqualifications);
            
            cboCourses.DisplayMember = "CName";
            cboCourses.ValueMember = "CID";
            cboCourses.DataSource = courses;

            cboAddQualifications.DisplayMember = "QName";
            cboAddQualifications.ValueMember = "QCode";
            cboAddQualifications.DataSource = addqcourselist;
            
            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";
            cboQualifications.DataSource = qualifications;
            
            cboEditTeacher.DisplayMember = "FullName";
            cboEditTeacher.ValueMember = "ID";
            cboEditTeacher.DataSource = teachers;
            
            cboTeachers.DisplayMember = "FullName";
            cboTeachers.ValueMember = "ID";
            cboTeachers.DataSource = teachers;
            
        }

        private void refreshdata()
        {
            cboAddQualifications.Refresh();
            cboCourses.Refresh();
            cboEditTeacher.Refresh();
            cboQualifications.Refresh();
            cboTeachers.Refresh();
            dgvTCourseView.Refresh();
            dgvTEditCourses.Refresh();
            dgvTEditQualification.Refresh();
            dgvViewTQualifications.Refresh();
        }

        private void courseDataReset()
        {

            var courses = (from c in DB.Courses select c).ToList();

            var teachers = (from t in DB.Persons
                            where t.Type == "Teacher"
                            select new { t.ID, FullName = t.FName + ' ' + t.LName }).ToList();

            var qualifications = (from q in DB.Qualifications select q).ToList();

            var chooseCourse = (from c in DB.Courses
                                where c.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var courseQualifications = (from qc in DB.Qualification_Courses
                                        where qc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                        join q in DB.Qualifications on qc.QCode equals q.QCode
                                        join c in DB.Courses on qc.CID equals c.CID
                                        join t in DB.Persons on c.TID equals t.ID
                                        select new { Course = c.CName, qc.QCode, Qualification = q.QName, c.TID, Teacher = t.FName + ' ' + t.LName });

            var currentqualifications = (from cq in DB.Qualification_Courses
                                         where cq.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                         join q in DB.Qualifications on cq.QCode equals q.QCode
                                         select q);

            var addqcourselist = (from aq in DB.Qualification_Courses
                                  where aq.CID != Convert.ToInt32(cboCourses.SelectedValue)
                                  join q in DB.Qualifications on aq.QCode equals q.QCode
                                  select q).Except(currentqualifications);

            cboCourses.DisplayMember = "CName";
            cboCourses.ValueMember = "CID";
            cboCourses.DataSource = courses;

            cboAddQualifications.DisplayMember = "QName";
            cboAddQualifications.ValueMember = "QCode";
            cboAddQualifications.DataSource = addqcourselist;

            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";
            cboQualifications.DataSource = qualifications;

            cboEditTeacher.DisplayMember = "FullName";
            cboEditTeacher.ValueMember = "ID";
            cboEditTeacher.DataSource = teachers;

            cboTeachers.DisplayMember = "FullName";
            cboTeachers.ValueMember = "ID";
            cboTeachers.DataSource = teachers;

            dgvTCourseView.DataSource = chooseCourse;
            dgvTEditCourses.DataSource = chooseCourse;
            dgvTEditQualification.DataSource = courseQualifications;
            dgvViewTQualifications.DataSource = courseQualifications;
        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chooseCourse = (from c in DB.Courses
                                where c.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var courseQualifications = (from qc in DB.Qualification_Courses
                                            where qc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                            join q in DB.Qualifications on qc.QCode equals q.QCode
                                            join c in DB.Courses on qc.CID equals c.CID
                                            join t in DB.Persons on c.TID equals t.ID
                                        select new { Course = c.CName, qc.QCode, Qualification = q.QName, c.TID, Teacher = t.FName + ' ' + t.LName });

            var currentqualifications = (from cq in DB.Qualification_Courses
                                         where cq.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                         join q in DB.Qualifications on cq.QCode equals q.QCode
                                         select q);

            var addqcourselist = (from aq in DB.Qualification_Courses
                                  where aq.CID != Convert.ToInt32(cboCourses.SelectedValue)
                                  join q in DB.Qualifications on aq.QCode equals q.QCode
                                  select q).Except(currentqualifications);

            cboAddQualifications.DisplayMember = "QName";
            cboAddQualifications.ValueMember = "QCode";
            cboAddQualifications.DataSource = addqcourselist;
            cboAddQualifications.SelectedText = "";
            
            dgvTCourseView.DataSource = chooseCourse;
            dgvTEditCourses.DataSource = chooseCourse;
            dgvTEditQualification.DataSource = courseQualifications;
            dgvViewTQualifications.DataSource = courseQualifications;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var courseDelete = (from d in DB.Courses
                                where d.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                select d).First() ;

            var qualDelete = (from dc in DB.Qualification_Courses
                              where dc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                              select dc);

            var stuCourseDelete = (from s in DB.Student_Courses
                                   where s.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                   select s).ToList();
            try
            {
                foreach (var s in stuCourseDelete)
                {
                    DB.Student_Courses.DeleteOnSubmit(s);
                }

                foreach (var dc in qualDelete)
                {
                    DB.Qualification_Courses.DeleteOnSubmit(dc);
                }

                DB.Courses.DeleteOnSubmit(courseDelete);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            refreshdata();
            courseDataReset();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var saveEdits = (from q in DB.Courses
                             where q.CID == Convert.ToInt32(cboCourses.SelectedValue)
                             select q).First();
            try
            {
                if (Convert.ToInt32(txtEditYears.Text) >= 1 && (Convert.ToInt32(txtEditYears.Text) <= 100))
                {
                    try
                    {
                        if (cboEditTeacher.Text != "")
                        {
                            saveEdits.TID = Convert.ToInt32(cboEditTeacher.SelectedValue);
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
                catch
            {
                MessageBox.Show("Please ensure all data is correct!", "Error!");
            }
        
            refreshdata();
            courseDataReset();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTeacher teach = new frmTeacher();
            this.Close();
            teach.ShowDialog();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course addCourse = new Course();
            try
            {
                if (Convert.ToInt32(txtYear.Text) <= 1 && Convert.ToInt32(txtYear.Text) >= 100)
                {
                    try
                    {
                        var index = (from i in DB.Courses orderby i.CID descending select i.CID).First();
                        txtCID.Text = index.ToString();

                        addCourse.CID = Convert.ToInt32(txtCID.Text) + 1;
                        addCourse.CName = txtCName.Text;
                        addCourse.Year = Convert.ToInt32(txtYear.Text);
                        addCourse.Semester = txtSemesters.Text;
                        addCourse.TID = Convert.ToInt32(cboTeachers.SelectedValue);

                        DB.Courses.InsertOnSubmit(addCourse);
                        DB.SubmitChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Please ensure all forms are filled correctly!", "Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Qualification_Course addQC = new Qualification_Course();
            try
            {
                addQC.CID = Convert.ToInt32(txtCID.Text) + 1;
                addQC.QCode = cboQualifications.SelectedValue.ToString();

                DB.Qualification_Courses.InsertOnSubmit(addQC);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cboQualifications.SelectedIndex = 0;
            cboAddQualifications.SelectedIndex = 0;
            cboTeachers.SelectedIndex = 0;

            refreshdata();
            courseDataReset();
        }

        private void btnAddQualification_Click(object sender, EventArgs e)
        {
            Qualification_Course qcourse = new Qualification_Course();
            try
            {
                qcourse.CID = Convert.ToInt32(cboCourses.SelectedValue);
                qcourse.QCode = cboAddQualifications.SelectedValue.ToString();

                DB.Qualification_Courses.InsertOnSubmit(qcourse);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cboAddQualifications.SelectedText = "";
            refreshdata();
            courseDataReset();
        }
    }
}
