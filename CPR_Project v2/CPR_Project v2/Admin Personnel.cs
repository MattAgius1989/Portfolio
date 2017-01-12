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
    public partial class Admin_Personnel : Form
    {
        public Admin_Personnel()
        {
            InitializeComponent();
        }

        NewDataClassesDataContext DB = new NewDataClassesDataContext();
        


        private void resetFields()
        {
            txtAdd1.Clear();
            txtAdd2.Clear();
            dtpDOB.ResetText();
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtPostcode.Clear();
            txtState.Clear();
            txtSuburb.Clear();
            cboCourse.Text = "";
            cboAdminRole.Text = "";

            var IDNames = (from t in DB.Persons
                           where t.Type == cboSelector.Text
                           select t);

            cboID.DisplayMember = "ID";
            cboID.ValueMember = "ID";
            cboID.DataSource = IDNames;
            
        }

        private void Admin_Personnel_Load(object sender, EventArgs e)
        {

            var qual = (from q in DB.Qualifications select q);

            cboQualification.DisplayMember = "QName";
            cboQualification.ValueMember = "QCode";
            cboQualification.DataSource = qual;

            var IDNames = (from t in DB.Persons
                           where t.Type == cboSelector.Text
                           select t);

            cboID.DisplayMember = "ID";
            cboID.ValueMember = "ID";
            cboID.DataSource = IDNames;

            var adminroles = (from a in DB.Administrations select a.Role);

            cboAdminRole.DisplayMember = "Role";
            cboAdminRole.ValueMember = "Role";
            cboAdminRole.DataSource = adminroles;

            cboSelector.SelectedIndex = 0;
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();

            var search = (from d in DB.Persons
                          where d.ID == Convert.ToInt32(cboID.SelectedValue)
                          select new { d.FName, d.LName, d.DOB, d.Phone, d.Add1, d.Add2, d.Suburb, d.State, d.Postcode }).ToList();

            var course = (from s in DB.Student_Courses
                          where s.SID == Convert.ToInt32(cboID.SelectedValue)
                          join c in DB.Courses on s.CID equals c.CID
                          select c).ToList();

            if (cboSelector.SelectedIndex == 2)
            {
                var role = (from a in DB.Administrations
                            where a.AID == Convert.ToInt32(cboID.SelectedValue)
                            select a.Role).First();

                foreach (var name in search)
                {
                    txtFName.Text = name.FName;
                    txtLName.Text = name.LName;
                    dtpDOB.Text = name.DOB.ToShortDateString();
                    txtPhone.Text = name.Phone;
                    txtAdd1.Text = name.Add1;
                    txtAdd2.Text = name.Add2;
                    txtSuburb.Text = name.Suburb;
                    txtState.Text = name.State;
                    txtPostcode.Text = name.Postcode;

                    cboAdminRole.SelectedText = role.ToString();
                }
            }
            else
            {
                foreach (var name in search)
                {
                    txtFName.Text = name.FName;
                    txtLName.Text = name.LName;
                    dtpDOB.Text = name.DOB.ToShortDateString();
                    txtPhone.Text = name.Phone;
                    txtAdd1.Text = name.Add1;
                    txtAdd2.Text = name.Add2;
                    txtSuburb.Text = name.Suburb;
                    txtState.Text = name.State;
                    txtPostcode.Text = name.Postcode;

                }
            }

            cboCourse.DataSource = course;
            cboCourse.ValueMember = "CID";
            cboCourse.DisplayMember = "CName";
        }

        private void cboSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var IDNames = (from t in DB.Persons
                           where t.Type == cboSelector.Text
                           select t);

            cboID.DataSource = IDNames;
            cboID.DisplayMember = "ID";
            cboID.ValueMember = "ID";

            if (cboSelector.SelectedIndex == 0)
            {
                label11.Visible = true;
                cboQualification.Visible = true;
                label13.Visible = true;
                cboCourse.Visible = true;
                label14.Visible = false;
                txtPassword.Visible = false;
                label15.Visible = false;
                cboAdminRole.Visible = false;
            }
            else if (cboSelector.SelectedIndex == 1)
            {
                label14.Visible = true;
                txtPassword.Visible = true;
                label11.Visible = false;
                cboQualification.Visible = false;
                label13.Visible = false;
                cboCourse.Visible = false;
                label15.Visible = false;
                cboAdminRole.Visible = false;
            }
            else if (cboSelector.SelectedIndex == 2)
            {
                label15.Visible = true;
                cboAdminRole.Visible = true;
                label11.Visible = false;
                cboQualification.Visible = false;
                label13.Visible = false;
                cboCourse.Visible = false;
                label14.Visible = true;
                txtPassword.Visible = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Close();
           admin.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var saveEdit = (from ed in DB.Persons
                                where ed.ID == Convert.ToInt32(cboID.SelectedValue)
                                select ed).First();


                if (txtFName.Text != "" && txtLName.Text != "" && txtPhone.Text != "" && txtAdd1.Text != "" && txtAdd2.Text != "" && txtSuburb.Text != "" && txtState.Text != "" && txtPostcode.Text != "")
                {
                    if (cboSelector.SelectedIndex == 0)
                    {
                        int phone;
                        if (int.TryParse(txtPhone.Text, out phone) && txtPhone.Text.Length == 10)
                        {
                            int postcode;
                            if (int.TryParse(txtPostcode.Text, out postcode) && txtPostcode.Text.Length == 4)
                            {
                                var saveStudentEdit = (from se in DB.Students
                                                       where se.SID == Convert.ToInt32(cboID.SelectedValue)
                                                       select se).First();

                                var saveStudentCourseEdit = (from sc in DB.Student_Courses
                                                             where sc.SID == Convert.ToInt32(cboID.SelectedValue)
                                                             select sc).First();


                                saveEdit.FName = txtFName.Text.ToString();
                                saveEdit.LName = txtLName.Text.ToString();
                                saveEdit.DOB = dtpDOB.Value;
                                saveEdit.Add1 = txtAdd1.Text.ToString();
                                saveEdit.Add2 = txtAdd2.Text.ToString();
                                saveEdit.Suburb = txtSuburb.Text.ToString();
                                saveEdit.State = txtState.Text.ToString();
                                saveEdit.Postcode = txtPostcode.Text.ToString();
                                saveEdit.Phone = txtPhone.Text.ToString();

                                saveStudentEdit.SID = Convert.ToInt32(cboID.SelectedValue);
                                saveStudentEdit.QCode = cboQualification.SelectedValue.ToString();

                                saveStudentCourseEdit.SID = Convert.ToInt32(cboID.SelectedValue);
                                saveStudentCourseEdit.CID = Convert.ToInt32(cboCourse.SelectedValue);

                                DB.SubmitChanges();
                                resetFields();
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Postcode!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Phone Number!");
                        }

                    }
                    else if (cboSelector.SelectedIndex == 1)
                    {
                        int phone;
                        if (int.TryParse(txtPhone.Text, out phone) && txtPhone.Text.Length == 10)
                        {
                            int postcode;
                            if (int.TryParse(txtPostcode.Text, out postcode) && txtPostcode.Text.Length == 4)
                            {
                                var saveTeacherEdit = (from t in DB.Teachers
                                                       where t.TID == Convert.ToInt32(cboID.SelectedValue)
                                                       select t).First();


                                saveEdit.FName = txtFName.Text.ToString();
                                saveEdit.LName = txtLName.Text.ToString();
                                saveEdit.DOB = dtpDOB.Value;
                                saveEdit.Add1 = txtAdd1.Text.ToString();
                                saveEdit.Add2 = txtAdd2.Text.ToString();
                                saveEdit.Suburb = txtSuburb.Text.ToString();
                                saveEdit.State = txtState.Text.ToString();
                                saveEdit.Postcode = txtPostcode.Text.ToString();
                                saveEdit.Phone = txtPhone.Text.ToString();

                                saveTeacherEdit.TID = Convert.ToInt32(cboID.SelectedValue);
                                saveTeacherEdit.RegNo = "TCH" + cboID.SelectedValue.ToString();

                                if (txtPassword.Text != "")
                                {
                                    if (txtPassword.Text.Length == 7)
                                    {
                                        saveTeacherEdit.Password = txtPassword.Text.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password must be 7 characters! Password not saved!");
                                    }
                                }
                                else if (txtPassword.Text == "")
                                { }
                                else
                                {
                                    MessageBox.Show("Invalid password! Password not saved!");
                                }
                                DB.SubmitChanges();
                                resetFields();
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Postcode!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Phone Number!");
                        }
                    }

                    else if (cboSelector.SelectedIndex == 2)
                    {
                        int phone;
                        if (int.TryParse(txtPhone.Text, out phone) && txtPhone.Text.Length == 10)
                        {
                            int postcode;
                            if (int.TryParse(txtPostcode.Text, out postcode) && txtPostcode.Text.Length == 4)
                            {
                                var saveAdminEdit = (from a in DB.Administrations
                                                     where a.AID == Convert.ToInt32(cboID.SelectedValue)
                                                     select a).First();

                                saveEdit.FName = txtFName.Text.ToString();
                                saveEdit.LName = txtLName.Text.ToString();
                                saveEdit.DOB = dtpDOB.Value;
                                saveEdit.Add1 = txtAdd1.Text.ToString();
                                saveEdit.Add2 = txtAdd2.Text.ToString();
                                saveEdit.Suburb = txtSuburb.Text.ToString();
                                saveEdit.State = txtState.Text.ToString();
                                saveEdit.Phone = txtPhone.Text.ToString();

                                saveAdminEdit.AID = Convert.ToInt32(cboID.SelectedValue);
                                saveAdminEdit.Role = cboAdminRole.Text.ToString();


                                if (txtPassword.Text != "")
                                {
                                    if (txtPassword.Text.Length == 7)
                                    {
                                        saveAdminEdit.Password = txtPassword.Text.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Password must be 7 characters! Password not saved!");
                                    }
                                }
                                else if (txtPassword.Text == "")
                                { }
                                else
                                {
                                    MessageBox.Show("Invalid password! Password not saved!");
                                }

                                DB.SubmitChanges();
                                resetFields();
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Postcode!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Phone Number!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All Fields");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Person person = new Person();

                var SaveID = (from ed in DB.Persons orderby ed.ID descending select ed.ID).First();
                Convert.ToInt32(SaveID);


                if (txtFName.Text != "" && txtLName.Text != "" && txtPhone.Text != "" && txtAdd1.Text != "" && txtAdd2.Text != "" && txtSuburb.Text != "" && txtState.Text != "" && txtPostcode.Text != "" && cboSelector.Text != "")
                {
                    if (cboSelector.SelectedIndex == 0)
                    {
                        int phone;
                        if (int.TryParse(txtPhone.Text, out phone) && txtPhone.Text.Length == 10)
                        {
                            int postcode;
                            if (int.TryParse(txtPostcode.Text, out postcode) && txtPostcode.Text.Length == 4)
                            {
                                Student student = new Student();
                                Student_Course stuco = new Student_Course();

                                int ID = SaveID + 1;

                                person.Type = cboSelector.Text.ToString();
                                person.ID = ID;
                                person.FName = txtFName.Text.ToString();
                                person.LName = txtLName.Text.ToString();
                                person.DOB = dtpDOB.Value;
                                person.Add1 = txtAdd1.Text.ToString();
                                person.Add2 = txtAdd2.Text.ToString();
                                person.Suburb = txtSuburb.Text.ToString();
                                person.State = txtState.Text.ToString();
                                person.Postcode = txtPostcode.Text.ToString();
                                person.Phone = txtPhone.Text.ToString();
                                student.SID = ID;
                                student.QCode = cboQualification.SelectedValue.ToString();
                                student.Sdate = DateTime.Now;

                                stuco.SID = ID;
                                stuco.CID = Convert.ToInt32(cboCourse.SelectedValue);

                                DB.Persons.InsertOnSubmit(person);
                                DB.Students.InsertOnSubmit(student);
                                DB.Student_Courses.InsertOnSubmit(stuco);
                                DB.SubmitChanges();
                                resetFields();
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Postcode!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Phone Number!");
                        }
                    }
                    else if (cboSelector.SelectedIndex == 1)
                    {
                        int phone;
                        if (int.TryParse(txtPhone.Text, out phone) && txtPhone.Text.Length == 10)
                        {
                            int postcode;
                            if (int.TryParse(txtPostcode.Text, out postcode) && txtPostcode.Text.Length == 4)
                            {
                                if (txtPassword.Text != "" && txtPassword.Text.Length == 7)
                                {
                                    Teacher teach = new Teacher();

                                    int ID = SaveID + 1;

                                    person.Type = cboSelector.Text.ToString();
                                    person.FName = txtFName.Text.ToString();
                                    person.LName = txtLName.Text.ToString();
                                    person.DOB = dtpDOB.Value;
                                    person.Add1 = txtAdd1.Text.ToString();
                                    person.Add2 = txtAdd2.Text.ToString();
                                    person.Suburb = txtSuburb.Text.ToString();
                                    person.State = txtState.Text.ToString();
                                    person.Phone = txtPhone.Text.ToString();
                                    person.Postcode = txtPostcode.Text.ToString();
                                    teach.TID = ID;
                                    teach.RegNo = "TCH" + ID.ToString();
                                    teach.Password = txtPassword.Text.ToString();

                                    DB.Persons.InsertOnSubmit(person);
                                    DB.Teachers.InsertOnSubmit(teach);
                                    DB.SubmitChanges();
                                    resetFields();
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a password! Must be 7 characters!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Postcode!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Phone Number!");
                        }
                    }

                    else if (cboSelector.SelectedIndex == 2)
                    {
                        int phone;
                        if (int.TryParse(txtPhone.Text, out phone) && txtPhone.Text.Length == 10)
                        {
                            int postcode;
                            if (int.TryParse(txtPostcode.Text, out postcode) && txtPostcode.Text.Length == 4)
                            {
                                if (txtPassword.Text != "" && txtPassword.Text.Length == 7)
                                {
                                    if (cboAdminRole.SelectedIndex != -1)
                                    {
                                        Administration admin = new Administration();

                                        int ID = SaveID + 1;

                                        person.Type = cboSelector.Text.ToString();
                                        person.FName = txtFName.Text.ToString();
                                        person.LName = txtLName.Text.ToString();
                                        person.DOB = dtpDOB.Value;
                                        person.Add1 = txtAdd1.Text.ToString();
                                        person.Add2 = txtAdd2.Text.ToString();
                                        person.Suburb = txtSuburb.Text.ToString();
                                        person.State = txtState.Text.ToString();
                                        person.Phone = txtPhone.Text.ToString();
                                        person.Postcode = txtPostcode.Text.ToString();

                                        admin.AID = ID;
                                        admin.Role = cboAdminRole.SelectedValue.ToString();
                                        admin.Password = txtPassword.Text.ToString();

                                        DB.Persons.InsertOnSubmit(person);
                                        DB.Administrations.InsertOnSubmit(admin);
                                        DB.SubmitChanges();
                                        resetFields();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select Admin role!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password! Please enter password! Must be 7 characters!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Postcode!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Phone Number!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All Fields", "Error!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboSelector.SelectedIndex == 0)
            {
                var Del = (from d in DB.Persons
                           where d.ID == Convert.ToInt32(cboID.SelectedValue)
                           select d).First();

                var SDel = (from sd in DB.Students
                            where sd.SID == Convert.ToInt32(cboID.SelectedValue)
                            select sd).First();

                DB.Students.DeleteOnSubmit(SDel);
                DB.Persons.DeleteOnSubmit(Del);
                DB.SubmitChanges();
                resetFields();
            }
            else if (cboSelector.SelectedIndex == 1)
            {
                var Del = (from d in DB.Persons
                           where d.ID == Convert.ToInt32(cboID.SelectedValue)
                           select d).First();

                var TDel = (from td in DB.Teachers
                            where td.TID == Convert.ToInt32(cboID.SelectedValue)
                            select td).First();

                DB.Teachers.DeleteOnSubmit(TDel);
                DB.Persons.DeleteOnSubmit(Del);
                DB.SubmitChanges();
                resetFields();
            }
            else if (cboSelector.SelectedIndex == 2)
            {
                var Del = (from d in DB.Persons
                           where d.ID == Convert.ToInt32(cboID.SelectedValue)
                           select d).First();

                var ADel = (from ad in DB.Administrations
                            where ad.AID == Convert.ToInt32(cboID.SelectedValue)
                            select ad).First();

                DB.Administrations.DeleteOnSubmit(ADel);
                DB.Persons.DeleteOnSubmit(Del);
                DB.SubmitChanges();
                resetFields();
            }
        }
    }
}
