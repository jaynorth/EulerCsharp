using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Display;

namespace problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb20display = new DisplayScreen();
            pb20display.ProblemTitle = "Problem 20";
            pb20display.ProblemHeader = "Factorial digit sum";
            pb20display.Description = "n! means n × (n − 1) × ... × 3 × 2 × 1\nFor example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,\nand the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.\nFind the sum of the digits in the number 100!";
            pb20display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            int factorialNumber = 100;
            double sum;
            // To make it work it requires to use BigInteger after adding System.Numerics namespace
            BigInteger f = factorialNumber;
            BigInteger factorialResult = 0;

            factorialResult = Factorials.BigFactorial(factorialNumber);
            sum = Factorials.SumNumbers(factorialResult);

            Console.WriteLine("Factorial "+factorialNumber+"! is:\n\n" + factorialResult + "\n\nsum of all the digits is : \n" + sum);
 

            //////////////////////////////////////////////////////////////////
            pb20display.DisplayFooter();
            Console.ReadKey();
            

            
        }
    }
}
