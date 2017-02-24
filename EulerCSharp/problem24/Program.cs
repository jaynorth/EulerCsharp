using Display;
using problem20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem24
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb23display = new DisplayScreen();
            pb23display.ProblemTitle = "Problem 24";
            pb23display.ProblemHeader = "Lexicographic permutations";
            pb23display.Description = "A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:\n012   021   102   120   201   210\nWhat is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9 ? ";
            pb23display.DisplayHeader();

            //////////////////////////////////////////////////////////////////
            // string filePath=@""
            //StreamReader sr = new StreamReader();
            //////////////////////////////////////////////////////////////////
            //string[] items = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            List<string> lexicoList = new List<string>();
            string[] items = new string[] { "1", "2", "3","4", "5", "6", "7" };//, "4", "5", "6", "7", "8", "9" };//,"3"};

          

            int NumberItems = items.Length;//number of numbers to be permuted
            long possiblePermutations = Factorials.Factorial(NumberItems);
            Console.WriteLine("Number of possible permutations: {0}", possiblePermutations);
            int count = 1;
            List<string> list1 = new List<string>();

             list1 =    Permutations.LexicographicOrderPermutations(items);
      
            Permutations.DisplayList(Permutations.LexographicList);
          

            //////////////////////////////////////////////////////////////////

            pb23display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
