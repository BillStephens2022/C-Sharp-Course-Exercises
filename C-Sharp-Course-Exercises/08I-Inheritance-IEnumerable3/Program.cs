using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08I_Inheritance_IEnumerable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a list of type List<int> initialized with some numbers
            List<int> numbersList = new List<int>() { 8, 6, 3 };

            // an array of type int[] initialized with some numbers
            int[] numbersArray = new int[] { 1, 7, 24, 10 };

            // new line
            Console.WriteLine(" ");

            // call CollectionSum() and pass the list to it
            Console.Write("The sum of the numbersList is: ");
            CollectionSum(numbersList);
            Console.WriteLine(" ");
            Console.Write("The sum of the numbersArray is: ");
            CollectionSum(numbersArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variable to store the sum of the numbers in anyCollection
            int sum = 0;
            // foreach number in the collection passed to the method
            foreach (int num in anyCollection) 
            {
                // add the num value to sum
                sum += num;
            }
            // print the sum
            Console.Write("Sum is {0}", sum);
        }
    }
}
