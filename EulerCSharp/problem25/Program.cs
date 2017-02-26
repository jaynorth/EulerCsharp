using Display;
using Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace problem25
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb25display = new DisplayScreen();
            pb25display.ProblemTitle = "Problem 25";
            pb25display.ProblemHeader = "1000-digit Fibonacci number";
            pb25display.Description = "The Fibonacci sequence is defined by the recurrence relation:\nFn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.\nHence the first 12 terms will be:\nF1 = 1\nF2 = 1\nF3 = 2\nF4 = 3\nF5 = 5\nF6 = 8\nF7 = 13\nF8 = 21\nF9 = 34\nF10 = 55\nF11 = 89\nF12 = 144\nThe 12th term, F12, is the first term to contain three digits.\nWhat is the index of the first term in the Fibonacci sequence to contain 1000 digits ? ";
            pb25display.DisplayHeader();

            //////////////////////////////////////////////////////////////////


            BigInteger fib1 = 1;//base case for index 1
            BigInteger fib2 = 1;//base case for index 2
            BigInteger limit = 1000;//number of digits

            BigInteger fib3 = Fibonacci.fibDigitLimit(fib1, fib2, limit);
            Console.WriteLine("Fibonacci index  is: {0} for first Fibonacci number of {1} digits",fib3, limit);






            //////////////////////////////////////////////////////////////////

            pb25display.DisplayFooter();
            Console.ReadKey();
        }

     
    }
}
