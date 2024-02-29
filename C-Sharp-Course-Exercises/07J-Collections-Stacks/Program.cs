using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07J_Collections_Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> stack = new Stack<int>();

            // add items to the top of the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // use Peek() to look at item at top of the stack
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            // add another and peek
            stack.Push(5);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            // remove from the top of the stack
            stack.Pop();
            Console.WriteLine("Top value in the stack after popping an item : {0}", stack.Peek());

            // empty stack with a while loop
            int counter = 0;
            while (stack.Count > 0)
            {
                stack.Pop();
                counter++;
                Console.WriteLine("Popped {0} item(s): The size of the stack is: {1}", counter, stack.Count);
            }

            Console.WriteLine("After running the while loop to pop all items the size of the stack is: {0}", stack.Count);


            // create a new array, will reverse the array using a stack
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> reversedNumbers = new Stack<int>();

            

            Console.WriteLine("============Original Numbers Array============");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
                reversedNumbers.Push(num);
            }
            Console.WriteLine();
            Console.WriteLine("============Reversed Numbers Stack==========");
            foreach (int num in reversedNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
