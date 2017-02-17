﻿using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb2display = new DisplayScreen();
            pb2display.ProblemTitle = "Problem 2";
            pb2display.ProblemHeader = "Even Fibonacci numbers";
            pb2display.Description = "Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:\n 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ... \n By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            pb2display.DisplayHeader();


            int limit = 4000000;
            int total = Fibonacci.SumEvenTerms(limit);



            
            //Console.WriteLine("Fibonaaci sum for term " + term + " is " + a);
            pb2display.DisplayAnswer("Fibonacci sum for even numbers under 4000000 is : ", total);
            DisplayScreen.Timestamp();
            Console.ReadKey();
        }
    }
}
