using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07C_Collections_JaggedArrays
{
    internal class JaggedArrays
    {
        static void Main(string[] args)
        {
            // declare a jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            Console.WriteLine("The value in the middle of the first row is {0}", jaggedArray2[0][2]); // 5
            Console.WriteLine("The value in the middle of the second row is {0}", jaggedArray2[1][1]); // 2
            Console.WriteLine("The value at the beginning of the last row is {0}", jaggedArray2[2][0]); // 13

            // display all items within the jagged array
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
                }
            }

            int[][] triangle = new int[][]
            {
                new int[] { 1 },
                new int[] { 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9, 10 },
            };
            
            // use a foreach loop to print each row of the triangle
            foreach (int[] row in triangle)
            {
                foreach (int num in row)
                {
                    Console.WriteLine(num);
                }
            }

            // multidimensional array - note jagged arrays are useful for more complex data structures,
            // since they are more flexible in terms of the size of each embedded array.  Multidimensional
            // arrays are more uniform (i.e. same number of elements in each embedded array).
            int[,] grid = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 }
            };

            // use a nested for loop to print each row of the triangle
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine(grid[i, j]);
                }
            }


            // ################JAGGED ARRAY CHALLENGE#############################
            string[][] friendsFamilies = new string[][]
            {
                new string[] {"David", "Rob", "Gina", "Dave" },
                new string[] {"Ed", "Bridget", "Sam", "Alex", "Ruth", "Gerry" },
                new string[] {"Paul", "Steph", "Lily" }
            };

            Console.WriteLine("Hi, {0}, meet {1}", friendsFamilies[0][0], friendsFamilies[1][1]);
            Console.WriteLine("Hi, {0}, meet {1}", friendsFamilies[1][0], friendsFamilies[0][2]);
            Console.WriteLine("Hi, {0}, meet {1}", friendsFamilies[1][2], friendsFamilies[2][2]);
        }
    }
}
