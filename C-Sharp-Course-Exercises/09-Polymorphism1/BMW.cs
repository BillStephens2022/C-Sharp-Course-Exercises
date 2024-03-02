using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1
{
    internal class BMW : Car
    {
        private string Brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model): base(hp, color)
        {
            Model = model;
        }

        // notice the "new" keyword in the method signature below. This is similar to override, but
        // not exactly the same.  If the BMW instance is created under the base class of Car,
        // (i.e. Car bmw1 = new BMW(275, "red", "M5");), it will use the base class' ShowDetails() method.
        // however, if the BMW is created under the more specific BMW class, 
        // (i.e. BMW bmw1 = new BMW(275, "red", "M5");), it will use the BMW class' ShowDetails() method.

        public new void ShowDetails()
        {
            Console.WriteLine($"This {Color} {Brand} {Model} has {HP} horsepower");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {Color} {Brand} {Model} has been repaired!!");
        }
    }
}
