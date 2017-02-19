using Display;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem11
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayScreen pb11display = new DisplayScreen();
            pb11display.ProblemTitle = "Problem 11";
            pb11display.ProblemHeader = "Largest product in a grid";
            pb11display.Description = "In the 20×20 grid below, four numbers along a diagonal line have been marked in red.\nThe product of these numbers is 26 × 63 × 78 × 14 = 1788696.\nWhat is the greatest product of four adjacent numbers in the same direction(up, down, left, right, or diagonally) in the 20×20 grid ? ";
            pb11display.DisplayHeader();

            //////////////////////////////////////////////////////////////////
            // Creating Text File with grid
            // grid.txt
            // moved it to bin/debug
            
            string filePath = @"grid.txt"; 
            StreamReader sr = new StreamReader(filePath);

            string[,] grid = Grid.PopulateArrayFromStream2D(20, sr);
            
            Grid.DisplayGrid(grid);
            //Console.WriteLine(grid[2, 2]);

            long productRight = Grid.BiggestProductRight(grid, 4);
            Console.WriteLine("\nProduct is :" + productRight);
            long productDown = Grid.BiggestProductDown(grid, 4);
            Console.WriteLine("\nProduct is :" + productDown);


            sr.Close();
            // pb11display.DisplayAnswer("Prime number " + order + " is  :", result);

            pb11display.DisplayFooter();
            Console.ReadKey();
        }
    }
}
