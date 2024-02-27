using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._01_DataTypes_Variables
{
    internal class Variables
    {
        public static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            // implicit conversion
            int num = 54522154;
            long bigNum = num;  // assigned an int to a long - implicit conversion

            // explicit conversion
            // cast double to int
            float myFloat = 13.37f;
            int myInt = (int)myFloat;  // casting a float to an int

            double myDouble = 13.37;
            int myInt2;
            myInt2 = (int)myDouble;    // casting a double to an int

            // type conversion
            string myString = myDouble.ToString();
            string myString2 = myFloat.ToString();

            bool sunIsShining = true;
            string sunIsShiningString = sunIsShining.ToString();

            Console.WriteLine("myInt: " + myInt);
            Console.WriteLine("bigNum: " + bigNum);
            Console.WriteLine("myString from double: " + myString);
            Console.WriteLine("myString from float: " + myString2);
            Console.WriteLine("Sun is Shining? " + sunIsShiningString);

            // Constants - declaring - note that upper snake case is used for constant names
            const double PI = 3.14159265359; // declaring a single constant, include the type (i.e. double, int, string, bool,etc).
            const int WEEKS = 52, MONTHS = 12;  // declaring multiple constants on one line
            const string MY_BIRTHDAY = "August 14, 2002"; // a constant string





            Console.Read();
        }
    }
}
