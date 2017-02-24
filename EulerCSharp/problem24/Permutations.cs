using problem20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem24
{
    class Permutations

    {
        public static int FindK(int[] items)
        {
            int length = items.Length;
            int k=0;
            for (int i = length - 2; i >= 0; i--)
            {

                if (items[i] < items[i + 1])
                {  
                    
                    k = i;
                    return k;
                }

                k = -1;
            }

            return k;
        }

        public static int FindL(int[] items, int k)
        {
            int length = items.Length;
            int l = 0;
            int j = length - 1;

            while (items[j] > items[k]==false) {
                j--;
            }

            l = j;

            return l;
        }

        public static void SwapValues(int k, int l, int[] array)
        {
            int temp = array[k];
            array[k] = array[l];
            array[l] = temp;
        }

        public static int[] ReverseSeq(int[] array , int k)
        {
            int length = array.Length;
            int start = k + 1;
            int size = length - (k + 1);
            int count = 0;
            int[] reverse = new int[size];
            for (int i=0; i<size; i++) {
                reverse[i] = array[start + i];
            }
            Array.Reverse(reverse);
            for (int i = start; i <length; i++)
            {
                array[i] = reverse[count];
                count++;
            }



            return array;
        }

        public static int[] ReverseSubArray(int[] array, int k)
        {
            int length = array.Length;
            int start = k + 1;
            int count = 0;

            string s = "";
            for (int i = k+1; i < array.Length; i++) {
                s += array[i];
            }
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            for (int j = k + 1; j < array.Length; j++)
            {
                array[j] = charArray[count];
                count++;
            }

            return array;
        }

        public static void DisplayArray(int[] array) {
            foreach (int item in array) {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}