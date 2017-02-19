using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem10
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb10display = new DisplayScreen();
            pb10display.ProblemTitle = "Problem 10";
            pb10display.ProblemHeader = "Summation of primes";
            pb10display.Description = "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\nFind the sum of all the primes below two million.";
            pb10display.DisplayHeader();

            //////////////////////////////////////////////////////////////////

            bool check ;
            int limit = 2000000;
            long sum = 5;//sum of 2 and 3
            for (int i = 5; i <= limit; i=i+2) {
                check = IsPrime.CheckIfPrime(i);
                if (check) {
                    sum += i;
                }
            }

            Console.WriteLine("\nsum of primes up to " + limit + " is : " + sum );
            
            /////////////////////////////////////////////////////////////////
            pb10display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
