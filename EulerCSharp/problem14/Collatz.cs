using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem14
{
    class Collatz
    {
        public static long count=0;
        public static long CountCollatz(int startingNumber) {

            
            if (startingNumber == 1)
            {
                //Console.WriteLine("Chain reached 1");
                count++;
                return count;
            }
            else if (startingNumber % 2 == 0)
            {
                startingNumber = startingNumber / 2;
                count++;
                CountCollatz(startingNumber);
            }
            else
            {
                startingNumber = (3 * startingNumber) + 1;
                count++;
                CountCollatz(startingNumber);
            }

            
            return count;
        }

        public static long CountCollatzNoRecurrence(long[] array, long startingNumber)
        {
            count = 0;

            while (startingNumber != 1)
            {
                if (startingNumber < array.Length && array[startingNumber]!=0) {
                    count += array[startingNumber];
                    return count;
                }
                else if (startingNumber % 2 == 0)
                {
                    startingNumber = startingNumber / 2;
                    count++;

                }
                else
                {
                    startingNumber = (3 * startingNumber) + 1;
                    count++;
                 }
            }

            count++;        
            return count;
        }

        
    }
}
