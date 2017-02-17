using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Palindrome
    {

        public static int ReverseInt(int number) {
            int reversed=0;
            string s;
            string rev="";
            s = number.ToString();
            int count = s.Count();
            for (int i = count-1; i >=0; i--) {
                rev += s[i];



            }
            reversed = int.Parse(rev);
            //Console.WriteLine(rev);
            return reversed;
        }

        public static bool IsPalindrome(int number) {

            if (number == ReverseInt(number))
            {
                return true;
            }

            else
                return false;

        }
    }
}
