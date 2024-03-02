using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08F_Inheritance6_Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating two objects of type Chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Leather");

            // creating a new object of type Car
            Car damagedCar = new Car(80f, "Blue");

            // add the two chairs to the IDestroyable list of the car
            // so that when we destroy the car, the destroyable objects
            // that are near the car will also get destroyed
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();

        }
    }
}
