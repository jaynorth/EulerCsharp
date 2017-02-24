using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem23
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb23display = new DisplayScreen();
            pb23display.ProblemTitle = "Problem 23";
            pb23display.ProblemHeader = "Non-abundant sums";
            pb23display.Description = "A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.\n For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.\nA number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.\nAs 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24.By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.\nFind the sum of all the positive integers which cannot be written as the sum of two abundant numbers.";
            pb23display.DisplayHeader();

            //////////////////////////////////////////////////////////////////
            int limit = 28123;//28123;

            List<long> list = NonAbundantSums.MakeabundantNumbersList(limit);

            //NonAbundantSums.DisplayList(list);
            List<long> list2 = new List<long>();
            list2 = NonAbundantSums.MakeSumOf2abundantNumbersList(list);
            
            //NonAbundantSums.DisplayList(list2);
            long sum = 0;
            for (int i = 1; i < 28123; i++) {
                if (list2.Contains(i) == false) {
                    sum += i;
                }
            }

            Console.WriteLine("solution answer is " + sum);
            //
            //NonAbundantSums.NonSumOf2AbundantList(list);
            //
            //NonAbundantSums.SumOfNon2abundant(list);


            //////////////////////////////////////////////////////////////////

            pb23display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
