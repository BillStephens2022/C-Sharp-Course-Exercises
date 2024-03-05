using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11E_Events_Delegates_Events_MulticastDelegates
{
    internal class Player
    {
        // Player name property
        public string PlayerName { get; set; }
        
        // constructor
        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        // at the start of the game, spawn the player
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID: {PlayerName}");
        }

        // when the game is over, remove the player from the game
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID: {PlayerName}");
        }
    }
}
