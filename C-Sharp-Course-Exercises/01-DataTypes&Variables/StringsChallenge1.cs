using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._01_DataTypes_Variables
{
    internal class StringsChallenge1
    {
        static void Main(string[] args)
        {
            string userInput;
            string searchChar;
            string firstName;
            string lastName;
            Console.WriteLine("Please enter a string: ");
            userInput = Console.ReadLine();
            Console.WriteLine("UPPERCASE: " + userInput.ToUpper());
            Console.WriteLine("lowercase: " + userInput.ToLower());
            Console.WriteLine("trimmed: " + userInput.Trim());
            Console.WriteLine("The first 3 characters are: " + userInput.Trim().Substring(0, 3));

            Console.WriteLine("Enter a character in the string you would like to search for:");
            searchChar = Console.ReadLine();
            int foundIndex = userInput.IndexOf(searchChar);
            Console.WriteLine("The index of {0} is {1}.", searchChar, foundIndex);

            Console.WriteLine("Enter a first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter a last name:");
            lastName = Console.ReadLine();
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine($"The full name is: {fullName}.");


            Console.ReadKey();
        }
    }
}
