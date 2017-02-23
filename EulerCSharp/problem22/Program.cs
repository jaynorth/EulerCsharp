using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem22
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb22display = new DisplayScreen();
            pb22display.ProblemTitle = "Problem 22";
            pb22display.ProblemHeader = "Names scores";
            pb22display.Description = "Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.\nFor example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.\nWhat is the total of all the name scores in the file?";
            pb22display.DisplayHeader();


            //////////////////////////////////////////////////////////////////

            for (char a = 'A'; a <= 'Z'; a++) {

                Console.Write("{0} ",a);
            }

            //////////////////////////////////////////////////////////////////
            pb22display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
