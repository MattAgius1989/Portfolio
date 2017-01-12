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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboFunction.SelectedIndex == 0)
            {
                Admin_Qualification admq = new Admin_Qualification();
                admq.Show();
                this.Close();
            }
            else if (cboFunction.SelectedIndex == 1)
            {
                Admin_Courses admc = new Admin_Courses();
                admc.Show();
                this.Close();
            }
            else if (cboFunction.SelectedIndex == 2)
            {
                Admin_Personnel admp = new Admin_Personnel();
                admp.Show();
                this.Close();
            }
        }
    }
}
