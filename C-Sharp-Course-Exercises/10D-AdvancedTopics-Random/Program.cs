using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._10D_AdvancedTopics_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            // simulate 10 random dice rolls
            for (int i = 0; i < 10; i++)
            {
                // .Next(1, 7) returns a non-negative random int between 1 and 6 (non inclusive upper bound)        
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }

            Console.WriteLine("The decision is: " + MakeDecision());
        }

        public static string MakeDecision()
        {
            Random yesNoMaybe = new Random();
            int randomAnswer = yesNoMaybe.Next(1, 4);

       
            if (randomAnswer == 1)
            {
                return "Yes";
            }
            else if (randomAnswer == 2)
            {
                return "No";
            } else
            {
                return "Maybe";
            }
        }
    }
}
