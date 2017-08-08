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
    public partial class frmJaco : Form
    {
        clMIN cmin = new clMIN();
        public frmJaco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int num = Convert.ToInt16(txt1.Text);
            cmin.numGen(num);

        }
    }
}
