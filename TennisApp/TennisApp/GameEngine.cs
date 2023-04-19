using System;
using System.Linq;
using System.Security.Cryptography;

namespace TennisApp
{
    public class PlayerObject
    {
        public string Name;
        public int Score;
    }

    public class GameEngine
    {
        public PlayerObject PlayerOne;
        public PlayerObject PlayerTwo;

        public PlayerObject Winner;

        public PlayerObject[] Players;
        public GameEngine(string playerOneName, string playerTwoName)
        {
            PlayerOne = new PlayerObject()
            {
                Name = playerOneName,
                Score = 0
            };
            PlayerTwo = new PlayerObject()
            {
                Name = playerTwoName,
                Score = 0
            };
            
            Players = new PlayerObject[] {PlayerOne, PlayerTwo};
        }

        public void PlayRound(string winnerName)
        {
            if (Winner != null)
            {
                throw new InvalidOperationException();
            }
            var roundWinner = Players.FirstOrDefault(x => x.Name == winnerName);
            var roundLoser = Players.FirstOrDefault(x => x.Name != winnerName);
            roundWinner!.Score += 1;

            if (roundWinner.Score >= 4 && roundWinner.Score - roundLoser.Score >= 2)
            {
                Winner = roundWinner;
            }
        }

    }
}