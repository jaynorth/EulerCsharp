using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class PrimeFactors
    {


        public static List<long> PrimeFactorNumbers(long number) {

            List<long> ListeFactors = new List<long>();

            bool prime ;
           

         

            //Console.WriteLine("new number is " + number);

            for (long i = 3; i*i < number; i = i + 2) {
                prime = false;

                if (number % i == 0) {

                    for (long j = 2; j < i; j++) {

                        if (i % j == 0)
                        {
                            prime = false;
                            
                            break;
                        }
                        else {
                            prime = true;
                           
                            
                        }
                    }
                    
                }

                if (prime == true) {
                    ListeFactors.Add(i);
                }
            }

            return ListeFactors;
        }

        public static void ReadList(List<long> ListeFactors) {
            foreach (long number in ListeFactors) {
                Console.WriteLine(number);
            }
        }
    }
}
