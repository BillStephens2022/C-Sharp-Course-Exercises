using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._05_Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================= FOR LOOPS ========================");
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
            }
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter);
            }
            for (int counter = 10; counter > 0; counter--)
            {
                Console.WriteLine(counter);
            }
            for (int counter = 0; counter <= 20; counter += 2)
            {
                Console.WriteLine(counter);
            }
            for (int counter = 0; counter <= 20; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
            }
            Console.WriteLine("======================= DO WHILE LOOPS ========================");
            int counter2 = 0;
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine(counter2);
                counter2++;
            } while (counter2 <= 5);
            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;


            } while (lengthOfText < 20);
            Console.WriteLine("Thanks that was enough!" + wholeText);


            Console.WriteLine("========================= WHILE LOOPS =========================");
            int counter3 = 0;
            while (counter3 < 10)
            {
                Console.WriteLine(counter3);
                counter3++;
            }
            Console.WriteLine("END of 1st while loop");
            string keyPress = "";
            int counter4 = 0;
            while (keyPress.Equals(""))
            {
                Console.WriteLine("Press enter to update people counter, press any other key to end:");
                keyPress = Console.ReadLine();
                counter4++;
                Console.WriteLine("The current people count is: {0}", counter4);

            }
            Console.WriteLine("The final count is: {0}", counter4);
            Console.Read();
        }
    }
}
