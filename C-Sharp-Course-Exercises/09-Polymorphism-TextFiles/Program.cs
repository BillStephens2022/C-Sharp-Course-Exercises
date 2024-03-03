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
                Console.WriteLine("\t" + line); // '\t' is just an escaped tab - to indent the text
            }


            // Method 1 - Writing text to a text file
            string[] lines2 = { "My Name is Bill Stephens", 
                "I am a Full Stack Software Engineer",
                "I am currently seeking opportunities,",
                "so reach out if you could use a hand on your latest projects."
            };

            // note: when writing to the file, can also pass in the file path directly similar
            // to commented out code above for reading a file using the '@' notation and the file path 
            //  in quotes.

            string filePath2 = "C:\\Users\\two4o\\Desktop\\C# Development\\C-Sharp-Course-Exercises\\bill.txt";
            // Note that if the txt file doesn't exist yet, It will automatically create one using the filename (i.e. 'bill.txt').
            File.WriteAllLines(filePath2, lines2); 

            // note: when writing to the file, can also pass in the file path directly using the
            // '@' notation and the file path in quotes.
            // File.WriteAllLines(@"C:\Users\two4o\Desktop\C# Development\C-Sharp-Course-Exercises\bill.txt", lines2);

            string[] retrievedTextLines2 = File.ReadAllLines(filePath2);

            Console.WriteLine("");
            Console.WriteLine("====  READING FROM A NEWLY CREATED TXT FILE: ");
            foreach (string line in retrievedTextLines2)
            {
                
                Console.WriteLine("\t" + line);  // '\t' is just an escaped tab - to indent the text
            }


            // Writing to Files - Method 2 - getting user input for file name and text
            string filePath3 = "C:\\Users\\two4o\\Desktop\\C# Development\\C-Sharp-Course-Exercises\\";            Console.WriteLine("Please give the file a name: ");
            string inputFilename = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(filePath3 + inputFilename + ".txt", input);

            string[] retrievedTextLines3 = File.ReadAllLines(filePath3 + inputFilename + ".txt");

            Console.WriteLine("");
            Console.WriteLine("=== Reading from a newly created file that was creating using User input:");
            foreach(string line in retrievedTextLines3)
            {
                Console.WriteLine("\t" + line);
            }

            // Method 3 - writing to a file using a StreamWriter
            string[] lines3 = { "First 250", "Second 242", "Third 240" };

            using(StreamWriter file =  new StreamWriter(filePath3 + "streamWriter.txt"))
            {
                foreach (string line in lines3) { 
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);  // writes "Third 240" into the streamWriter.txt file.
                        // if streamWriter.txt file doesn't exist, it will create a new file with that name.
                    }
                }
            }

            // by passing 'true' as the second argument after the filepath/filename, this will keep
            // existing text and add a new line of text under the existing text.
            using (StreamWriter file2 = new StreamWriter(filePath3 + "streamWriter.txt", true))
            {
                file2.WriteLine("Fourth 238");
            }


            Console.WriteLine("");
            Console.WriteLine("=== Checking to see if 4th line was added to file:");
            string[] retrievedTextLines4 = File.ReadAllLines(filePath3 + "streamWriter.txt");
            foreach (string line in retrievedTextLines4) 
            {
                Console.WriteLine("\t" + line);
            }


            Console.ReadKey();

        }
    }
}
