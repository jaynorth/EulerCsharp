using Display;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb13display = new DisplayScreen();
            pb13display.ProblemTitle = "Problem 13";
            pb13display.ProblemHeader = "Large sum";
            pb13display.Description = "Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.";
            pb13display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            //Make reference to System.Numeric library in assembly
            string filePath = @"LargeSum.txt";
            StreamReader sr = new StreamReader(filePath);
            string solution="";
            string line = sr.ReadLine();
            BigInteger result= new BigInteger();//Make reference to System.Numeric library in assembly 

            while (line != null) {
                Console.WriteLine(line);
                result += BigInteger.Parse(line);
                
                line = sr.ReadLine();
            }
            sr.Close();
            string resultString = result.ToString();
            for (int i = 0; i < 10; i++) {
                solution += resultString[i];
            }
            

            Console.WriteLine("\nThe first ten digits of the sum : "+solution);
           
            pb13display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
