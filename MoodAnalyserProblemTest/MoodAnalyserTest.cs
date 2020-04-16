using NUnit.Framework;
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

        private String message;
        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        public String MoodAnalysisMethod()
        {
            try
            {
                if (message.Length == 0)
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_EXCEPTION, "Please Enter Value..Mood Cant be NULL");
                else if (message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_EXCEPTION, "Please Enter Value..Mood Cant be NULL");
            }
        }
     }
}