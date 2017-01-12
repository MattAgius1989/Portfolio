using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numberArray = new int[5];

        private int totalArray()
        {
            int total = 0;

            foreach (int number in numberArray)
            {
                total += number;
            }

            return total;
        }


    

        private void btnSort_Click(object sender, EventArgs e)
        {
            

            
            Array.Sort(numberArray);

            foreach (int number in numberArray)
            {
                MessageBox.Show(number.ToString());
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total;
            total = totalArray();
            MessageBox.Show(total.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numberArray[0] = 3;
            numberArray[1] = 45;
            numberArray[2] = 31;
            numberArray[3] = 12;
            numberArray[4] = 67;
        }
    }
}
