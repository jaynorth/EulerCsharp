using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb3display = new DisplayScreen();
            pb3display.ProblemTitle = "Problem 3";
            pb3display.ProblemHeader = "Largest prime factor";
            pb3display.Description = "The prime factors of 13195 are 5, 7, 13 and 29.\n What is the largest prime factor of the number 600851475143 ?";
            pb3display.DisplayHeader();

            DateTime t1 = DateTime.Now;
            

            long number = 600851475143; //600851475143 13195

            List<int> List = PrimeFactors.PrimeFactorNumbers(number);
            //PrimeFactors.ReadList(List);
            try
            {
                Console.WriteLine("Largest Prime Factor for " + number + " is : " + List.Max());
                DateTime t2 = DateTime.Now;
                Console.WriteLine("Timer : " + (t2 - t1));
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was an error: " + ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
