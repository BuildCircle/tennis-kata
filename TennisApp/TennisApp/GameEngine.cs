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

        public void Play(string winnerName)
        {
            var winner = Players.FirstOrDefault(x => x.Name == winnerName);
            winner!.Score += 1;
        }

        public void CheckWinner()
        {
            
        }
    }
}