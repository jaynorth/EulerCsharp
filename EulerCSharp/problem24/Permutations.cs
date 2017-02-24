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

        public static List<string> LexographicList = new List<string>();

        public static List<string> LexicographicOrderPermutations(string[] array) {
            string[] sequenceArray = array;
            
            int length = sequenceArray.Length;
            int k=-1;
            int l = -1;
            string temp;
            string sequence="";



            for (int i = length - 1; i > 0; i--) {
                if (int.Parse(sequenceArray[i - 1]) < int.Parse(sequenceArray[i])) {
                    k =i-1;
                    for (int j = length - 1; j >k; j--) {
                        if (int.Parse(sequenceArray[j]) > int.Parse(sequenceArray[k])) {
                            l = j;
                            temp = sequenceArray[l];
                            sequenceArray[l] = sequenceArray[k];
                            sequenceArray[k] = temp;
                            
                            sequenceArray = ReverseArrayFromK(sequenceArray, k);
                      
                            foreach (string item in sequenceArray)
                            {
                                sequence += item;
                            }
                            LexographicList.Add(sequence);
                            if (LexographicList.Count == 1000000) {
                                Console.Write("one million:" + sequence);
                                break;
                            }
                            sequence = "";
                            LexicographicOrderPermutations(sequenceArray);
                        }
                    }
                }
                else {
                    //Console.WriteLine("no k index found. Last Permutation?");
                    break;
                    return LexographicList;
                }
                
            }
            
            
            return LexographicList;
                

        }

        public static string[] ReverseArrayFromK(string[] sequenceArray, int k)
        {
            int length = sequenceArray.Length;
            int count = 0;
            string[] tempArray = new string[length-(k+1)];
            for (int i = k + 1; i < length; i++) {
                tempArray[count] = sequenceArray[i];
                count++;
            }
            Array.Reverse(tempArray);
            count = 0;
            for (int i = k + 1; i < length; i++)
            {
                sequenceArray[i] = tempArray[count];
                count++;
            }

            return sequenceArray;
        }

        public static void DisplayList(List<string> list) {
            int count = 2;
            foreach (string item in list) {
                Console.WriteLine("Permutation {1}: {0} ", item,count);
                count++;
            }
        }
    }
}
