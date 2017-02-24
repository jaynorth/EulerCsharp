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
            for (int i = 12; i < limit; i=i+2) {
                sum = 0;
                for (int j = 1; j <= i / 2; j++) {
                    if (i % j == 0) {
                        sum += j;
                    }
                }

                if (sum > i && sum<28123)
                {
                    abundantList.Add(i);
                    //Console.Write(" abundant:" + i);
                }
    
            }

            return abundantList;
        }

        public static void DisplayList(List<int> list) {

            foreach (int item in list) {
                Console.Write(" {0} ", item);
            }
        }

        public static List<long> MakeSumOf2abundantNumbersList(List<long> list)
        {
            long sum;
            int limit = 28123;
            int count = list.Count;
            List<long> SumabundantList = new List<long>();

            Console.WriteLine("count "+ count);

            for (int i = 0; i < (count-i); i++) {
                for (int j = i; j < count-j; j++) {
                    sum = list[i] + list[j];
                    if (sum < limit && SumabundantList.Contains(sum)==false) {
                        SumabundantList.Add(sum);
                        Console.Write(sum + " ");
                        
                    }
                    sum = 0;
                }
                count--;
            }

            return SumabundantList;
        }
    }
}
