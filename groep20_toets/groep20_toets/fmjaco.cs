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
    public partial class fmjaco : Form
    { 
        
        public fmjaco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classMIN cm = new classMIN();
            int num = Convert.ToInt16(textBox1.Text);

            cm.numGen(num);
        }
    }
}
