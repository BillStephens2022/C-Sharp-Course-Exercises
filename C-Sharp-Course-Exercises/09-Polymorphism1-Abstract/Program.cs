using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1_Abstract
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Shape[] shapes = { new Cube(4), new Sphere(10) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();

                // checking to see if object is of type Cube
                Console.WriteLine("=====TYPE CHECK=====");
                Cube iceCube = shape as Cube;
                if (iceCube == null)
                {
                    Console.WriteLine($"This shape: {shape.Name} is not a cube");
                }

                if (shape is Cube)
                {
                    Console.WriteLine($"This shape: {shape.Name} is a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1; // casting object cube1 into a Cube.

                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume());
            }
        }
    }
}
