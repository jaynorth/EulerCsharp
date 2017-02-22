using Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using problem20;
using System.Numerics;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayScreen pb15display = new DisplayScreen();
            pb15display.ProblemTitle = "Problem 15";
            pb15display.ProblemHeader = "Lattice paths";
            pb15display.Description = "Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.\nHow many such routes are there through a 20×20 grid ? ";
            pb15display.DisplayHeader();


            //////////////////////////////////////////////////////////////////
            //The math solution would be to calculate:
            //n=rows+columns
            //nRight, nDown
            // solution = n!/nRight!*nDown!, in this case: 40!/(20!*20!)
            ///////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////
            //Below is a more general programming approach:
            //This is calle Dynamic programming, solve a smaller subproblem to write the full solution
            ///////////////////////////////////////////////////////////////////
            
            //Below are number of rows and columns for a grid
            int rows = 20;
            int columns = 20;

            //Creates table with all possible path values for each node
            long[,] gridTable = NumberPaths.CalculateNumberOfPaths(rows, columns);

            long solution = gridTable[rows, columns];//Table value of the End Node

            Console.Write("There are "+solution +" paths in this grid");

            pb15display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
