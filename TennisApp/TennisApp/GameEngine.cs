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
        }
    }
}