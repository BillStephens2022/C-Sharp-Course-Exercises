using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07E_Collections_ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("price is {0}, pi is {1}, at is {2}", 32, 3.14159, "@");

            Console.WriteLine("{0} + {1} + {2} + {3} + {4} + {5} + {6} + {7} + {8}", 1, 2, 3, 4, 5, 6, 7, 9, 1 + 2 + 3 + 4 + 5 + 6 + 7);

            ParamsMethod("This", "is", "a", "long", "string", "...", "I", "have", "no", "idea", "when", "it", "is", "going", "to", "end", "...");

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hello", 5.3, '$');
            ParamsMethod2();

            int sum1 = Sum(1, 2, 3);
            int sum2 = Sum(4, 5, 6, 7, 8);
            int sum3 = Sum();

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            double avg1 = Average(1, 2, 3);
            double avg2 = Average(4, 5, 6, 7, 8);
            double avg3 = Average();

            Console.WriteLine(avg1);
            Console.WriteLine(avg2);
            Console.WriteLine(avg3);

            int min = MinV2(6, -45, 2, -8, 0, 1, 5);
            Console.WriteLine("The minimum is: {0}", min);
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            // for each loop to go through the array of objects
            foreach (object obj in stuff)
            {
                // print each object followed by a space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }

        public static double Average(params int[] numbers)
        {
            int total = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                total += number;
                count++;
            }
            if (count == 0) return 0;

            return (double)total / count;
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;  // int.MaxValue tells us the maximum value an integer data type can have
            
            foreach (int number in numbers)
            {
                if (number < min) min = number;
            }
            return min;
        }
    }
}