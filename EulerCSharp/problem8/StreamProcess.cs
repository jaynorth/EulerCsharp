using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    class StreamProcess
    {

        public static void DisplayFile(string filePath) {

            try
            {
                StreamReader sr = new StreamReader(filePath);//Insert text file in \bin\debug folder
                string line = sr.ReadLine();
                //Console.WriteLine(line);
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();

                }
                sr.Close();//closing file
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was an error, probably with file name or location: " + ex.Message);
            }
            
            

        }

        public static string ConvertToString(StreamReader a) {

            
            string sequence = "";
            string line = a.ReadLine();

            while (line != null)
            {
                sequence += line;
                line = a.ReadLine();

            }
            a.Close();//closing file

            return sequence;
        }
    }
}
