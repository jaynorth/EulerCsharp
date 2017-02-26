using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class Fibonacci
    {

        public static int Fibon(int term)
        {
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



        public static int ReturnNumberDigits(long number)
        {
            string digits;
            digits = number.ToString();

            return digits.Length;
        }

        public static BigInteger fibDigitLimit(BigInteger fib1, BigInteger fib2, BigInteger limit)
        {
            BigInteger counter = 2;
            BigInteger fib3 = 0;
            while (fib3.ToString().Length < limit) {
                fib3 = fib1 + fib2;

                fib1 = fib2;
                fib2 = fib3;
                counter++;
            }

            Console.WriteLine("Fibonacci number :\n {0}\n",fib3);

            return counter;

        }


    }
}
