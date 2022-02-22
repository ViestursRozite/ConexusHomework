using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexusHomework
{
    public static class FindMedian
    {
        public static double Median(double[] sourceNumbers, bool keepSourceNumbersIntact = true)
        {
            if (keepSourceNumbersIntact)//Protect original arr
            {
                double[] cloneArr = (double[])sourceNumbers.Clone();
                Array.Sort(cloneArr);
                return MedianDestructive(cloneArr);
            }
            else//Don't protect
            {
                return MedianDestructive(sourceNumbers);
            }

        }

        public static double MedianDestructive(double[] sourceNumbers)
        {
            Array.Sort(sourceNumbers);

            if (sourceNumbers.Length % 2 == 1)
            {
                return sourceNumbers[(sourceNumbers.Length - 1) / 2];//Middle elem
            }
            else
            {
                return 0.5 * (sourceNumbers[sourceNumbers.Length / 2] + sourceNumbers[(sourceNumbers.Length / 2) - 1]);//Avg of 2 elem
            }
        }
    }
}
