using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem12
{
    class Triangle
    {
        public static long TriangleNumber(long termNumber) {
            long triangleNumber = 0;

            for (long i = 1; i <= termNumber; i++) {
                triangleNumber += i;
            }
            return triangleNumber;
        }

        public static long NumberOfDivisors(long number, int solution) {
            long divisors = 0;
            double squareRoot = Math.Sqrt(number);
            if (number < solution*2)
            {
                return divisors;
            }
            //for every int under square root there is 1 int over squareroot, we just add two to divisors instead of 1
            for (long i = 1; i<=squareRoot  ; i++) {
                
                if (number % i == 0) {
                    //Console.Write(number + ", ");
                    divisors =divisors+2;
                    if (number == i*i)//if i is a perfect square root then obviously there's no int above, we take off 1 of the two added above
                    {
                        divisors--;
                    }
                }          
            }
            return divisors;
        }
    }
}
