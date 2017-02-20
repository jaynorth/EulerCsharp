using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb14display = new DisplayScreen();
            pb14display.ProblemTitle = "Problem 14";
            pb14display.ProblemHeader = "Longest Collatz sequence";
            pb14display.Description = "The following iterative sequence is defined for the set of positive integers:\n\tn → n / 2(n is even)\n\tn → 3n + 1(n is odd)\nUsing the rule above and starting with 13, we generate the following sequence:\n\t13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1\nIt can be seen that this sequence(starting at 13 and finishing at 1) contains 10 terms.\nAlthough it has not been proved yet(Collatz Problem), it is thought that all starting numbers finish at 1.\nWhich starting number, under one million, produces the longest chain?\nNOTE: Once the chain starts the terms are allowed to go above one million.";
            pb14display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            long startingNumber=0;
            long steps =0;
            int limit = 1000000;
            long[] table = new long[limit/10+1];//no need to have a bigger table I suppose
            long biggestChain = 0;


            for (long i = 1; i < limit; i++) {
                steps = Collatz.CountCollatzNoRecurrence( table, i);
                if (i < table.Length) { table[i] = steps; }
                if (steps >= biggestChain) {
                    biggestChain = steps;
                    startingNumber = i;
                }
            }

            Console.WriteLine("for number " + startingNumber + " there are " + biggestChain + " steps ");


            pb14display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
