using Display;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem67
{
    class Program
    {
        public static string[] t { get; private set; }

        static void Main(string[] args)
        {

            DisplayScreen pb67display = new DisplayScreen();
            pb67display.ProblemTitle = "Problem 67";
            pb67display.ProblemHeader = "Number letter counts";
            pb67display.Description = "If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.\nIf all the numbers from 1 to 1000(one thousand) inclusive were written out in words, how many letters would be used?\n\nNOTE: Do not count spaces or hyphens. For example, 342(three hundred and forty - two) contains 23 letters and 115(one hundred and fifteen) contains 20 letters.The use of \"and\" when writing out numbers is in compliance with British usage.";
            pb67display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            //string filePath = @"TriangleExample.txt";
            //string filePath = @"NumbersTriangle.txt"; 
            string filePath = @"p067_triangle.txt";
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            int pathSteps = 100;//number of lines in triangle or file
       
            int[,] triangleArray= new int[pathSteps, pathSteps];
            int column = 0;
            int row = 0; 
            //trying solution on example
            while (line != null) {
               // Console.WriteLine(line);
                t =line.Split(' ');
                foreach (string item in t)
                {
                    triangleArray[column, row]=int.Parse(item);
                    row++;
                }
                line = sr.ReadLine();
                column++;
                row = 0;
            }
            
            computeTriangle.DisplayArray(triangleArray, pathSteps);

            //Console.WriteLine("length:" + triangleArray.Length);
            computeTriangle.CompareTriangle(triangleArray, pathSteps);

            //Console.WriteLine("new array: ");
            //computeTriangle.DisplayArray(triangleArray);

            //////////////////////////////////////////////////////////////////
            pb67display.DisplayFooter();
            Console.ReadKey();


        }
    }
}
