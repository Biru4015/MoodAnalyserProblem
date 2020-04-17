using NUnit.Framework;
using MoodAnalyserProblemTest;
using System;
using System.Reflection;

namespace MoodAnalyserProblemTest
{
    /// <summary>
    /// This class contains the code of testing of mood analyser
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Purpose of this method is when mood is sad it returns sad
        /// </summary>
        [Test]
        public void MessageWhenSadResposeTest_RetrunsSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I am sad in sad mood");
            Assert.AreEqual("SAD", mood.MoodAnalysisMethod());
        }

        /// <summary>
        /// Purpose of this method is when mood is happy it returns happy
        /// </summary>
        [Test]
        public void MessageWhenAnyMoodTest_ReturnsHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in any mood");
            Assert.AreEqual("HAPPY",mood.MoodAnalysisMethod());
        }

        /// <summary>
        /// Purpose of this method is when gievn null it return happy
        /// </summary>
        [Test]
        public void MessageNullTest_ReturnsHappy() 
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);
                mood.MoodAnalysisMethod();
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NULL_EXCEPTION,e.type);
            }
        }

        /// <summary>
        /// Test case 3.1
        /// </summary>
        [Test]
        public void EmptyMessageTest_EmptyMoodException()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser("");
                mood.MoodAnalysisMethod();
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.EMPTY_EXCEPTION,e.type);
            }
        }

        /// <summary>
        /// Test case 3.2
        /// </summary>
        [Test]
        public void NullMessageTest_NullMoodException()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);
                mood.MoodAnalysisMethod();
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NULL_EXCEPTION,e.type);
            }
        }

        /// <summary>
        /// Test case 4.1
        /// </summary>
        [Test]
        public void GivenObjectEqualsWithParameter_ReturnTrue()
        {
            MoodAnalyesrFactory<MoodAnalyser> obj_mood = new MoodAnalyesrFactory<MoodAnalyser>();
            ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor();
            object obj_compare = obj_mood.GetInstance("MoodAnalyser", constructorInfo);
            Assert.IsInstanceOf(typeof(MoodAnalyser), obj_compare);

        }

        /// <summary>
        /// Test case 4.2
        /// </summary>
        [Test]
        public void ClassWithParameterWrong_ReturnClassNotFound()
        {
            try
            {
                MoodAnalyesrFactory<MoodAnalyser> obj_mood = new MoodAnalyesrFactory<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor();
                object obj_compare = obj_mood.GetInstance("MoodAnalyser", constructorInfo);

            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS,e.type);
            }
        }

        /// <summary>
        /// Test case 4.3
        /// </summary>
        [Test]
        public void ConstructorWithParameterWrong_ReturnNoSuchMethod()
        {
            try
            {
                MoodAnalyesrFactory<MoodAnalyser> obj_mood = new MoodAnalyesrFactory<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor();
                object obj_compare = obj_mood.GetInstance("MoodAnalyser", constructorInfo);
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD,e.type);
            }
        }
    }
}