using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._01_DataTypes_Variables
{
    internal class Strings
    {
        static void Main(string[] args)
        {
            int age = 32;
            string name = "Bill";
            string job = "C# Developer";

            // 1. String concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Helly my name is " + name + ", I am " + age + " years old");

            // 2. String formatting
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old.  I am currently seeking a role as a {2}.", name, age, job);

            // 3. String interpolation
            // string interpolation uses $ at the start which will allow us to write our
            // variables like this {variable name}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.  I am currently seeking a role as a {job}.");


            // 4. Verbatim strings
            // verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"skakfd jal fjdksjfsljf sljfl fjsklfj sdklfjklsfj asjkl \n dkjafkdsjfakl
                                afjdkafjdkla
                                    adkjakfdjask
                                        dskafjdskafjdskjfdksjf  fjdkafj dkajfld jfdkalfjdklfjkljfadklfj js fajslj;");

            Console.WriteLine(@"C:\User\two4o\Desktop\C# Developer\Strings\Program.cs");  // note: don't need to use escape characters when printing backslashes

            // String Methods

            string stringMailbox = "mailbox";
            string stringNeedsTrimming = "     I need a trim.                     ";
            string substringMail = stringMailbox.Substring(0, 4);
            Console.WriteLine("substring method: " + substringMail);
            Console.WriteLine("uppercase: " + stringMailbox.ToUpper());
            Console.WriteLine("lowercase: " + stringMailbox.ToLower());
            Console.WriteLine("trimmed: " + stringNeedsTrimming.Trim());
            Console.WriteLine("index of box inside mailbox: " + stringMailbox.IndexOf("box"));
            string firstName = "Bill";
            string lastName = "Stephens";
            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine("fullName: " + fullName);
            string formattedString = String.Format("My name is {0}", firstName);
            Console.WriteLine("formatted string: " + formattedString);

            // using backslash to escape characters
            string s1 = "This is a string with a \"slash\" / and a backslash \\ and a colon: ";
            Console.WriteLine(s1);

            Console.Read();
        }
    }
}
