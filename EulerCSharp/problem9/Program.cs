using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem9
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb9display = new DisplayScreen();
            pb9display.ProblemTitle = "Problem 9";
            pb9display.ProblemHeader = "Special Pythagorean triplet";
            pb9display.Description = "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,\na2 + b2 = c2\nFor example, 32 + 42 = 9 + 16 = 25 = 52.\nThere exists exactly one Pythagorean triplet for which a +b + c = 1000.\nFind the product abc.";
            pb9display.DisplayHeader();

            //////////////////////////////////////////////////////////////////
            long a, b, c, d , limit, sum;
            c = 1;
            b = 1;
            sum = 0;
            long product;

            limit = 500;
           
            for (a = 2; a < limit; a++)
            {
                for (b = 1; b < limit / 2; b++) { 
                    
                    d = (a * a) + (b * b);
                    //Console.WriteLine(d);
                    c = Convert.ToInt32(Math.Sqrt(d));
                    //Console.WriteLine(c);

                    sum = a + b + c;
                    //Console.WriteLine("a = " + a + " , b = " + b + " , c = " + c);

                    //Console.WriteLine("Sum is : " + sum);
                    if (sum == 1000 && ((a*a)+(b*b)==(c*c)))
                    {

                        Console.WriteLine("\nSuccess!!!!!!!!!!\n a = " + a + " , b = " + b + " , c = " + c);
                        product = a * b * c;
                        Console.WriteLine("product is: " + product);
                        break;
                      
                        
                    }
                }
           



            }
                
            
            

            Console.WriteLine("YEAH!");


       
            /////////////////////////////////////////////////////////////////
            pb9display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
