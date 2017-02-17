using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Fibonacci
    {

        public static int TotalEvenSums = 0;

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
    }
}
