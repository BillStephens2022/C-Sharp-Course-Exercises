using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._10C_AdvancedTopics_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling of 15.3 is: " + Math.Ceiling(15.3));  // 16
            Console.WriteLine("Floor of 15.3 is: " + Math.Floor(15.3)); // 15

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine("The lower of num1(13) and num2(9) is: " + Math.Min(num1, num2)); // 9
            Console.WriteLine("The higher of num1(13) and num2(9) is: " + Math.Max(num1, num2)); // 13

            Console.WriteLine("3 to the power of 5 is: {0}", Math.Pow(3, 5)); // 243

            Console.WriteLine("PI: " + Math.PI); // 3.141592653589793

            Console.WriteLine("The square root of 144 is: " + Math.Sqrt(144)); // 12
            Console.WriteLine("The absolute value of -42 is: " + Math.Abs(-42));  // 42

            Console.WriteLine("The cosine of 1 is: {0}", Math.Cos(1)); // 0.5403023058681398

            Run("75");
        }

        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            int num;
            bool success = int.TryParse(line, out num);
            if (success && (num >=0 && num <=180))
            {
               double radians = ConvertToRadians((double) num);
               Console.WriteLine("Cos = {0}", Math.Cos(radians));
               Console.WriteLine("Sin = {0}", Math.Sin(radians));
               Console.WriteLine("Tg = {0}", Math.Tan(radians));
            }
            else
            {
                Console.WriteLine("Check the input!");
            }
        }
    }
}
