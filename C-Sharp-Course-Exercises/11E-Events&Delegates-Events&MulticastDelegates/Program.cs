using C_Sharp_Course_Exercises._11D_Events_Delegates_LambdaExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11E_Events_Delegates_Events_MulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args) 
        { 
            // create an Audio System
            AudioSystem audioSystem = new AudioSystem();
            // create a Rendering Engine
            RenderingEngine renderingEngine = new RenderingEngine();

            // create two players and give them ID's/Names
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running...Press any key to end the game");

            // pause
            Console.Read();

            GameEventManager.TriggerGameOver();

     
        }
    }
}
