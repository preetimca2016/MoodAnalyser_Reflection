using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyserCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            NO_SUCH_CONSTRUCTOR,
            EMPTY_MESSAGE,
            NULL_MESSAGE,
        }

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
