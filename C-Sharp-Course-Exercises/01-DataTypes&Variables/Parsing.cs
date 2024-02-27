using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._01_DataTypes_Variables
{
    internal class Parsing
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            string result = myString + mySecondString;
            int resultInt = num1 + num2;

            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            float stringToFloat = float.Parse(stringForFloat);
            int stringToInt = Int32.Parse(stringForInt);

            Console.WriteLine("string result: " + result);
            Console.WriteLine("parsed int result: " + resultInt);
            Console.WriteLine("StringToFloat: " + stringToFloat + " String to Int: " + stringToInt);
            Console.Read();
        }
    }
}
