using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexusHomework
{
    public static class BitTask
    {
        public static bool BitQuestion(int x)
        {
            return (x & (x - 1)) == 0;
        }

        public static string ToBitStr(int x)
        {
            var s = Convert.ToString(x, 2).PadLeft(8, '0');
            return s;
        }
    }
}
