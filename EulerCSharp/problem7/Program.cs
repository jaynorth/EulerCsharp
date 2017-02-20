using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb7display = new DisplayScreen();
            pb7display.ProblemTitle = "Problem 7";
            pb7display.ProblemHeader = "10001st prime";
            pb7display.Description = "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\nWhat is the 10 001st prime number ? ";
            pb7display.DisplayHeader();

            //////////////////////////////////////////////////////////////////

            int order = 10001;
            
            int result = PrimeNumberOrder.PrimeNumberST(order);
            pb7display.DisplayAnswer("Prime number " + order + " is  :", result);


            pb7display.DisplayFooter();
            Console.ReadKey();

        }
    }
}
