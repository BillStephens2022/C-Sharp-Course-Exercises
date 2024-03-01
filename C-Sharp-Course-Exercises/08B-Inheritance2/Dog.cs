using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08B_Inheritance2
{
    class Dog : Animal
    {
        // Properties - inherits name and age from Animal class
        public bool IsHappy { get; set; }   
        public Dog(string name, int age) : base(name, age) { 
          IsHappy = true;
        }

        // override the 'Eat' method which is inherited from the parent class
        public override void Eat()
        {
            // to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        // override the 'MakeSound' method which is inherited from the parent class
        public override void MakeSound()
        {
            Console.WriteLine("WOOF WOOF!");
        }

        // override the 'Play' method which is inherited from the parent class
        public override void Play()
        {
            if (IsHappy)
            {
                Console.WriteLine($"{Name} wags his/her tail... and chases ball");
            }
            else
            {
                Console.WriteLine($"{Name} is not playing because {Name} is sad... :(");
            }
        }
    }
}
