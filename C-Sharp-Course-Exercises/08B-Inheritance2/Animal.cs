using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08B_Inheritance2
{
    class Animal
    {
        // Properties
        public string Name {  get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        // constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            // Animal's default is hungry by default
            IsHungry = true;
        }

        // Methods - note that using 'virtual' keyword allows the method to be overridden by child classes

        public virtual void MakeSound()
        {
            Console.WriteLine("Making General Animal Sounds....");
        }

        public virtual void Eat()
        {
            // check if animal is hungry
            if (IsHungry)
            {
                // if hungry, print a message that animal is eating
                Console.WriteLine($"{Name} is eating...Nom Nom Nom!");
            }
            else
            {
                // otherwise, print a message that animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
            
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing...Weeeeeeeee this is fun!");
        }
    }
}
