using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOOD_ANALYSER
{
    public class MoodAnalyser
    {
        string message;

        public MoodAnalyser()
        {
            message = "";
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Analyses the mood.
        /// </summary>
        public string AnalyseMood()
        {
            if (message.Contains("Sad", StringComparison.OrdinalIgnoreCase) is true)
                return "Sad";
            return "Happy";
        }


    }
}
