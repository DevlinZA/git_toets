using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groep20_toets
{
    class Class1
    {
        public int[] generate(int n)
        {
            Random rnd = new Random();
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = rnd.Next(0, 100);
            }
            return list;
        }

        public double calcMedian(int[] numbers)
        {
            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2;
            var sortedNumbers = numbers.OrderBy(n => n);
            double median;
            if ((numberCount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt((halfIndex - 1))) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }
            return median;
        }
    }
}
