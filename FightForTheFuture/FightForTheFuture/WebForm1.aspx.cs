using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FightForTheFuture
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        class registration
        {
            private string username;
            private string password;
            private string email;
            private bool adminemail;

            public string user { get { return username; } set { username = value; } }
            public string pass { get { return password; } set { password = value; } }
            public string mail { get { return email; } set { email = value; } }
            public bool admin { get { return adminemail; } set { adminemail = value; } }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            Label1.Visible = false;
            Label2.Visible = false;

            if (ddlHuman.SelectedValue == "True")
            {
                reg.user = txtUsername.Text;
                if (txtConfirm.CausesValidation == true)
                {
                    reg.pass = txtPassword.Text;
                }
                reg. mail = txtEmail.Text;
                if (chbEmailAdmin.Checked == true)
                {
                   reg.admin = true;
                }

                Label2.Visible = true;
                txtUsername.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                Label1.Visible = true;
            }
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtConfirm.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            chbEmailAdmin.Checked = false;
            ddlHuman.SelectedIndex = -1;

        }
    }
}