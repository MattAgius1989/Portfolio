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
    public partial class Teacher_Marks : Form
    {
        NewDataClassesDataContext DB = new NewDataClassesDataContext();

        public Teacher_Marks()
        {
            InitializeComponent();
        }

        private void Teacher_Marks_Load(object sender, EventArgs e)
        {
            var studentlist = (from s in DB.Persons
                               where s.Type == "Student"
                               select new { FullName = s.FName + ' ' + s.LName, s.ID, });

            var studentlist2 = (from s in DB.Persons
                               where s.Type == "Student"
                               select new { FullName = s.FName + ' ' + s.LName, s.ID, });

            var studentexceptlist = (from sel in DB.Persons
                                     join sc in DB.Student_Courses on sel.ID equals sc.SID
                                     where sel.Type == "Student" && sc.CID == Convert.ToInt32(cboSNMCourse.SelectedValue)
                                     select new { FullName = sel.FName + ' ' + sel.LName, sel.ID });

            var studentlist3 = (from c in DB.Persons
                                where c.Type == "Student"
                                select new { FullName = c.FName + ' ' + c.LName, c.ID }).Except(studentexceptlist);

            var courselist = (from c in DB.Courses select c);

            var courseexceptlist = (from el in DB.Student_Courses
                              where el.SID == Convert.ToInt32(cboCNMStudent.SelectedValue)
                              join c in DB.Courses on el.CID equals c.CID
                              select c);

            var courselist2 = (from sc in DB.Student_Courses
                               where sc.SID != Convert.ToInt32(cboCNMStudent.SelectedValue)
                               join c in DB.Courses on sc.CID equals c.CID
                               select c).Except(courseexceptlist);

            var courselist3 = (from c in DB.Courses select c);

            var studentMarks = (from s in DB.Persons
                                where s.ID == Convert.ToInt32(cboStudents.SelectedValue)
                                join sc in DB.Student_Courses on s.ID equals sc.SID
                                join c in DB.Courses on sc.CID equals c.CID
                                select new { Name = s.FName + ' ' + s.LName, Course = c.CName, sc.Mark });

            

            cboCourses.DisplayMember = "CName";
            cboCourses.ValueMember = "CID";
            cboCourses.DataSource = courselist;

            cboStudents.DisplayMember = "FullName";
            cboStudents.ValueMember = "ID";
            cboStudents.DataSource = studentlist;

            cboCNMStudent.DisplayMember = "FullName";
            cboCNMStudent.ValueMember = "ID";
            cboCNMStudent.DataSource = studentlist2;

            cboSNMStudent.DisplayMember = "FullName";
            cboSNMStudent.ValueMember = "ID";
            cboSNMStudent.DataSource = studentlist3;

            cboCNMCourse.DisplayMember = "CName";
            cboCNMCourse.ValueMember = "CID";
            cboCNMCourse.DataSource = courselist2;

            cboSNMCourse.DisplayMember = "CName";
            cboSNMCourse.ValueMember = "CID";
            cboSNMCourse.DataSource = courselist3;
            
        }

        private void dataRefresh()
        {
            cboCourses.Refresh();
            cboSelectedCourses.Refresh();
            cboStudents.Refresh();
            cboSelectedStudents.Refresh();
            dgvCourse.Refresh();
            dgvMarks.Refresh();
            cboCNMStudent.Refresh();
            cboCNMCourse.Refresh();
        }

        private void dataReset()
        {
            var studentlist2 = (from s in DB.Persons
                                where s.Type == "Student"
                                select new { FullName = s.FName + ' ' + s.LName, s.ID, });

            var studentMarks = (from s in DB.Persons
                                where s.ID == Convert.ToInt32(cboStudents.SelectedValue)
                                join sc in DB.Student_Courses on s.ID equals sc.SID
                                join c in DB.Courses on sc.CID equals c.CID
                                select new { Name = s.FName + ' ' + s.LName, Course = c.CName, sc.Mark });

            var studentCourses = (from sc in DB.Student_Courses
                                  where sc.SID == Convert.ToInt32(cboStudents.SelectedValue)
                                  join c in DB.Courses on sc.CID equals c.CID
                                  select new { c.CID, c.CName });

            var courseMarks = (from sc in DB.Student_Courses
                               where sc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                               join c in DB.Courses on sc.CID equals c.CID
                               join p in DB.Persons on sc.SID equals p.ID
                               select new { Course = c.CName, Name = p.FName + ' ' + p.LName, sc.Mark });

            var courseStudents = (from sc in DB.Student_Courses
                                  where sc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                  join p in DB.Persons on sc.SID equals p.ID
                                  select new { FullName = p.FName + ' ' + p.LName, p.ID });

            var exceptlist = (from el in DB.Student_Courses
                              where el.SID == Convert.ToInt32(cboCNMStudent.SelectedValue)
                              join c in DB.Courses on el.CID equals c.CID
                              select c);

            var courselist = (from sc in DB.Student_Courses
                               where sc.SID != Convert.ToInt32(cboCNMStudent.SelectedValue)
                               join c in DB.Courses on sc.CID equals c.CID
                               select c).Except(exceptlist);

            //var selectedCourseMarks = (from sc in DB.Student_Courses
            //                           where sc.CID == Convert.ToInt32(cboSelectedCourses.SelectedValue)
            //                           select sc.Mark).First();

            //var selectedStudentMarks = (from sc in DB.Student_Courses
            //                            where sc.SID == Convert.ToInt32(cboSelectedStudents.SelectedValue)
            //                            select sc.Mark).First();

            //txtStudentMark.Text = Convert.ToInt32(selectedStudentMarks).ToString();

            //txtCourseMark.Text = Convert.ToInt32(selectedCourseMarks).ToString();

            var studentexceptlist = (from sel in DB.Persons
                                     join sc in DB.Student_Courses on sel.ID equals sc.SID
                                     where sel.Type == "Student" && sc.CID == Convert.ToInt32(cboSNMCourse.SelectedValue)
                                     select new { FullName = sel.FName + ' ' + sel.LName, sel.ID });

            var studentlist3 = (from c in DB.Persons
                                where c.Type == "Student"
                                select new { FullName = c.FName + ' ' + c.LName, c.ID }).Except(studentexceptlist);

            cboSNMStudent.DisplayMember = "FullName";
            cboSNMStudent.ValueMember = "ID";
            cboSNMStudent.DataSource = studentlist3;

            cboCNMStudent.DisplayMember = "FullName";
            cboCNMStudent.ValueMember = "ID";
            cboCNMStudent.DataSource = studentlist2;

            cboCNMCourse.DisplayMember = "CName";
            cboCNMCourse.ValueMember = "CID";
            cboCNMCourse.DataSource = courselist;

            cboSelectedCourses.DisplayMember = "CName";
            cboSelectedCourses.ValueMember = "CID";
            cboSelectedCourses.DataSource = studentCourses;

            cboSelectedStudents.DisplayMember = "FullName";
            cboSelectedStudents.ValueMember = "ID";
            cboSelectedStudents.DataSource = courseStudents;

            dgvCourse.DataSource = courseMarks;
            dgvMarks.DataSource = studentMarks;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmTeacher teach = new frmTeacher();
            this.Close();
            teach.ShowDialog();
        }

        private void cboSelectedCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataRefresh();

            var selectedCourseMarks = (from sc in DB.Student_Courses
                                      where sc.SID == Convert.ToInt32(cboStudents.SelectedValue) && sc.CID == Convert.ToInt32(cboSelectedCourses.SelectedValue)
                                      select sc.Mark).First();

            txtCourseMark.Text = Convert.ToInt32(selectedCourseMarks).ToString();
        }

        private void cboSelectedStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataRefresh();

            var selectedStudentMarks = (from sc in DB.Student_Courses
                                       where sc.SID == Convert.ToInt32(cboSelectedStudents.SelectedValue) && sc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                       select sc.Mark).First();

            txtStudentMark.Text = Convert.ToInt32(selectedStudentMarks).ToString();
        }

        private void btnDeleteFromCourse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCNewMarks_Click(object sender, EventArgs e)
        {
            Student_Course newmark = new Student_Course();

            try
            {
                if (Convert.ToInt32(txtCNMarks.Text) >= 1 && Convert.ToInt32(txtCNMarks.Text) <= 100)
                {
                    try
                    {
                        newmark.CID = Convert.ToInt32(cboCNMCourse.SelectedValue);
                        newmark.SID = Convert.ToInt32(cboCNMStudent.SelectedValue);
                        newmark.Mark = Convert.ToInt32(txtCNMarks.Text);

                        DB.Student_Courses.InsertOnSubmit(newmark);
                        DB.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter number between '1' and '100'");
                }
            }
            catch
            {
                MessageBox.Show("Please enter number between '1' and '100'");
            }
            dataRefresh();
            dataReset();
            
        }

        private void btnSNewMarks_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtSNMarks.Text) >= 1 && Convert.ToInt32(txtSNMarks.Text) <= 100)
                {
                    Student_Course newmark = new Student_Course();

                    newmark.CID = Convert.ToInt32(cboSNMCourse.SelectedValue);
                    newmark.SID = Convert.ToInt32(cboSNMStudent.SelectedValue);
                    newmark.Mark = Convert.ToInt32(txtSNMarks.Text);

                    try
                    {
                        DB.Student_Courses.InsertOnSubmit(newmark);
                        DB.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter number between '1' and '100'");
                }
            }
            catch
            {
                MessageBox.Show("Please enter marks before saving!");
            }

            dataRefresh();
            dataReset();

        }

        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var courseMarks = (from sc in DB.Student_Courses
                               where sc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                               join c in DB.Courses on sc.CID equals c.CID
                               join p in DB.Persons on sc.SID equals p.ID
                               select new { Course = c.CName, Name = p.FName + ' ' + p.LName, sc.Mark });

            var courseStudents = (from sc in DB.Student_Courses
                                  where sc.CID == Convert.ToInt32(cboCourses.SelectedValue)
                                  join p in DB.Persons on sc.SID equals p.ID
                                  select new { FullName = p.FName + ' ' + p.LName, p.ID });

            cboSelectedStudents.DisplayMember = "FullName";
            cboSelectedStudents.ValueMember = "ID";
            cboSelectedStudents.DataSource = courseStudents;

            dgvCourse.DataSource = courseMarks;
        }

        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentMarks = (from s in DB.Persons
                                where s.ID == Convert.ToInt32(cboStudents.SelectedValue)
                                join sc in DB.Student_Courses on s.ID equals sc.SID
                                join c in DB.Courses on sc.CID equals c.CID
                                select new { Name = s.FName + ' ' + s.LName, Course = c.CName, sc.Mark });

            var studentCourses = (from sc in DB.Student_Courses
                                  where sc.SID == Convert.ToInt32(cboStudents.SelectedValue)
                                  join c in DB.Courses on sc.CID equals c.CID
                                  select new { c.CID, c.CName });

            cboSelectedCourses.DisplayMember = "CName";
            cboSelectedCourses.ValueMember = "CID";
            cboSelectedCourses.DataSource = studentCourses;

            dgvMarks.DataSource = studentMarks;
        }

        private void btnSaveStudentEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var saveMarks = (from sc in DB.Student_Courses
                                 where sc.CID == Convert.ToInt32(cboCourses.SelectedValue) && sc.SID == Convert.ToInt32(cboSelectedStudents.SelectedValue)
                                 select sc).First();
                try
                {
                    if (Convert.ToInt32(txtStudentMark.Text) >= 1 && Convert.ToInt32(txtStudentMark.Text) <= 100)
                    {
                        try
                        {
                            saveMarks.Mark = Convert.ToInt32(txtStudentMark.Text);
                            DB.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter number between '1' and '100'");
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter number between '1' and '100'");
                }
            }
            catch
            {
                MessageBox.Show("Please ensure that there is a selected student to save marks!");
            }
            dataRefresh();
            dataReset();
        }

        private void cboCNMStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exceptlist = (from el in DB.Student_Courses
                              where el.SID == Convert.ToInt32(cboCNMStudent.SelectedValue)
                              join c in DB.Courses on el.CID equals c.CID
                              select c);

            var courselist2 = (from sc in DB.Student_Courses
                               where sc.SID != Convert.ToInt32(cboCNMStudent.SelectedValue)
                               join c in DB.Courses on sc.CID equals c.CID
                               select c).Except(exceptlist);

            cboCNMCourse.DisplayMember = "CName";
            cboCNMCourse.ValueMember = "CID";
            cboCNMCourse.DataSource = courselist2;

            dataRefresh();
        }

        private void btnDeleteFromCourse_Click_1(object sender, EventArgs e)
        {
            try
            {
                var deleteCourseMarks = (from sc in DB.Student_Courses
                                         where sc.CID == Convert.ToInt32(cboCourses.SelectedValue) && sc.SID == Convert.ToInt32(cboSelectedStudents.SelectedValue)
                                         select sc).First();
                try
                {
                    DB.Student_Courses.DeleteOnSubmit(deleteCourseMarks);
                    DB.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please ensure that a student is selected to delete");
            }
            dataRefresh();
            dataReset();
        }

        private void btnSaveCourseEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var saveMarks = (from sc in DB.Student_Courses
                                 where sc.SID == Convert.ToInt32(cboStudents.SelectedValue) && sc.CID == Convert.ToInt32(cboSelectedCourses.SelectedValue)
                                 select sc).First();

                saveMarks.Mark = Convert.ToInt32(txtCourseMark.Text);
                if (Convert.ToInt32(txtCourseMark.Text) >= 1 && Convert.ToInt32(txtCourseMark.Text) <= 100)
                {
                    try
                    {
                        DB.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter number between '1' and '100'");
                }
            }
            catch
            {
                MessageBox.Show("Please ensure there is a valid student to save marks!");
            }
            dataRefresh();
            dataReset();
        }

        private void btnDeleteFromStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteMarks = (from sc in DB.Student_Courses
                                   where sc.SID == Convert.ToInt32(cboStudents.SelectedValue) && sc.CID == Convert.ToInt32(cboSelectedCourses.SelectedValue)
                                   select sc).First();

                try
                {
                    DB.Student_Courses.DeleteOnSubmit(deleteMarks);
                    DB.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please ensure there is a valid student to delete!");
            }

            dataRefresh();
            dataReset();
        }

        private void cboSNMCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentexceptlist = (from sel in DB.Persons
                                     join sc in DB.Student_Courses on sel.ID equals sc.SID
                                     where sel.Type == "Student" && sc.CID == Convert.ToInt32(cboSNMCourse.SelectedValue)
                                     select new { FullName = sel.FName + ' ' + sel.LName, sel.ID });

            var studentlist3 = (from c in DB.Persons
                                where c.Type == "Student"
                                select new { FullName = c.FName + ' ' + c.LName, c.ID }).Except(studentexceptlist);

            cboSNMStudent.DisplayMember = "FullName";
            cboSNMStudent.ValueMember = "ID";
            cboSNMStudent.DataSource = studentlist3;

            dataRefresh();
        }
    }
}
