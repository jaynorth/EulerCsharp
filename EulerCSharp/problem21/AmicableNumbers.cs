using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem21
{
    class AmicableNumbers
    {
        public static List<int> amicableNumbers = new List<int>();

        public static int divisorsSum(int number) {
            int sum = 1;
        

            for (int i = 2; i < number; i++) {
                if (number % i == 0) {
                    sum += i;
                }
            }
                
            return sum;
        }

        public static void AmicableAddToList(int a, int b) {
            if (amicableNumbers.Contains(a) == false) {
                amicableNumbers.Add(a);
            }
            if (amicableNumbers.Contains(b) == false)
            {
                amicableNumbers.Add(b);
            }
        }

        public static int ReturnSumOfElementsList(List<int> amicableNumber) {
            int sum = 0;
            sum = amicableNumbers.Sum();

            return sum;
        }

    }
}
