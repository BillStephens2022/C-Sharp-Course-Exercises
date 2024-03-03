using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1_Abstract
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }


        public override double Volume()
        {
            return Math.Pow(Length, 3);  // Length cubed (to the power of 3)
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a length of {Length}cm and a volume of {Volume()}cm^3");
        }
    }
}
