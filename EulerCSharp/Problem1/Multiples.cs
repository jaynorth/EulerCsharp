using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Multiples
    {

        public static int SumOfMultiples(int a, int b, int c) {//a is number 1, b is number 2, c is limit
            int sum = 0;
           
            List<int> listmultiples = new List<int>();
            //bool existsInList;

            for (int i=a; i<c; i=i+a)
            {
                //Console.Write(i + " ");
                listmultiples.Add(i);
            }

            for (int i = b; i < c; i = i + b) {
                if (listmultiples.Contains(i)==false) {

                    listmultiples.Add(i);
                }
            }

            sum = listmultiples.Sum();

            return sum;
        }

    }
}
