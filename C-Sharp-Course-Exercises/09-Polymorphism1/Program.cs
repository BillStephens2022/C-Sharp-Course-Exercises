using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            // Setting up 2 Audi's - 1 saved to variable of type "Car" and
            // 1 saved to variable of type "Audi"
            Car audi1 = new Audi(475, "black", "R8");
            Audi audi2 = new Audi(250, "red", "A6");
            audi1.ShowDetails();  // note that the method uses' Car class ShowDetails() Method
            audi2.ShowDetails();  // note that the method uses' Audi class ShowDetails() Method 

            // using casting to cast the audi2 car from BMW to Car
            Console.WriteLine();
            Console.WriteLine("Test using casting:");
            Car car1 = (Car)audi2;
            car1.ShowDetails(); // will use Car's ShowDetails method

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();
        }
    }
}
