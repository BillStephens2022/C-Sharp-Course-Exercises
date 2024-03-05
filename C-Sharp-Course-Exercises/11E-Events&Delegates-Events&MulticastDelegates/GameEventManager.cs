using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11E_Events_Delegates_Events_MulticastDelegates
{
    internal class GameEventManager
    {
        // a new delegate type called GameEvent
        public delegate void GameEvent();

        // create two delegate variables called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        // a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            // check if OnGameStart event is not empty,
            // meaning that other methods have already subscribed to it
            if (OnGameStart != null)
            {
                // print a simple message
                Console.WriteLine("The game has started...");
                // call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        // a static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            // check if OnGameOver event is not empty,
            // meaning that other methods have already subscribed to it
            if (OnGameOver != null)
            {
                // print a simple message
                Console.WriteLine("The game has ended...");
                // call the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
