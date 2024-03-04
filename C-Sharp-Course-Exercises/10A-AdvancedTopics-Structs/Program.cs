using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Sharp_Course_Exercises._10_AdvancedTopics_Structs
{
    internal class Program
    {
        // a struct is similar to a class, however structs do not support
        // inheritance.   A struct is a 'value type', unlike a class which is a 'reference type'.
        // structs are passed by value (like integers).  They cannot have a null reference (unless
        // 'Nullable' is used. They do not have memory overhead per new instance, unless 'boxed'.

        // In summary, use structs when you need lightweight, small, and immutable data structures,
        // especially in scenarios where performance and memory efficiency are critical. Use classes
        // for more complex scenarios, where you need inheritance, mutable state, and more sophisticated
        // behavior.
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public void Display()
            {
                Console.WriteLine("Game 1's name is: {0}", name);
                Console.WriteLine("Game 1's developer is: {0}", developer);
                Console.WriteLine("Game 1's rating is: {0}", rating);
                Console.WriteLine("Game 1 was released on: {0}", releaseDate);
            }
        }
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.Display();
        }
    }
}
