using C_Sharp_Course_Exercises._11B_Events_Delegates_CreatingDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11C_Events_Delegates_DelegateExercise
{
    internal class Program
    {
        public delegate float OperationDelegate(float num1, float num2);

        static void Main(string[] args)
        {
            // Creating instances of the delegate with the appropriate methods
            OperationDelegate addDelegate = Add;
            OperationDelegate subtractDelegate = Subtract;
            OperationDelegate multiplyDelegate = Multiply;
            OperationDelegate divideDelegate = Divide;

            // Example usage
            Console.WriteLine(ApplyOperation(1, 2, addDelegate));
            Console.WriteLine(ApplyOperation(3, 2, subtractDelegate));
            Console.WriteLine(ApplyOperation(4, 5, multiplyDelegate));
            Console.WriteLine(ApplyOperation(6, 2, divideDelegate));
        }

    

        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return float.NaN;
            }
            return num1 / num2;
        }

        public static float ApplyOperation(float num1, float num2, OperationDelegate oper)
        {
            float result;
            result = oper(num1, num2);
            return result;
        }
        
    }
}
