using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MoodAnalyserProblemTest;

namespace MoodAnalyserProblemTest
{
    /// <summary>
    /// This class contains the code of mood analyser test
    /// </summary>
    public class MoodAnalyser
    {
        String message;
        // <summary>
        /// Mood analysis default constructor to create instace of the class
        /// </summary>
        public MoodAnalyser()
        {
            this.message = "I am in SAD mood";
        }

        /// <summary>
        /// MoodAnalysis constructor for initlize message variable
        /// </summary>
        /// <param name="in_message"></param>
        public MoodAnalyser(String in_message)
        {
            this.message = in_message;
        }

        /// <summary>
        /// Method to initilize message variable
        /// </summary>
        /// <param name="message"></param>
        public void MoodAnalysisMethod(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Method to return the mood analysis
        /// </summary>
        /// <param name="message"><. mood parameter >
        /// <returns></. SAD or HAPPY , type: string>
        public String MoodAnalysisMethod()
        {
            try
            {
                if (message.Length == 0)
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_EXCEPTION, "Please Enter Value..Mood Cant be Empty");
                if (message.Contains("sad",StringComparison.OrdinalIgnoreCase))
                    return "SAD";
                else if (message.Contains("HAPPY", StringComparison.OrdinalIgnoreCase)) return "HAPPY";
                else throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Wrong_Input, "Please enter proper Mood");
            }
            catch(NullReferenceException)
            {
                return "HAPPY";
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_EXCEPTION, "Please Enter Value..Mood Cant be NULL");
            }
        }

        /// <summary>
        /// This method is overrinding the MoodAnalyser method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true of false</returns>
        override
        public bool Equals(Object obj)
        {
            return this.message == ((MoodAnalyser)obj).message;
        }
    }
}