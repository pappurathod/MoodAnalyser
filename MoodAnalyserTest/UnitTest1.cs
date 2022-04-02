using NUnit.Framework;
using MoodAnalyserSpace;

namespace MoodAnalyserTest
{
    public class Tests
    {
        MoodAnalysers moodAnalyser;
        [SetUp]
        public void Setup()
        {
            //Arrange
            moodAnalyser = new MoodAnalysers();
        }

        ///</summary>
        /// TC-1.1 Given "I am in Sad mood" message should return SAD
        ///</summary
        [Test]
        public void GivenMessage_ShouldReturnSad()
        {
            // Act
            string message = moodAnalyser.AnalyseMood("I am in SAD mood").ToUpper();
            // Assert
            Assert.AreEqual("SAD", message);
        }
        [Test]
        ///</summary>
        /// TC-1.2 Given "I am in Any mood" message should return HAPPY
        ///</summary>
        public void GivenAMessage_ShouldReturnHappy()
        {
            string message = moodAnalyser.AnalyseMood("I am in ANY Mood").ToUpper();
            Assert.AreEqual("HAPPY", message);
        }
    }
}