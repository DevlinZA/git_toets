using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groep20_toets
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            string list = "";
            string median;
            int n = Convert.ToInt16(textBox1.Text);
            int[] arrlist = cls.generate(n);

            for (int i = 0; i < n; i++)
            {
                list += arrlist[i] + "\r\n";
            }

            median = Convert.ToString(cls.calcMedian(arrlist));

            MessageBox.Show("The list is: \r\n" + list + "\r\n The median is " + median);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
