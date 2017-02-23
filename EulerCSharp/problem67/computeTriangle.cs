using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem67
{
    class computeTriangle
    {

        public static void CompareTriangle(int[,] triangleArray, int pathSteps) {
            
            int count = 1;
            int a, b;


            //int row = 0, column = 0;
            for (int row = 1; row < pathSteps; row++)
            {
                count++; 
                triangleArray[row, 0] += triangleArray[row - 1, 0];
                triangleArray[row, row] += triangleArray[row - 1, row - 1];
                if (count > 2) {
                    for (int j = 1; j <= count - 2; j++) {
                        a = triangleArray[row, j] + triangleArray[row - 1,j-1] ;
                        b = triangleArray[row, j] + triangleArray[row - 1,j];
                        if (a > b)
                        {
                            triangleArray[row, j] = a;
                        }
                        else {
                            triangleArray[row, j] = b;
                        }
                    }
                    
                }

             
            }

            Console.WriteLine("final array with modified values:");
            
            DisplayArray(triangleArray, pathSteps);
            Console.WriteLine("max value is : " + findMaxValue(triangleArray, pathSteps));


        }
        public static void DisplayArray(int[,] triangleArray, int pathSteps) {
            int rows = pathSteps;
            int columns = pathSteps;
            Console.WriteLine("***********************************\n");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (triangleArray[i, j] != 0)
                    {

                        Console.Write(triangleArray[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************\n");
        }

        public static int findMaxValue(int[,] triangleArray, int steps) {
            int max=0;
            int rows = steps;
            int columns = steps;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (triangleArray[i, j] >max)
                    {

                        max = triangleArray[i, j];
                    }

                }
                
            }

            return max;
        }
    }
}
