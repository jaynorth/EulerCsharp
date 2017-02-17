using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb1display = new DisplayScreen();
            pb1display.ProblemTitle = "Problem 1";
            pb1display.ProblemHeader = "Multiples of 3 and 5";
            pb1display.Description = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.Find the sum of all the multiples of 3 or 5 below 1000.";
            pb1display.DisplayHeader();

            int s = Multiples.SumOfMultiples(3, 5, 1000);
            pb1display.DisplayAnswer("the total sum of multiples is", s);
           

            Console.ReadKey();

        }
    }
}
