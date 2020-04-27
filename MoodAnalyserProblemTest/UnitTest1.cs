using NUnit.Framework;

namespace MoodAnalyserProblemTest
{
    /// <summary>
    /// This class contains the code of testing of mood analyser
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Purpose of this method is when mood is sad it returns sad
        /// </summary>
        [Test]
        public void givenSadMesaage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I am sad in sad mood");
            Assert.AreEqual("SAD", mood.MoodAnalyseMethod());
        }

        /// <summary>
        /// Purpose of this method is when mood is happy it returns happy
        /// </summary>
        [Test]
        public void givenHappyMesaage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in any mood");
            Assert.AreEqual("HAPPY",mood.MoodAnalyseMethod());
        }

        /// <summary>
        /// Purpose of this method is when gievn null it return happy
        /// </summary>
        [Test]
        public void givenNullMessage_WhenAnalse_shouldReturnsHappy()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            Assert.AreEqual("HAPPY", mood.MoodAnalyseMethod());
        }
    }
}