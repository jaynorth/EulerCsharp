using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace problem20
{
    class Factorials
    {
        public static long result=1;
        public static BigInteger bigResult = 1;

        public static BigInteger BigFactorial (BigInteger bigNumber){
            if (bigNumber == 1)
            {
                return bigResult;
            }
            else
            {
                bigResult *= bigNumber * BigFactorial(bigNumber - 1);
            }

            return bigResult;
           
        }
        public static long Factorial(int number)
        {
            if (number == 1) {
                return result;
            }
            else
            {
                result *= number*Factorial(number - 1);
            }
            
            return result;
        }

        public static double SumNumbers(BigInteger number) {
            string s = number.ToString();
            double sum = 0;
            double t;
            int l = s.Length;
            for (int i = 0; i < l; i++) {
                t= Convert.ToInt32(char.GetNumericValue(s[i]));
                //Console.WriteLine(t);
                sum += t;
            }

            return sum;
        
        }
        
    }


}
