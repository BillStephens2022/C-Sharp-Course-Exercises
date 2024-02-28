using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07A_Collections_Arrays
{
    internal class CodingExerciseClass
    {
        public static void GetOdd(int[] Array)
        {
            // TODO
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            // TODO
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }
    }
}
