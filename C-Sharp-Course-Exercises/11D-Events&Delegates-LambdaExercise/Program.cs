using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11D_Events_Delegates_LambdaExercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(4, 6));
            Console.WriteLine(Minus(4, 6));
            Console.WriteLine(Multiply(4, 6));
            Console.WriteLine(Divide(4, 6));

        }

        static Func<float, float, float> Plus = (num1, num2) => num1 + num2;
        static Func<float, float, float> Minus = (num1, num2) => num1 - num2;
        static Func<float, float, float> Multiply = (num1, num2) => num1 * num2;    
        static Func<float, float, float> Divide = (num1, num2) => num1 / num2;

        static public Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>{
                {"+", Plus},
                {"-", Minus},
                {"/", Divide},
                {"*", Multiply}
            };

        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }
    }
}
