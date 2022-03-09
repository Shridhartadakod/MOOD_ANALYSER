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
            try
            {
                if (message == "")
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Mood is empty");
                if (message.Contains("Sad", StringComparison.OrdinalIgnoreCase) is true)
                    return "Sad";
                return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Mood is null");
            }
            return null;
        }
    }
}
