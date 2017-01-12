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
    public partial class Teacher_Qualification : Form
    {
        NewDataClassesDataContext DB = new NewDataClassesDataContext();

        public Teacher_Qualification()
        {
            InitializeComponent();
        }

        private void Teacher_Qualification_Load(object sender, EventArgs e)
        {
            var qual = (from q in DB.Qualifications select q);

            cboQualifications.DataSource = qual;
            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";

            string qualification = cboQualifications.SelectedValue.ToString();

            var chooseCourse = (from c in DB.Qualification_Courses
                                where c.QCode == cboQualifications.SelectedValue.ToString()
                                join q in DB.Courses on c.CID equals q.CID
                                select new { q.CID, Course = q.CName, q.Year, Semesters = q.Semester, q.TID });

            var courseQualification = (from q in DB.Qualifications
                                       where q.QCode == cboQualifications.SelectedValue.ToString()
                                       select q);

            var editCourse = (from ec in DB.Qualification_Courses
                              where ec.QCode == cboQualifications.SelectedValue.ToString()
                              join c in DB.Courses on ec.CID equals c.CID
                              select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var removecourselist = (from c in DB.Qualification_Courses
                                    where c.QCode == cboQualifications.SelectedValue.ToString()
                                    join q in DB.Courses on c.CID equals q.CID
                                    select new { q.CName, q.CID });

            var addcourselist = (from c in DB.Qualification_Courses
                                 where c.QCode != cboQualifications.SelectedValue.ToString()
                                 join q in DB.Courses on c.CID equals q.CID
                                 select new { q.CName, q.CID }).Except(removecourselist);


            var courselist = (from c in DB.Courses select c);


            cboEditAddCourseList.DisplayMember = "CName";
            cboEditAddCourseList.ValueMember = "CID";
            cboEditAddCourseList.DataSource = addcourselist;

            cboEditRemoveCourseList.DisplayMember = "CName";
            cboEditRemoveCourseList.ValueMember = "CID";
            cboEditRemoveCourseList.DataSource = removecourselist;

            cboAddCourse.DisplayMember = "CName";
            cboAddCourse.ValueMember = "CID";
            cboAddCourse.DataSource = courselist;

            dgvViewCourses.DataSource = chooseCourse;
            dgvEditCourses.DataSource = editCourse;
            dgvViewQualifications.DataSource = courseQualification;
            dgvEditQualifications.DataSource = courseQualification;

        }

        private void refreshdata()
        {
            dgvEditCourses.Refresh();
            dgvViewCourses.Refresh();
            dgvEditQualifications.Refresh();
            dgvViewQualifications.Refresh();
            cboEditAddCourseList.Refresh();
            cboEditRemoveCourseList.Refresh();
            txtEditDuration.Text = "";
            txtEditQName.Text = "";

            var qual = (from q in DB.Qualifications select q);

            cboQualifications.DataSource = qual;
            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";
        }

        private void courseDataReset()
        {
            var qual = (from q in DB.Qualifications select q);

            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";
            cboQualifications.DataSource = qual;

            string qualification = cboQualifications.SelectedValue.ToString();

            var chooseCourse = (from c in DB.Qualification_Courses
                                where c.QCode == cboQualifications.SelectedValue.ToString()
                                join q in DB.Courses on c.CID equals q.CID
                                select new { q.CID, Course = q.CName, q.Year, Semesters = q.Semester, q.TID });

            var courseQualification = (from q in DB.Qualifications
                                       where q.QCode == cboQualifications.SelectedValue.ToString()
                                       select q);

            var editCourse = (from ec in DB.Qualification_Courses
                              where ec.QCode == cboQualifications.SelectedValue.ToString()
                              join c in DB.Courses on ec.CID equals c.CID
                              select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var removecourselist = (from c in DB.Qualification_Courses
                                    where c.QCode == cboQualifications.SelectedValue.ToString()
                                    join q in DB.Courses on c.CID equals q.CID
                                    select new { q.CName, q.CID });

            var addcourselist = (from c in DB.Qualification_Courses
                                 where c.QCode == cboQualifications.SelectedValue.ToString()
                                 join q in DB.Courses on c.CID equals q.CID
                                 select new { q.CName, q.CID }).Except(removecourselist);

            var courselist = (from c in DB.Courses select c);

            cboEditRemoveCourseList.DisplayMember = "CName";
            cboEditRemoveCourseList.ValueMember = "CID";
            cboEditRemoveCourseList.DataSource = removecourselist;

            cboEditAddCourseList.DisplayMember = "CName";
            cboEditAddCourseList.ValueMember = "CID";
            cboEditAddCourseList.DataSource = addcourselist;

            cboAddCourse.DisplayMember = "CName";
            cboAddCourse.ValueMember = "CID";
            cboAddCourse.DataSource = courselist;

            dgvViewCourses.DataSource = chooseCourse;
            dgvEditCourses.DataSource = editCourse;
            dgvViewQualifications.DataSource = courseQualification;
            dgvEditQualifications.DataSource = courseQualification;
        }

        private void cboQualifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qualification = cboQualifications.SelectedValue.ToString();

            var chooseCourse = (from c in DB.Qualification_Courses
                                where c.QCode == cboQualifications.SelectedValue.ToString()
                                join q in DB.Courses on c.CID equals q.CID
                                select new { q.CID, Course = q.CName, q.Year, Semesters = q.Semester, q.TID });

            var courseQualification = (from q in DB.Qualifications
                                       where q.QCode == cboQualifications.SelectedValue.ToString()
                                       select q);

            var editCourse = (from ec in DB.Qualification_Courses
                              where ec.QCode == cboQualifications.SelectedValue.ToString()
                              join c in DB.Courses on ec.CID equals c.CID
                              select new { c.CID, Course = c.CName, c.Year, Semesters = c.Semester, c.TID });

            var removecourselist = (from c in DB.Qualification_Courses
                                    where c.QCode == cboQualifications.SelectedValue.ToString()
                                    join q in DB.Courses on c.CID equals q.CID
                                    select new { q.CName, q.CID }).Distinct();

            var addcourselist = (from c in DB.Qualification_Courses
                                 join q in DB.Courses on c.CID equals q.CID
                                 select new { q.CName, q.CID }).Distinct().Except(removecourselist);

            var courselist = (from c in DB.Courses select c);

            cboEditRemoveCourseList.DisplayMember = "CName";
            cboEditRemoveCourseList.ValueMember = "CID";
            cboEditRemoveCourseList.DataSource = removecourselist;

            cboEditAddCourseList.DisplayMember = "CName";
            cboEditAddCourseList.ValueMember = "CID";
            cboEditAddCourseList.DataSource = addcourselist;

            cboAddCourse.DisplayMember = "CName";
            cboAddCourse.ValueMember = "CID";
            cboAddCourse.DataSource = courselist;

            dgvViewCourses.DataSource = chooseCourse;
            dgvEditCourses.DataSource = editCourse;
            dgvViewQualifications.DataSource = courseQualification;
            dgvEditQualifications.DataSource = courseQualification;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTeacher teach = new frmTeacher();
            this.Close();
            teach.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var saveEdits = (from q in DB.Qualifications
                                 where q.QCode == cboQualifications.SelectedValue.ToString()
                                 select q).First();

                saveEdits.QCode = cboQualifications.SelectedValue.ToString();

                if (txtEditQName.Text != "" && txtEditDuration.Text != "")
                {
                    saveEdits.QName = txtEditQName.Text;
                    saveEdits.Duration = txtEditDuration.Text;

                    DB.SubmitChanges();
                }
                else if (txtEditQName.Text == "" && txtEditDuration.Text != "")
                {
                    saveEdits.Duration = txtEditDuration.Text;

                    DB.SubmitChanges();
                }
                else if (txtEditQName.Text != "" && txtEditDuration.Text == "")
                {
                    saveEdits.QName = txtEditQName.Text;

                    DB.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Please fill fields!");
                }
            }
            catch
            {
                MessageBox.Show("Please ensure there is a valid Qualification to edit!", "Error!");
            }
            refreshdata();
            courseDataReset();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var add = (from c in DB.Qualification_Courses
                           where c.QCode == cboQualifications.SelectedValue.ToString()
                           select c).First();

                Qualification_Course qcourse = new Qualification_Course();
                qcourse.QCode = cboQualifications.SelectedValue.ToString();
                qcourse.CID = Convert.ToInt32(cboEditAddCourseList.SelectedValue);

                DB.Qualification_Courses.InsertOnSubmit(qcourse);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            refreshdata();
            courseDataReset();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                var remove = (from c in DB.Qualification_Courses
                              where c.CID == Convert.ToInt32(cboEditRemoveCourseList.SelectedValue)
                              select c);

                foreach (var q in remove)
                {
                    DB.Qualification_Courses.DeleteOnSubmit(q);
                }

                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            refreshdata();
            courseDataReset();
        }

        private void btnAddQualification_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddQCode.Text != "" && txtAddQName.Text != "" && txtAddDuration.Text != "")
                {
                    Qualification newq = new Qualification();
                    newq.QCode = txtAddQCode.Text;
                    newq.QName = txtAddQName.Text;
                    newq.Duration = txtAddDuration.Text;

                    Qualification_Course newcq = new Qualification_Course();
                    newcq.QCode = txtAddQCode.Text;
                    newcq.CID = Convert.ToInt32(cboAddCourse.SelectedValue);

                    DB.Qualifications.InsertOnSubmit(newq);
                    DB.Qualification_Courses.InsertOnSubmit(newcq);
                    DB.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Please fill all fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            refreshdata();
            courseDataReset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var del = (from q in DB.Qualifications
                           where q.QCode == cboQualifications.SelectedValue.ToString()
                           select q).First();

                var del2 = (from qc in DB.Qualification_Courses
                            where qc.QCode == cboQualifications.SelectedValue.ToString()
                            select qc).First();

                DB.Qualification_Courses.DeleteOnSubmit(del2);
                DB.Qualifications.DeleteOnSubmit(del);
                DB.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Please make sure there are valid Qualifications to delete!", "Error!");
            }

            refreshdata();
        }
    }
}