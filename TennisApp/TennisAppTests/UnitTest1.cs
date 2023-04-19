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
            var game = new GameEngine("test1", "test2");
            
            Assert.AreEqual(game.PlayerOne.Score, game.PlayerTwo.Score);
            Assert.AreEqual(0, game.PlayerOne.Score);
        }
    }
}