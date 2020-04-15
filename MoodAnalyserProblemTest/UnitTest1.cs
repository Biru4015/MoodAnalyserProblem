using NUnit.Framework;

namespace MoodAnalyserProblemTest
{
    public class Tests
    {
        [Test]
        public void MessageWhenSadResposeTest_RetrunsSad()
        {
            MoodAnalyser mood = new MoodAnalyser("I am sad in sad mood");
            Assert.AreEqual("SAD", mood.moodAnalyseMethod());
        }

        [Test]
        public void MessageWhenAnyMoodTest_ReturnsHappy()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in any mood");
            Assert.AreEqual("HAPPY",mood.moodAnalyseMethod());
        }
    }
}