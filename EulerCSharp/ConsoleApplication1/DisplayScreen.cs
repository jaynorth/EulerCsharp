using System;

namespace Display
{
    public class DisplayScreen : IDisplay
    {

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
            //Console.SetWindowSize(80, 40);
            Console.WriteLine(ProblemTitle );
            Console.WriteLine();
            Console.WriteLine(ProblemHeader);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine(Description);
            Console.WriteLine("*********************************************************************************");

        }

        public void DisplayAnswer(string text, int answer ) {

            Console.WriteLine(text + " " + answer);
        }
    }
}
