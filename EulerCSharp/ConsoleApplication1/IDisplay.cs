using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Display
{
    public interface IDisplay
    {

        string ProblemTitle { get; set; }
        string ProblemHeader { get; set; }
        string Description { get; set; }
        void DisplayHeader();
        void DisplayAnswer(string text, int answer);

    }
}
