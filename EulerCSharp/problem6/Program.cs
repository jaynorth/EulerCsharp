using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb6display = new DisplayScreen();
            pb6display.ProblemTitle = "Problem 5";
            pb6display.ProblemHeader = "Sum square difference";
            pb6display.Description = "The sum of the squares of the first ten natural numbers is,\n12 + 22 + ... + 102 = 385\nThe square of the sum of the first ten natural numbers is,\n(1 + 2 + ... + 10)2 = 552 = 3025\nHence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.\nFind the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
            pb6display.DisplayHeader();

            //////////////////////////////////////////////////////////////////

            long a, b, result;
            a = SumSquareDifference.SumSquares(100);
            b = SumSquareDifference.SquareOfSum(100);

            result = SumSquareDifference.Difference(b, a);
            //Console.WriteLine(result);
      

            pb6display.DisplayAnswer("difference is :" , result);




            pb6display.DisplayFooter();
            Console.ReadKey();

        }
    }
}
