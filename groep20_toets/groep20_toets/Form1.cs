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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            MessageBox.Show("Release 3");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmjaco fJaco = new fmjaco();
            fJaco.Show();
            MessageBox.Show("hotfix1");
        }
    }
}
