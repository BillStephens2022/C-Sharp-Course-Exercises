using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._06_OOP
{
    internal class Car
    {
        // Member Variables
        private string _name;  // private field typically used for storing data.
        private int _hp;
        private string _color;

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "black";
        }

        // Constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine("A new car with name: '{0}' was created!", name);
        }

        // Member methods

        public void Details()
        {
            Console.WriteLine("The car, {0}, is {1} and has {2} horsepower.", _name, _color, _hp);
        }

        public void Drive()
        {
            Console.WriteLine("{0} is driving!", _name);
        }

        public void Stop()
        {
            Console.WriteLine("{0} is stopped.", _name);
        }
    }
}
