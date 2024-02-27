using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._03_Functions_Methods
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am and argument and I am called from a method!!");
            int x = 15;
            int y = 27;
            double a = 56;
            double b = 13;
            int resultAdd = Add(x, y);
            int resultMultiply = Multiply(x, y);
            double resultDivide = Divide(a, b);
            Console.WriteLine($"The result of {x} + {y} is: " + resultAdd);
            Console.WriteLine($"The result of {x} x {y} is: " + resultMultiply);
            Console.WriteLine($"The result of {a} / {b} is: " + resultDivide);
            string friend1 = "Carolyn";
            string friend2 = "Jimmy";
            string friend3 = "Butch";
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            string s = "HeY ThErE !";
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
            Console.Read();

        }

        // access modifier (static) return type method name (parameters)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Hi {friendName}, my friend!");
        }

        public static string LowUpper(string s)
        {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s)
        {
            Console.WriteLine($"The amount of characters is {s.Length}.");
        }
    }
}
