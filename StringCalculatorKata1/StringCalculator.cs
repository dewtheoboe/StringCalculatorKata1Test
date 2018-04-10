using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata1
{
    public class StringCalculator
    {
        public int AddString(string A = "0", string B = "0", string C = "0")
        {
            int NumberA = int.Parse(A);
            int NumberB = int.Parse(B);
            int NumberC = int.Parse(C);
            int res = NumberA + NumberB + NumberC;
            return res;
        }

    }
}
