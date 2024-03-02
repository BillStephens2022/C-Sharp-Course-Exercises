using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;  
        }

        public void ShowDetails()
        {
            Console.WriteLine("Details - This color has {0} horsepower and is the color: {1}", HP, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
