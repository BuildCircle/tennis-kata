using System;
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
            Game.PlayRound(Game.PlayerOne.Name);
            
            Assert.AreEqual(1, Game.PlayerOne.Score);
        }

        [Test]
        public void Given_APlayerWinsARound_And_HasAWinningScore_Then_ThatPlayerShouldWinTheGame()
        {
            for (int i = 0; i < 4; i++)
            {
                Game.PlayRound(Game.PlayerOne.Name);    
            }

            Assert.AreEqual(4, Game.PlayerOne.Score);
            Assert.AreEqual(0, Game.PlayerTwo.Score);
            Assert.AreEqual(Game.Winner, Game.PlayerOne);
        }
        
        [Test]
        public void Given_BothPlayersAreMatchingOnFourWinsEach_When_APlayerWinsARound_Then_TheGameShouldContinueWithoutAWinner()
        {
            for (int i = 0; i < 4; i++)
            {
                Game.PlayRound(Game.PlayerOne.Name);    
                Game.PlayRound(Game.PlayerTwo.Name);    
            }
            Game.PlayRound(Game.PlayerOne.Name);

            Assert.AreEqual(5, Game.PlayerOne.Score);
            Assert.AreEqual(4, Game.PlayerTwo.Score);
            Assert.AreEqual(Game.Winner, null);
        }
        
        [Test]
        public void Given_APlayerWinsARound_AndIsTwoPointsAboveTheirOpponent_ButDoesNotHaveAWinningScore_Then_TheyShouldNotWin()
        {
            for (int i = 0; i < 2; i++)
            {
                Game.PlayRound(Game.PlayerOne.Name);    
            }

            Assert.AreEqual(2, Game.PlayerOne.Score);
            Assert.AreEqual(0, Game.PlayerTwo.Score);
            Assert.AreEqual(Game.Winner, null);
        }
        
        [Test]
        public void Given_APlayerHasWon_When_ARoundIsPlayed_TheGameShouldNotAllowTheRoundToBePlayed()
        {
            for (int i = 0; i < 4; i++)
            {
                Game.PlayRound(Game.PlayerOne.Name);
            }

            Assert.AreEqual(Game.Winner, Game.PlayerOne);
            Assert.Throws<InvalidOperationException>(() => Game.PlayRound(Game.PlayerOne.Name));
        }
    }
}