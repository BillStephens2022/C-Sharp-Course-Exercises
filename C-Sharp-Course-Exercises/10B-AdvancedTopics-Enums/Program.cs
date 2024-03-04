using System;

namespace C_Sharp_Course_Exercises._10B_AdvancedTopics_Enums
{
    // Enums are typically set up at the 'namespace' level so they can be used throughout the namespace.
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    internal class Program
    {
        static void Main(string[] args)
        {
            Day fri = Day.Fri;
            Day sun = Day.Sun;
            Day a = Day.Fri;

            Console.WriteLine(fri == a); // Check to see if they are the same since they are both assigned to the same value (Day.Fri).

            Console.WriteLine("Printing Day.Mon: " + Day.Mon);
            Console.WriteLine("Printing variable 'sun': " + sun);
        }
    }
}