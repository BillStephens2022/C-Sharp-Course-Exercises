﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._06_OOP
{
    internal class ClassesAndObjects
    {

        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car audi = new Car("Audi A4", 275, "blue");
            audi.Drive();
            Car bmw = new Car("BMW M5", 350, "red");
            bmw.Drive();
            audi.Details();
            bmw.Details();
            myCar.Details();
            Console.WriteLine("Press 1 to stop the car");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            } else
            {
                Console.WriteLine("Car drives indefinitely");
            }
        }
    }
}