using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groep20_toets
{
    class clMIN
    {
        Random rnd = new Random();
       

        public void numGen(int num)
        {
            int minNum = 100;
            int[] numbers = new int[num];
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 100);
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
                MessageBox.Show("" + Convert.ToString(numbers[i]));
            }
            //minNum = numbers.Min();
            MessageBox.Show("Die MIN van die gegenereerde egtalle is :" + minNum);

        }
    }
}
