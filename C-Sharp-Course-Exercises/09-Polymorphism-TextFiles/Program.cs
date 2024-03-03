using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism_TextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\two4o\\Desktop\\C# Development\\C-Sharp-Course-Exercises\\hello.txt";
            // Example 1 - Reading Text
            string text = System.IO.File.ReadAllText(filePath);
            // instead of saving filePath to a variable,
            // you can also read directly using the actual path by using syntax below - use '@' followed by the filepath:
            // string text = System.IO.File.ReadAllText(@"C:\Users\two4o\Desktop\C# Development\C-Sharp-Course-Exercises\hello.txt");

            Console.WriteLine("Text File contains the following text: {0}", text);
           

            // Example 2
            string[] lines = System.IO.File.ReadAllLines(filePath);

            Console.WriteLine("");
            Console.WriteLine("===== USING READ ALL LINES and Displaying Line by Line: ");
            Console.WriteLine("");

            foreach (string line in lines) {
                Console.WriteLine("\t" + line);
            }

            Console.ReadKey();

        }
    }
}
