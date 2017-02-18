using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
    class PrimeNumberOrder
    {

        public static int PrimeNumberST(int orderNumber) {
            int prime =5;
            int count = 3;
            int i = 5;
            bool isprime = false;

            while (count <= orderNumber) {

                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        i = i + 2;
                        j = 2;

                    }
                    else {
                        isprime = true;
                    }
                    
                }
                
                if (isprime) {
                    count++;
                    i = i + 2;
                }
            }

            

            prime = i - 2;
            return prime;
        }
    }
}
