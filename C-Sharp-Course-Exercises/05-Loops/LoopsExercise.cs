using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._05_Loops
{
    internal class LoopsExercise
    {
        public static void ForLoop()
        {
            for (int i = -3; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int i = 3;
            while (i >= -3)
            {
                Console.WriteLine(i);
                i--;
            }
        }

        public static void Run()
        {
            WhileLoop();
            ForLoop();

        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
