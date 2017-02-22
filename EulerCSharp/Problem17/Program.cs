using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb17display = new DisplayScreen();
            pb17display.ProblemTitle = "Problem 17";
            pb17display.ProblemHeader = "Number letter counts";
            pb17display.Description = "If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.\nIf all the numbers from 1 to 1000(one thousand) inclusive were written out in words, how many letters would be used?\n\nNOTE: Do not count spaces or hyphens. For example, 342(three hundred and forty - two) contains 23 letters and 115(one hundred and fifteen) contains 20 letters.The use of \"and\" when writing out numbers is in compliance with British usage.";
            pb17display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            Console.BufferHeight = Int16.MaxValue - 1; // ***** Alters the BufferHeight *****

            for (int i = 1; i <= 1000; i++) {

                if (i <= 20)
                {
                    CountLetters.LetterSumLess20(i);
                    Console.WriteLine();
                }
                else if (i > 20 && i < 100)
                {
                    CountLetters.LetterSumOver20Less100(i);
                    Console.WriteLine();

                }
                else if (i >= 100 && i < 1000)
                {
                    CountLetters.LetterSumOver100(i);
                    Console.WriteLine();
                }
                else if (i == 1000) {
                    CountLetters.LetterSum1000(i);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Case not handled");
                    Console.WriteLine();
                }
            }


            Console.WriteLine("Total number of letters used is : "+CountLetters.lettersSum );


            //////////////////////////////////////////////////////////////////
            pb17display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
