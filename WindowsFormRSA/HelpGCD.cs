using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRSA
{
    public class HelpGCD
    {
        int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        /// <summary>
        /// Tìm số nguyên tố cùng nhau
        /// </summary>
        /// <param name="phi"></param>
        /// <returns></returns>
        public int Find_eA(int phi)
        {
            int count = 3;
            while (GCD(count, phi) != 1)
            {
                count++;
            }
            return count;
        }
    }
}
