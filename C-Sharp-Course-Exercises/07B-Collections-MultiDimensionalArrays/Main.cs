using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07B_Collections_MultiDimensionalArrays
{
    internal class MultiDimensionalArrays
    {
        static void Main(string[] args)
        {
            // declare a 2D array
            string[,] matrix;

            // declare a 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            Console.WriteLine("Central Value is {0}", array2D[1,1]); // access position row =1 column =1 which should be a value of 5, i.e. the center position
            // for each loop
            Console.WriteLine("Looping through 2D array using 'foreach': ");
            foreach (int item in array2D)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Looping through 2D array using 'nested for loop':");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
            }
            Console.WriteLine();

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi There", "What's Up?"}
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another One", "Last Entry"}
                }
            };

            Console.WriteLine("Value at position (1, 0, 1): {0}", array3D[1,0,1]); // "101"
            Console.WriteLine("Value at position (0, 1, 0): {0}", array3D[0,1,0]); // "010"
            Console.WriteLine("Value at position (0, 2, 0): {0}", array3D[0,2,0]); // "Hi There"
            Console.WriteLine("Value at position (1, 2, 1): {0}", array3D[1, 2, 1]); // "Last Entry"

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four"},
                { "five", "six"}
            };
            Console.WriteLine("Before change: Element in position (1,1): {0}",  array2DString[1, 1]);
            array2DString[1, 1] = "chicken";
            Console.WriteLine("After change: Element in position (1,1): {0}", array2DString[1, 1]);

            int dimensions = array2DString.Rank;  // Rank returns the # of dimensions in an array
            Console.WriteLine("The array2DString array has {0} dimensions", dimensions);

            // example of declaring and initializing a 2d array without using
            // "new" keyword or defining capacity.  Will infer this automatically.
            int[,] array2D2 = { { 1, 2 }, { 3, 4 }, { 4, 5 } };
            Console.WriteLine("Value at position (1,1) is {0}", array2D2[1,1]); // 4
        }
    }
}
