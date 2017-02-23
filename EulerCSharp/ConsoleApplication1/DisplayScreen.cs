using System;

namespace Display
{
    public class DisplayScreen : IDisplay
    {
        DateTime t1;
        public DisplayScreen()
        {
            t1 = DateTime.Now;
            Console.BufferHeight = short.MaxValue - 1; // ***** Alters the BufferHeight *****
                                                       // Console.BufferWidth = short.MaxValue - 1;
            //Console.WindowWidth = 500;
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value;} 
        }


        private string _problemTitle;
        public string ProblemTitle
        {
            get { return _problemTitle; }
            set
            {
                _problemTitle= value.ToUpper();
            }
        }

        private string _problemHeader;

        public string ProblemHeader
        {
            get { return _problemHeader; }
            set { _problemHeader = value.ToUpper(); ; }
        }


        public void DisplayHeader( ) {
            Console.SetWindowSize(100, 40);
            
            
            Console.WriteLine("{0}\n",ProblemTitle   );
          
            string s = new string('#', ProblemHeader.Length + 6);
            Console.WriteLine(s);
            
            Console.WriteLine("#  {0}  #", ProblemHeader);
            
            Console.WriteLine(s);

            Console.WriteLine("\n");
            string d = new string('*', 100);
            
            Console.WriteLine(d);
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}\n",Description );
            Console.ResetColor();
            Console.WriteLine(d);
            


        }

       

        public void DisplayAnswer(string text, int answer ) {

            Console.WriteLine(text + " " + answer);
        }

        public void DisplayAnswer(string text, long answer)
        {

            Console.WriteLine(text + " " + answer);
        }

        public void DisplayFooter() {
            DateTime t2 = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tTimer : " + (t2 - t1));
            Console.ResetColor();
        }
    }
}
