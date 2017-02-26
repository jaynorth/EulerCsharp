using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Fibonacci
    {

        public static int Fibon(int term) {
            int sum = 0;
            if (term == 1)
            {
                sum = 1;
            }
            else if (term == 2)

            {
                sum = 2;
            }
            else 
            {
                sum += Fibon(term - 1) + Fibon(term - 2);
            }
          
        
            return sum;
        }

        public static int SumEvenTerms(int limit)
        {

            int term = 1;
            int a = 0;
            int total = 0;

            while (a < 4000000)
            {

                a = Fibonacci.Fibon(term);
                term++;
                if (a % 2 == 0)
                {
                    total += a;
                }

            }

            return total;
        }

        public static long _fibonTotal { get;  set; } = 0;

        public static long FibonBig(long term, long[] fibonArray) {

            _fibonTotal = 0;

            if (fibonArray[term] != 0) {
                _fibonTotal += fibonArray[term];
                return _fibonTotal;
            }


            else if (term == 2)
            {
                fibonArray[2] = 1;
                _fibonTotal += 1;
                

            }
            else if (term == 1)
            {
                fibonArray[1] = 1;
                _fibonTotal += 1;
             
            }

            else
            {

                _fibonTotal += FibonBig(term - 1, fibonArray) + FibonBig(term - 2, fibonArray);
            }

            fibonArray[term] = _fibonTotal;
            
            return _fibonTotal;
        }

        public static int ReturnNumberDigits(long number) {
            string digits;
            digits = number.ToString();

            return digits.Length;
        }

       
    }
}
