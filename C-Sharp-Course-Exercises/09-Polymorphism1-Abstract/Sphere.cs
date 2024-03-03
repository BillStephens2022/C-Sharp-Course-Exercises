using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1_Abstract
{
    internal class Sphere : Shape
    {
        // V = 4/3 * pi * r * cubed
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume() { 
            return ((4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3)); 
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a radius of {Radius}cm and a volume of {Volume()}cm^3");
        }

    }
}
