using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem23
{
    class NonAbundantSums
    {
        public static List<long> MakeabundantNumbersList(int limit)
        {
            List<long> abundantList = new List<long>();

            long sum;
            for (int i = 1; i < limit; i++) {
                sum = 0;
                for (int j = 1; j <= i / 2; j++) {
                    if (i % j == 0) {
                        sum += j;
                    }
                }

                if (sum > i && sum<limit)
                {
                    abundantList.Add(i);
                }
            }

            return abundantList;
        }

        public static void DisplayList(List<long> list) {
            int count = 0;
            foreach (long item in list) {
                Console.Write(" number: {0} index:{1} ", item, count);
                count++;
            }
        }

        public static bool[] MakeSumOf2abundantNumbersList(List<long> list,int limit)
        {
            long sum;
            bool[] IsSumAbundant = new bool[limit + 1];
            
            
            int count = list.Count;

            for (int i = 0; i < count; i++) {

                for (int j = i; j < count; j++) {
                   
                    sum = list[i] + list[j];

                    if (sum <= limit )
                    {

                        IsSumAbundant[sum] = true;                     

                    }
                    else {
                        break;
                    }
                    
                }
            }

            return IsSumAbundant;
        }

        internal static long NonSumOf2AbundantList(bool[] isAbundantArray)
        {
            long sum = 0;
            for (int i = 1; i < (isAbundantArray.Length); i++)
            {

                if (isAbundantArray[i] == false)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
