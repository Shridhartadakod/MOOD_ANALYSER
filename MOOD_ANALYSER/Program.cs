using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOOD_ANALYSER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mood analyser program:");
            MoodAnalyser mood = new MoodAnalyser("I am really sad");

            string moodStatus = mood.AnalyseMood();

            Console.WriteLine("Input Text: I am really sad");
            Console.WriteLine("Mood: " + moodStatus);


        }
    }
}
