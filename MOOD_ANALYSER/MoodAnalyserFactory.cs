using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MOOD_ANALYSER
{
    public  class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyserObject(string className, string constructorName, string message = "")
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Type moodAnalyseType = Type.GetType(className);
                    if (message == "")
                        return Activator.CreateInstance(moodAnalyseType);
                    return Activator.CreateInstance(moodAnalyseType, message);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Your input is not valid");
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }
            }
            else
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            return null;
        }
    }
}
