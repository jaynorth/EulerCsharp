using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem16
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb16display = new DisplayScreen();
            pb16display.ProblemTitle = "Problem 16";
            pb16display.ProblemHeader = "Power digit sum";
            pb16display.Description = "2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.\nWhat is the sum of the digits of the number 21000 ? ";
            pb16display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            int sum = 0;
            int power = 1000;
            BigInteger number = 2;
            number = BigInteger.Pow(number, power);
            string s= number.ToString();
            //Console.WriteLine(s);
            foreach (char item in s) {
                
                sum += Convert.ToInt32(char.GetNumericValue(item));//converts char to double then converts double to int32
            }

            Console.WriteLine("sum is : " + sum);
            //////////////////////////////////////////////////////////////////
            pb16display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
