using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem11
{
    class Grid
    {
         public static string[,] PopulateArrayFromStream2D(int dimension, StreamReader sr) {
            string[,] array = new string[dimension,dimension];//for 20x20 grid
            string line ;
            //int number;
            int count;

            for(int i = 0; i< dimension; i++){
                count = 0;
                line = sr.ReadLine();
                
                string [] tab =line.Split(' ');
                foreach (string item in tab) {
                    //int element = int.Parse(item);
                    array[i, count] = item;
                    count++;
                }
                
                 //number = array[i, 1];
                //sr.ReadLine();
            }
            return array;

        }

        public static void DisplayGrid(string[,] grid) {
            int count = 0;
            foreach(string row in grid) {
                if (count % 20 == 0) { Console.WriteLine(); }
                Console.Write(row + " ");
                count++;
            }
        }

        public static long BiggestProductRight(string[,] grid, int adjacentNumbers) {
            long product = 1;
            int number;
            long biggestProduct= 0;
            int lengthRow = 20;
            for (int k = 0; k < 20; k++)
            {
                for (int j = 0; j < lengthRow - adjacentNumbers; j++)
                {
                    for (int i = j; i < adjacentNumbers + j; i++)
                    {
                        number = int.Parse(grid[k, i]);
                        product *= number;
                    }
                    if (product > biggestProduct)
                    {
                        biggestProduct = product;
                        
                    }
                    product = 1;
                }
            }
            
            return biggestProduct; 
        }

        public static long BiggestProductDown(string[,] grid, int adjacentNumbers)
        {   //table [row][colum]
            long product = 1;
            int number;
            long biggestProduct = 0;
            int lengthRow = 20;
            for (int k = 0; k < 20; k++)
            {
                for (int j = 0; j < lengthRow - adjacentNumbers; j++)
                {
                    for (int i = j; i < adjacentNumbers + j; i++)//Column
                    {
                        number = int.Parse(grid[i, k]); //by just switching k and i it does the same as lef/right to up/down
                        product *= number;
                    }
                    if (product > biggestProduct)
                    {
                        biggestProduct = product;

                    }
                    product = 1;
                }
            }

            return biggestProduct;
        }

        public static long BiggestProductDiagonalLeft(string[,] grid, int adjacentNumbers)
        {   //table [row][colum]
            long product = 1;
            int number;
            long biggestProduct = 0;
            int lengthRow = 20;
            for (int k = 0; k < lengthRow - adjacentNumbers; k++)
            {
                for (int j = 0; j <=lengthRow - adjacentNumbers; j++)
                {
                    for (int i = 0; i < adjacentNumbers; i++)
                    {
                        number = int.Parse(grid[i + j, i+k]);
                        //[0,0][1, 1][2,2][3,3]
                        //[1,0][2,1][3,2][4,3]
                        //[2, 0][3,1][4, 2][5, 3]

                        product *= number;
                    }
                    if (product > biggestProduct) { biggestProduct = product; }
                    product = 1;
                }
            }
            
            return biggestProduct;
        }


    }
}
