using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08F_Inheritance6_Interfaces2
{
    internal class Vehicle
    {
        // Properties
        public float Speed { get; set; }
        public string Color { get; set; }


        // Default Constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        // Simple Constructor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
