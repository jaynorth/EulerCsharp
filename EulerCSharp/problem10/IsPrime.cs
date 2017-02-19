using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem10
{
    class IsPrime
    {
        


        public static bool CheckIfPrime(int number) {
          //no need to check divisions above square root, reduces computing time from 7 minutes to less than a second
            double limit = Math.Sqrt(number);
          //

          for(int i=3;i<limit+1; i=i+2 )//+2 steps because no need to check even numbers, 2 is the only one
          {
                if (number % i == 0)
                {
                    return false;
                }
                    
          }
            return true;
        }

        public static  long  PrimeListSum(List<long> primeList) {
            long sum = 0;
            foreach (int item in primeList)
            {
                sum += item;
            }

            return sum;
        }
    }
}
