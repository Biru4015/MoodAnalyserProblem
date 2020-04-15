using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblemTest
{
    /// <summary>
    /// This class contains the code of mood analyser test
    /// </summary>
    public class MoodAnalyser
    {

        String message;

        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        public String MoodAnalyseMethod(String message)
        {
            this.message = message;
            return MoodAnalyseMethod();
        }

        /// <summary>
        /// This method is created for checking string with another string
        /// </summary>
        /// <returns>SAD|HAPPY</returns>
        public String MoodAnalyseMethod()
        {
            try
            {
                if (message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
