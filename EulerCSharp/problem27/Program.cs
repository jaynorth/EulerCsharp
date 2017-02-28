using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem26
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb26display = new DisplayScreen();
            pb26display.ProblemTitle = "Problem 26";
            pb26display.ProblemHeader = "Reciprocal cycles";
            pb26display.Description = "A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:\n1 / 2 = 0.5\n1 / 3 = 0.(3)\n1 / 4 = 0.25\n1 / 5 = 0.2\n1 / 6 = 0.1(6)\n1 / 7 = 0.(142857)\n1 / 8 = 0.125\n1 / 9 = 0.(1)\n1 / 10 = 0.1\nWhere 0.1(6) means 0.166666..., and has a 1 - digit recurring cycle. It can be seen that 1 / 7 has a 6 - digit recurring cycle.\nFind the value of d < 1000 for which 1 / d contains the longest recurring cycle in its decimal fraction part.";
            pb26display.DisplayHeader();

            //////////////////////////////////////////////////////////////////


            float fraction = 1 / 7f;
            double dbl = 1 % 7d;
            decimal d = 1 / 7m;
            Console.WriteLine(fraction);
            Console.WriteLine(dbl);
            Console.WriteLine("d:" +d);
            string s = "";

            s = d.ToString();
            Console.WriteLine(s);






            //////////////////////////////////////////////////////////////////

            pb26display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
