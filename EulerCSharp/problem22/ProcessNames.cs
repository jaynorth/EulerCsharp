using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem22
{
    class ProcessNames
    {

        public static long score { get; private set; } = 0;//default value = 0

        public static string[] FileToArray(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string names = sr.ReadToEnd();
            int count = 0;
            
            string[] namesArray = names.Split(',');
            foreach (string name in namesArray) {
                namesArray[count] = name.Trim('"');
                count++;
            }
            sr.Close();
            return namesArray;
        }

        public static void SortByAlphabet(string[] namesArray)
        {
            Array.Sort(namesArray);
            //DisplayValues(namesArray);
        }

        public static void DisplayValues(String[] arr)
        {
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0);
                  i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, arr[i]);
            }
            Console.WriteLine();
        }


        public static char[] CreateAlphabetArray() {
            char[] alphabetArray = new char[27];
            int count = 1;
            for (char a = 'A'; a <= 'Z'; a++)
            {
                alphabetArray[count]=a;
                count++;
            }
            return alphabetArray;
        }


        public static void NameScore(int alphaValue, int positionValue)
        {
            ProcessNames.score += alphaValue * positionValue; 
        }


        public static int GetNameAlphaPosition(string[] namesArray,string name)
        {
           int position = Array.IndexOf(namesArray, name);
            position++;// to compensate starting from 0 index

            return position;
        }

        public static int GetNameAlphaValue(string name)
        {
            char[] alphabet = CreateAlphabetArray();
            int alphabeticalValue;
            int score = 0;
            char n;
            name=name.ToUpper();
            

            for (int i = 0; i < name.Length; i++) {
                n = name[i];
             
                alphabeticalValue = Array.IndexOf(alphabet, n);
                //Console.WriteLine("alphabetical value for {0} is {1}", n, alphabeticalValue);
                score += alphabeticalValue;
            }

            return score;
        }
    }
}
