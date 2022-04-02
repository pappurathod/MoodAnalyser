using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserSpace
{
    public class MoodAnalysers
    {
        public MoodAnalysers()
        {

        }

        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
    }
}
