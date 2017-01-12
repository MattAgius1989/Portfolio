using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CPR_Project_v2
{

    public partial class Login : Form
    {
        
        NewDataClassesDataContext DB = new NewDataClassesDataContext();

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Boolean TeachLog(string user, string pass)
        {
            var teach = (from t in DB.Teachers
                         where t.TID == Convert.ToInt32(user) && t.Password == pass
                         select t);

            if (txtUser.Text != "" && txtPass.Text != "")
            {
                if (teach.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private Boolean AdminLog(string user, string pass)
        {
            var admin = (from a in DB.Administrations
                         where a.AID == Convert.ToInt32(user) && a.Password == pass
                         select a);

            if (txtUser.Text != "" && txtPass.Text != "")
            {
                if (admin.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnLoginTeach_Click(object sender, EventArgs e)
        {
            if (TeachLog(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                frmTeacher teach = new frmTeacher();
                teach.ShowDialog();
            }

            else
            {
                MessageBox.Show("Login failed!");
                txtPass.Clear();
                txtUser.Clear();
            }
            
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (AdminLog(user, pass))
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                frmAdmin admin = new frmAdmin();
                admin.ShowDialog();
            }

            else
            {
                MessageBox.Show("Login failed!");
                txtPass.Clear();
                txtUser.Clear();
            }
        }
    }
}
