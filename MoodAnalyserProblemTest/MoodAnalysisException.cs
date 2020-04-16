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
            NULL_EXCEPTION, EMPTY_EXCEPTION
        }

        public MoodAnalysisException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
