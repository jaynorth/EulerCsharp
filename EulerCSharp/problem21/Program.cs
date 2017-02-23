using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb21display = new DisplayScreen();
            pb21display.ProblemTitle = "Problem 21";
            pb21display.ProblemHeader = "Amicable numbers";
            pb21display.Description = "Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).\nIf d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.\nFor example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.\nEvaluate the sum of all the amicable numbers under 10000.";
            pb21display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            //int number = 284;
            int limit = 10000;
            long sum = 0;
            int a, b;

            for (int i = 1; i < limit; i++) {
                a = AmicableNumbers.divisorsSum(i);
                b = AmicableNumbers.divisorsSum(a);
                if (b == i && a!=b)
                {
                    AmicableNumbers.AmicableAddToList(a, b);
                }
            }

            sum = AmicableNumbers.ReturnSumOfElementsList(AmicableNumbers.amicableNumbers);

            Console.WriteLine("sum of amicable numbers up to " +limit +" is : "+sum) ;




            //////////////////////////////////////////////////////////////////
            pb21display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
