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

            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            { 
             { 1, "one" },{ 2, "two"},{ 3, "three"},{ 4, "four"}, { 5, "five"},
             { 6, "six"}, { 7, "seven"},{ 8, "eight"}, { 9, "nine"},
             { 10, "ten"},{ 11, "eleven"},{ 12, "twelve"},{ 13, "13"},
             { 14, "fourteen"},{ 15, "fifteen"},{ 16, "sixteen"},{ 17, "seventeen"},
             { 18, "eighteen"},{ 19, "nineteen"},{ 20, "twenty"},{ 30, "thirty"},
             { 40, "fourty"},{ 50, "fifty"},{ 60, "sixty"},{ 70, "seventy"},
             { 80, "eighty"},{ 90, "ninety"},{ 100, "hundred"},{ 1000, "thousand"}
            };
            string s = "";
            dictionary.TryGetValue(80, out s);
            Console.WriteLine(s);
            //foreach (KeyValuePair<int, string> pair in dictionary)
            //{
            //    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            //}
            //// Use var keyword to enumerate dictionary.
            //foreach (var pair in dictionary)
            //{
            //    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            //}

            //////////////////////////////////////////////////////////////////
            pb17display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
