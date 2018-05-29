using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata1
{
    public class StringCalculator
    {
        public int AddString(params string[] numbers)
        {
            int result = 0;
            int i = 0;
            for (; ;)
                //for (int i=0; i< numbers.Length; i++)
            {
                if (i < numbers.Length)
                    {
                    var separatenumbers = numbers[i].Split(',');
                    // Console.WriteLine(separatenumbers);
                    foreach (var j in separatenumbers)
                    {
                        result = result + int.Parse(j);
                    }
                    i++;
                }
                else
                    break;
                //result =+ int.Parse(numbers[i]);
            }
            return result;
            //int NumberA = int.Parse(A);
            //int NumberB = int.Parse(B);
            //int res = NumberA + NumberB;
           
        }
      }
}
