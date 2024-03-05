using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11A_Events_Delegates_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("=================BEFORE======================");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // RemoveAll function accepts a delegate.  We create a Filter function as the delegate.
            names.RemoveAll(Filter);
            Console.WriteLine("=================AFTER======================");
     
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}
