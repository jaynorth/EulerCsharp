using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string day;
            for (int j = 1901; j <= 2000; j++)
            {
                for (int i = 1; i <= 12; i++)
                {
                    DateTime date1 = new DateTime(j, i, 1);
                    day = date1.DayOfWeek.ToString();
                    if (day == "Sunday") { count++; }

                }
            }
           

            Console.WriteLine("count : " + count);
            Console.ReadKey();


        }
    }
}
