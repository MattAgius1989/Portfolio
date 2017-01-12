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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
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
                Teacher_Marks tchm = new Teacher_Marks();
                tchm.Show();
                this.Close();
            }
            else if (cboFunction.SelectedIndex == 1)
            {
                Teacher_Qualification tchq = new Teacher_Qualification();
                tchq.Show();
                this.Close();
            }
            else if (cboFunction.SelectedIndex == 2)
            {
                Teacher_Courses tchc = new Teacher_Courses();
                tchc.Show();
                this.Close();
            }
        }
    }
}
