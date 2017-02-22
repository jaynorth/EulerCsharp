using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class CountLetters

    {
        public static string s = "";
        public static string and = "and";
        public static int lettersSum = 0;
        public static int remainder ;
      
        public static    Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
             { 1, "one" },{ 2, "two"},{ 3, "three"},{ 4, "four"}, { 5, "five"},
             { 6, "six"}, { 7, "seven"},{ 8, "eight"}, { 9, "nine"},
             { 10, "ten"},{ 11, "eleven"},{ 12, "twelve"},{ 13, "thirteen"},
             { 14, "fourteen"},{ 15, "fifteen"},{ 16, "sixteen"},{ 17, "seventeen"},
             { 18, "eighteen"},{ 19, "nineteen"},{ 20, "twenty"},{ 30, "thirty"},
             { 40, "forty"},{ 50, "fifty"},{ 60, "sixty"},{ 70, "seventy"},
             { 80, "eighty"},{ 90, "ninety"},{ 100, "hundred"},{ 1000, "thousand"}
            };

        //40 is spelled forty (not fourty)


     
        public static void LetterSumLess20(int i)
        {
            dictionary.TryGetValue(i, out s);
            Console.Write(s);
            lettersSum  += s.Length;
        }

        public static void LetterSumOver20Less100(int i)
        {

            if (i % 10 == 0)
            {
                dictionary.TryGetValue(i, out s);
                Console.Write(s);
                lettersSum += s.Length;
            }
            else {
                remainder = i % 10;
                LetterSumLess20(i-remainder);
                LetterSumLess20(remainder);
            }            
        }

        public static void LetterSumOver100(int i)
        {
            if (i % 100 == 0 && i < 1000)
            {

                LetterSumLess20(i/100);
                dictionary.TryGetValue(100, out s);
                Console.Write(s);
                lettersSum += s.Length;
            }

            else if (i % 100 != 0 && i < 1000)
            {
                remainder = i % 100;
                dictionary.TryGetValue((i - remainder) / 100, out s);
                Console.Write(s);
                lettersSum += s.Length;
                dictionary.TryGetValue(100, out s);
                Console.Write(s);
                lettersSum += s.Length;
                lettersSum += and.Length;
                Console.Write(" and ");


                if (remainder < 20)
                {
                    LetterSumLess20(remainder);
                }
                else if (remainder >= 20)
                {
                    LetterSumOver20Less100(remainder);
                }

            }
        }

        public static void LetterSum1000(int i)
        {
            dictionary.TryGetValue(1, out s);
            Console.Write(s);
            lettersSum += s.Length;
            dictionary.TryGetValue(1000, out s);
            Console.Write(s);
            lettersSum += s.Length;
        }
    }
}
