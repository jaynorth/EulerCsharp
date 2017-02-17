using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {


            DisplayScreen pb5display = new DisplayScreen();
            pb5display.ProblemTitle = "Problem 5";
            pb5display.ProblemHeader = "Smallest multiple";
            pb5display.Description = "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\nWhat is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ? ";
            pb5display.DisplayHeader();

            int number = 2520;
            int limit = 20;
            bool isValid = false;
            
            while (isValid == false) {
                number++;
                isValid = SmallestMultiple.SmallestNumber(number, limit);
                
            }
            

            Console.WriteLine("Number " + number + " Pass Test: " + isValid);

           

            //pb5display.DisplayAnswer("number  :"+ number , isValid);




            pb5display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
