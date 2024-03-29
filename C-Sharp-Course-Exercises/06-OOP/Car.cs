﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp_Course_Exercises._06_OOP
{
    internal class Car
    {
        // Member Variables
        private string _name;  // private field typically used for storing data.
        private int _hp;
        private string _color;

        // Auto implemented properties - creates a private anonymous field which can only be accessed through
        // the get / set methods
        public int MaxSpeed { get; set; }

        // Properties (public)
        public string Name
        {
            get { return _name; } // the 'get' accessor (used in place of getter methods)
            set
            {
                if (value == "")
                {
                    _name = "DefaultName";
                }
                else
                {
                    _name = value; // the 'set' accessor (used inplace of setter methods) - takes whatever name is given in parentheses i.e. myCar.Name("MYCARSNAME");
                }
            }
        }
        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 100;
            _color = "black";
            Console.WriteLine("A new car with name: '{0}' was created!", _name);
        }

        // Constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            _hp = hp;
            _color = color;
            Console.WriteLine("A new car with name: '{0}' was created!", _name);
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
