using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08B_Inheritance2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Dog gingerSnap = new Dog("Ginger Snap", 2);
            Console.WriteLine($"{gingerSnap.Name} is a {gingerSnap.GetType().Name} and is {gingerSnap.Age} years old.");
            gingerSnap.MakeSound();
            gingerSnap.Eat();
            gingerSnap.Play();
        }
    }
}
