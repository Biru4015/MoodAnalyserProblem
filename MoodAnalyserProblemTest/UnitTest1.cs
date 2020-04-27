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
        public void givenSadMesaage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I am sad in sad mood");
            Assert.AreEqual("SAD", mood.MoodAnalysisMethod());
        }

        /// <summary>
        /// Purpose of this method is when mood is happy it returns happy
        /// </summary>
        [Test]
        public void givenHappyMesaage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in any mood");
            Assert.AreEqual("HAPPY", mood.MoodAnalysisMethod());
        }

        /// <summary>
        /// Purpose of this method is when gievn null it return happy
        /// </summary>
        [Test]
        public void givenNullMessage_WhenAnalyse_shouldReturnsHappy()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);
                mood.MoodAnalysisMethod();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NULL_EXCEPTION, e.type);
            }
        }

        /// <summary>
        /// Test case 3.1
        /// </summary>
        [Test]
        public voidgivenEmptyMessage_WhenAnalyse_shouldReturnsEmptyMoodException()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser("");
                mood.MoodAnalysisMethod();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.EMPTY_EXCEPTION, e.type);
            }
        }

        /// <summary>
        /// Test case 3.2
        /// </summary>
        [Test]
        public void givenNullMessage_WhenAnalyse_shouldReturnsNullMoodException()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);
                mood.MoodAnalysisMethod();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NULL_EXCEPTION, e.type);
            }
        }

        /// <summary>
        /// Test case 4.1
        /// </summary>
        [Test]
        public void givenMoodAnalserObject_WhenAnalyse_shouldReturnsMoodAnalyserObject()
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
        public void givenWrongClassName_WhenAnalyse_shouldReturnsClassNotFoundException()
        {
            try
            {
                MoodAnalyesrFactory<MoodAnalyser> obj_mood = new MoodAnalyesrFactory<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor();
                object obj_compare = obj_mood.GetInstance("MoodAnalyser", constructorInfo);

            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, e.type);
            }
        }

        /// <summary>
        /// Test case 4.3
        /// </summary>
        [Test]
        public void givenWrongClassName_WhenAnalyse_shouldReturnsClassNotFoundException()
        {
            try
            {
                MoodAnalyesrFactory<MoodAnalyser> obj_mood = new MoodAnalyesrFactory<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor();
                object obj_compare = obj_mood.GetInstance("MoodAnalyser", constructorInfo);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, e.type);
            }
        }

        /// <summary>
        /// Test case 5.1 Comparing object using paramterized constructor
        /// </summary>
        [Test]
        public void givenObject_WhenAnalyse_shouldReturnsObject()
        {
            MoodAnalyesrReflecotr<MoodAnalyser> obj_mood = new MoodAnalyesrReflecotr<MoodAnalyser>();
            ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor(1);
            object obj_compare = obj_mood.GetParameterizedInsatance("MoodAnalyser", constructorInfo, "I am in Sad Mood");
            MoodAnalyser mood = new MoodAnalyser("I am in Sad Mood");
            Assert.AreEqual(mood, obj_compare);
        }

        /// <summary>
        /// Test case 5.2 comparing the class and throw no such class exception
        /// </summary>
        [Test]
        public void givenWrongClassName_WhenAnalyse_shouldReturnsClassNotFoundException()
        {
            try
            {
                MoodAnalyesrReflecotr<MoodAnalyser> obj_mood = new MoodAnalyesrReflecotr<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor(1);
                object obj_compare = obj_mood.GetParameterizedInsatance("MoodAnalysers", constructorInfo, "MoodAnalysis");

            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, e.type);
            }
        }

        /// <summary>
        /// Test case 5.3 comparing the method and throw no such method
        /// </summary>
        [Test]
        public void givenWrongMethodName_WhenAnalyse_shouldReturnsMethodNotFoundException()
        {
            try
            {
                MoodAnalyesrReflecotr<MoodAnalyser> obj_mood = new MoodAnalyesrReflecotr<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor(1);
                object obj_compare = obj_mood.GetParameterizedInsatance("MoodAnalyser",constructorInfo,"MoodAnalysis");

            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, e.type);
            }
        }

        /// <summary>
        /// TestCse_6.1
        /// Invokes the method using reflection should return happy.
        /// </summary>
        [Test]
        public void givenMoodAnalserMethod_WhenAnalyse_shouldReturnsHappy()
        {
            try
            {
                MoodAnalyesrReflecotr<MoodAnalyser> obj_mood = new MoodAnalyesrReflecotr<MoodAnalyser>();
                string actual = obj_mood.InvokeMoodAnalyser();
                string Expected = "HAPPY";
                Assert.AreEqual(actual, Expected);
            }
            catch(NullReferenceException e)
            {
                _ = e.StackTrace;
            }
        }

        /// <summary>
        /// Test Case 6.2
        /// Invoke the method using reflection and returns no such method
        /// </summary>
        public void givenWrongMethodName_WhenAnalyse_shouldReturnsMethodNotFoundException()
        {
            try
            {
                MoodAnalyesrReflecotr<MoodAnalyser> obj_mood = new MoodAnalyesrReflecotr<MoodAnalyser>();
                ConstructorInfo constructorInfo = obj_mood.GetDefaultConstructor();
                object obj_compare = obj_mood.GetParameterizedInsatance("MoodAnalyser", constructorInfo, "MoodAnalysis");

            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, e.type);
            }
        }
    }
}
