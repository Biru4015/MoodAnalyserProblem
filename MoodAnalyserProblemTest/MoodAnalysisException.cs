using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblemTest
{ 
    /// <summary>
    /// This class contains code of mood analyser custom exception
    /// </summary>
    public class MoodAnalysisException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            Error_in_Object_Creation,
            Wrong_Input,
            Instance_gneration_exception,
        }

        public MoodAnalysisException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
