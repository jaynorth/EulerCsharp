using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem6
{
    public class SumSquareDifference
    {

        public static long SumSquares(long limit) {
            long sum = 0;
            for (long i = 1; i <= limit; i++) {
                sum += i * i;
            }
            return sum;
        }

        public static long SquareOfSum(long limit) {
            long sum = 0;
            for (long i = 1; i <= limit; i++)
            {
                sum += i;
            }

            sum = sum * sum;
            return sum;
        }

        public static long Difference(long squareofsum, long sumsquares) {
            long diff = squareofsum - sumsquares;
            return diff;
        }
    }
}
