using System;

namespace MoodAnalyserMSTest
{
    public class Tests
    {

        MoodAnalyserFactory moodAnalyserFactory;
        [SetUp]
        public void Setup()
        {
            moodAnalyserFactory = new MoodAnalyserFactory();

        }

        /// <summary>
        /// TC-4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserMSTest.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-4.2 Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            string expected = "Class not found";
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-4.3 Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            string Message = null;
            string expected = "Method not found";
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalysr.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        //TC-5.1 GivenMosdAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor
        [Test]
        public void GivenMosdAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalysr.Mood", "Mood");
            expected.Equals(obj);
        }
        /// TC-5.2  Given MoodAnalyse Class Name When Improper Should Throw Exception
        
        [Test]
        public void MoodAnalyserClassName_WhenImproper_UsingParametrizedConstructor_ShouldThrowExcpetion()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDay12.Mood", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// TC-5.3  Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
       
        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_UsingParametrizedConstructor_ShouldThrowExcpetion()
        {
            string expected = "Constcructor not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserDay12.MoodAnalyser", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }       
        /// TC-6.1  Given Happy Message Using Using Reflector When Proper Should Return Hppy Name Should Return MoodAnalyser Object
       
        [Test]
        public void GivenHppyMessge_Proper_ShouldReturnHppy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "AnalyserMood");
            Assert.AreEqual(expected, mood);
        }        
        /// TC-6.2  Given Happy Message Using Using Reflector When ImProper Method Should Return Hppy Name Should Throw Exception
        
        [Test]
        public void GivenHppyMessge_WhenIMProperMethod_ShouldThrowException()
        {
            string expected = "Constructor not found";
            try
            {
                string mood = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "Analyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }        
        /// TC-6.2  Given Happy Message Using Using Reflector When ImProper Method Should Return Hppy Name Should Throw Exception
        
        [Test]
        public void GivenHppyMessge_WhenIMProperMethod_Should_ThrowException()
        {
            string expected = "Constcructor not found";
            try
            {
                string mood = MoodAnalyserFactory.InvokeAnalyseMood("HAPPY", "Analyser");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}