using Display;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb8display = new DisplayScreen();
            pb8display.ProblemTitle = "Problem 8";
            pb8display.ProblemHeader = "Largest product in a series";
            pb8display.Description = "The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.\nFind the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?";
            pb8display.DisplayHeader();

            //////////////////////////////////////////////////////////////////
            string filePath = @"numberTable.txt";
            StreamProcess.DisplayFile(filePath);
            StreamReader sr = new StreamReader(filePath);

            string line = StreamProcess.ConvertToString(sr);
            //Console.WriteLine("converted string : " + line);
            long[] tab = StringProducts.BiggestProduct(13, line);
            int count = 0;
            foreach (long n in tab) {
                count++;
                Console.WriteLine("item "+ count +" : " + n + " ");
            }

            /////////////////////////////////////////////////////////////////
            //  For this to Work you need to work with long type not int
            //
            /////////////////////////////////////////////////////////////////
            pb8display.DisplayFooter();
            Console.ReadKey();

        }
    }
}
