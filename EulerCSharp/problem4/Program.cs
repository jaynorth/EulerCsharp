using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb4display = new DisplayScreen();
            pb4display.ProblemTitle = "Problem 4";
            pb4display.ProblemHeader = "Largest palindrome product";
            pb4display.Description = "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\nFind the largest palindrome made from the product of two 3 - digit numbers.";
            pb4display.DisplayHeader();


            // To make it work I needed long numbers instead of long

            int biggestPalindrome = 0;

            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    int result = NumberProduct.Product2Numbers(i, j);
                    if (Palindrome.IsPalindrome(result) && result>biggestPalindrome) {
                        biggestPalindrome = result;
                    }
                }
            }

            pb4display.DisplayAnswer("Biggest Palindrome is :", biggestPalindrome);
            
            

            
            pb4display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
