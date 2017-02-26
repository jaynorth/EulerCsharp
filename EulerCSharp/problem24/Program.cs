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
            // More info on implemented algorithm on Wikipedia
            // https://en.wikipedia.org/wiki/Permutation
            //////////////////////////////////////////////////////////////////

            int[] items = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int size = items.Length;
            int limit = 1000000;
            int count = 1;
            long possiblePermutations = Factorials.Factorial(size);
            Console.WriteLine("possible permutations :{0}\n", possiblePermutations);
            int k = 0;
            int l;

            while (count!=limit)
            {
                //Implementing Generation in lexicographic order
                k = Permutations.FindK(items);
                l = Permutations.FindL(items, k);
                Permutations.SwapValues(k, l, items);
                Permutations.ReverseSeq(items, k);
                count++;
               
                
            }

            Console.Write("Permutation number {0}:   ", count);
            Permutations.DisplayArray(items);

            //////////////////////////////////////////////////////////////////

            pb23display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
