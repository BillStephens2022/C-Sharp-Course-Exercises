using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._10H_AdvancedTopics_MainArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args ;), Please provide arguments next time.");
                // pause the application so it doesn't quit after printing the error message
                Console.ReadKey();
                //quit the application entirely since we can't proceed further without any args
                return;
            }


            if (args[0] == "help")
            {
                Console.WriteLine("************************ Instructions: ");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub': to subtrance 2 numbers");
                Console.WriteLine("******************************************");

                Console.ReadKey();
                //quit the application entirely since we can't proceed further without any args
                return;
            }

            // check length of args
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                // pause
                Console.ReadKey();
                // quit the app
                return;
            }

            // check if numbers entered by user are valid and can be parsed to a float
            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                // pause
                Console.ReadKey();
                // quit the app
                return;
            }

            float result;

            switch(args[0])
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"'Add' Result: {num1} + {num2} = {result}");
                    break;
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"'Subtract Result': {num1} - {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");
                    break;
            }

            Console.WriteLine("Hello " + args[0]);
            Console.ReadKey();
        }
    }
}
