using NUnit.Framework;
using TennisApp;

namespace TennisAppTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_TwoPlayersArePlaying_When_TheGameStarts_Then_TheirScoresShouldBeZero()
        {
            var game = new GameEngine();
            
            Assert.AreEqual(game.PlayerOneScore, game.PlayerTwoScore);
            Assert.AreEqual(0, game.PlayerOneScore);
        }
    }
}