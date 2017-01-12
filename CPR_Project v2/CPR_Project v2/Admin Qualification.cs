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
    public partial class Admin_Qualification : Form
    {
        NewDataClassesDataContext DB = new NewDataClassesDataContext();

        public Admin_Qualification()
        {
            InitializeComponent();
        }

        private void Admin_Qualification_Load(object sender, EventArgs e)
        {
            var qual = (from q in DB.Qualifications select q);

            cboQualifications.DataSource = qual;
            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";

        }

        private void refreshdata()
        {
            dgvEditCourses.Refresh();
            dgvViewCourses.Refresh();
            dgvEditQualification.Refresh();
            dgvViewQualification.Refresh();
            cboAddCourseList.Refresh();
            cboRemCourseList.Refresh();
            txtQDuration.Text = "";
            txtQName.Text = "";

            var qual = (from q in DB.Qualifications select q);

            cboQualifications.DataSource = qual;
            cboQualifications.DisplayMember = "QName";
            cboQualifications.ValueMember = "QCode";
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
                                 where c.QCode != cboQualifications.SelectedValue.ToString()
                                 join q in DB.Courses on c.CID equals q.CID
                                 select new { q.CName, q.CID}).Distinct().Except(removecourselist);

            var courselist = (from c in DB.Courses select c);

            cboAddCourseList.DataSource = addcourselist;
            cboAddCourseList.DisplayMember = "CName";
            cboAddCourseList.ValueMember = "CID";

            cboRemCourseList.DataSource = removecourselist;
            cboRemCourseList.DisplayMember = "CName";
            cboRemCourseList.ValueMember = "CID";

            cboAddCourse.DataSource = courselist;
            cboAddCourse.DisplayMember = "CName";
            cboAddCourse.ValueMember = "CID";

            dgvViewCourses.DataSource = chooseCourse;
            dgvEditCourses.DataSource = editCourse;
            dgvViewQualification.DataSource = courseQualification;
            dgvEditQualification.DataSource = courseQualification;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Close();
            admin.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveEdits = (from q in DB.Qualifications
                             where q.QCode == cboQualifications.SelectedValue.ToString()
                             select q).First();

            try
            {
                saveEdits.QCode = cboQualifications.SelectedValue.ToString();

                if (txtQName.Text != "" && txtQDuration.Text != "")
                {
                    saveEdits.QName = txtQName.Text;
                    saveEdits.Duration = txtQDuration.Text;

                    DB.SubmitChanges();
                }
                else if (txtQName.Text == "" && txtQDuration.Text != "")
                {
                    saveEdits.Duration = txtQDuration.Text;

                    DB.SubmitChanges();
                }
                else if (txtQName.Text != "" && txtQDuration.Text == "")
                {
                    saveEdits.QName = txtQName.Text;

                    DB.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Please fill fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            refreshdata();
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var add = (from c in DB.Qualification_Courses
                       where c.QCode == cboQualifications.SelectedValue.ToString()
                       select c).First();
            try
            {
                Qualification_Course qcourse = new Qualification_Course();
                qcourse.QCode = cboQualifications.SelectedValue.ToString();
                qcourse.CID = Convert.ToInt32(cboAddCourseList.SelectedValue);

                DB.Qualification_Courses.InsertOnSubmit(qcourse);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            refreshdata();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            var remove = (from c in DB.Qualification_Courses
                          where c.CID == Convert.ToInt32(cboRemCourseList.SelectedValue)
                          select c);
            try
            {
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
        }

        private void btnSaveQual_Click(object sender, EventArgs e)
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

            refreshdata();
        }
    }
}
