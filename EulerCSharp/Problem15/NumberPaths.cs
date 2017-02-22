using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class NumberPaths
    {
        public static long[,] CalculateNumberOfPaths(int rows, int columns)
        {

            rows = rows + 1;//number of nodes is row+1
            columns = columns + 1;//number of nodes is colum+1
            long[,] gridTable = new long[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                //initializing table with base values, all the immediate borders from the starthave only 1 possible paths

                gridTable[0, i] = 1;
                gridTable[i, 0] = 1;
            }

            for (int row = 1; row < columns; row++)
            {
                for (int column = 1; column < columns; column++)
                {
                    gridTable[row, column] = gridTable[row - 1, column] + gridTable[row, column - 1];
                    //The values are from adding the previous values from the table of possible paths to the previous node
                }
            }

            return gridTable;

        }
    }
}
