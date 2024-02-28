using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07A_Collections_Arrays
{
    internal class MainProgram
    {
        static void Main (string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0: {0}", grades[0]);
            Console.WriteLine("");
            Console.WriteLine("Enter new grade to replace grade at index 0:");
            string input = Console.ReadLine();
            // assign value to array grades at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0: {0}", grades[0]);

            

            // another way of initializing an array - populating the elements upfront

            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            // length/size of array
            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.WriteLine("Length of gradesOfMathStudentsB: {0}", gradesOfMathStudentsB.Length);

            // For Each Loops
            Console.WriteLine("==================FOR / FOR EACH LOOPS=========================");
       
            int[] nums = new int[10];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }
            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }


            // for each loop (in general for loops faster than forEach in terms of performance)
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter++, k);
            }

            string[] myFriends = { "Carolyn", "Dave", "Ed", "Paul", "Sam" };

 
            foreach(string friend in myFriends)
            {
                Console.WriteLine("Hello, {0}!", friend);
            }

            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int m = 0; m < numbers.Length; m+=2)
            {
                Console.WriteLine("For Loop skipping every other number:");
                Console.WriteLine(numbers[m]);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine("For each loop printing each number:");
                Console.WriteLine(number);
            }

            string input1;
            do
            {
                Console.WriteLine("Please enter a valid number:");
                input1 = Console.ReadLine();

            } while (!int.TryParse(input1, out _));


            Console.ReadKey();
        }
    }
}
