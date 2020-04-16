using DotLiquid.Tags;
using DotLiquid.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;
using System.Transactions;

namespace MoodAnalyserProblem
{
    public class MoodAnalysisException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY
        }

        public MoodAnalysisException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}