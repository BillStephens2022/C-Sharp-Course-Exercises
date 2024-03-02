using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1
{
    internal class Audi : Car
    {
        private string Brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        // notice the "new" keyword in the method signature below. This is similar to override, but
        // not exactly the same.  If the Audi instance is created under the base class of Car,
        // (i.e. Car audi1 = new Audi(475, "red", "R8");), it will use the base class' ShowDetails() method.
        // however, if the Audi is created under the more specific Audi class, 
        // (i.e. Audi audi1 = new Audi(275, "red", "R8");), it will use the Audi class' ShowDetails() method.

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
