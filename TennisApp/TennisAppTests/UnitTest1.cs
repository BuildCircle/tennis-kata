using System.Resources;
using NUnit.Framework;
using TennisApp;

namespace TennisAppTests
{
    public class Tests
    {
        public GameEngine Game;
        [SetUp]
        public void Setup()
        {
            Game = new GameEngine("test1", "test2");
        }

        [Test]
        public void Given_TwoPlayersArePlaying_When_TheGameStarts_Then_TheirScoresShouldBeZero()
        {

            Assert.AreEqual(Game.PlayerOne.Score, Game.PlayerTwo.Score);
            Assert.AreEqual(0, Game.PlayerOne.Score);
        }
        
        [Test]
        public void Given_TwoPlayersArePlaying_When_ARoundIsCompleted_Then_TheWinnersScoreShouldIncrease()
        {
            Game.Play(Game.PlayerOne.Name);
            
            Assert.AreEqual(1, Game.PlayerOne.Score);
        }

        [Test]
        public void Given_APlayerWinsARound_And_HasAWinningScore_Then_TheGameShouldComplete()
        {
            for (int i = 0; i < 4; i++)
            {
                Game.Play(Game.PlayerOne.Name);    
            }

            Assert.AreEqual(4, Game.PlayerOne.Score);
            Assert.AreEqual(Game.Winner, Game.PlayerOne);
        }
    }
}