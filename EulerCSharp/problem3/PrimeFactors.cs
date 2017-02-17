using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class PrimeFactors
    {


        public static List<int> PrimeFactorNumbers(long number) {

            List<int> ListeFactors = new List<int>();

            bool prime ;
            int lastPrime=0;

         

            //Console.WriteLine("new number is " + number);

            for (int i = 3; i*i < number; i = i + 2) {
                prime = false;

                if (number % i == 0) {

                    for (int j = 2; j < i; j++) {

                        if (i % j == 0)
                        {
                            prime = false;
                            
                            break;
                        }
                        else {
                            prime = true;
                            lastPrime = i;
                            
                        }
                    }
                    
                }

                if (prime == true) {
                    ListeFactors.Add(i);
                }
            }

            return ListeFactors;
        }

        public static void ReadList(List<int> ListeFactors) {
            foreach (int number in ListeFactors) {
                Console.WriteLine(number);
            }
        }
    }
}
