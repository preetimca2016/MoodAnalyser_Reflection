using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserMSTest
{
    public class MoodAnalyser
    {
        public string Message;
        public string SAD;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string message)
        {
            Message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.Message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE,"Mood Should Not be Empty");
                }
                if (this.Message.Contains("SAD"))
                {
                    return SAD;
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not be Null");
            }
        }
    }
}
