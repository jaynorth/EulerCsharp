using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class SmallestMultiple
    {
        public static bool SmallestNumber(int number, int limit) {
            bool answer=false;
            for (int i = 1; i <= limit; i++) {
                if (number % i != 0)
                {
                    answer = false;
                    break;
                }
                else answer = true;
            }
            return answer;
        }
    }
}
