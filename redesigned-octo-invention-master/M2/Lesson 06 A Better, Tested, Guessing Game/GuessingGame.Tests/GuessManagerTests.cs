using NUnit.Framework;
using GuessingGame.BLL;

namespace GuessingGame.Tests
{
    [TestFixture]
    public class GuessManagerTests
    {
        [Test]
        public void InvalidGuessTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start();

            GuessResult actual = gameInstance.ProcessGuess(152);
            Assert.AreEqual(GuessResult.Invalid, actual);
        }

        [Test]
        public void HigherGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(8);
            Assert.AreEqual(GuessResult.Higher, actual);
        }

        [Test]
        public void LowerGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(12);
            Assert.AreEqual(GuessResult.Lower, actual);
        }

        [Test]
        public void VictoryGuessResultTest()
        {
            GameManager gameInstance = new GameManager();
            gameInstance.Start(10);

            GuessResult actual = gameInstance.ProcessGuess(10);
            Assert.AreEqual(GuessResult.Victory, actual);
        }
    }
}
