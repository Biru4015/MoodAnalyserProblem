using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblemTest
{
    public class MoodAnalyser
    {

        String message;

        public MoodAnalyser()
        {
        }

        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        public String moodAnalyseMethod()
        {
            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
