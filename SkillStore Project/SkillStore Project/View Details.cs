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
using System.Configuration;

namespace SkillStore_Project
{
    public partial class frmViewDetails : Form
    {

        public frmViewDetails()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel);
            if (DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Goodbye!", "Aborting!");
                Application.Exit();
            }
            else
            {
                string connString = "Data Source=150.207.153.193,14433;Persist Security Info=True;User ID=home30015379;Password=9r2vUkQXyz";
                string query = "SELECT * FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connString);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                adapter.Fill(table);
                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adapter.Update(table);
            }
        }
    }
}
