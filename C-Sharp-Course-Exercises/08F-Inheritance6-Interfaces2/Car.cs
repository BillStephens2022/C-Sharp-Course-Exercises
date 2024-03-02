using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08F_Inheritance6_Interfaces2
{
    // Subclass Car extends Vehicle
    internal class Car : Vehicle, IDestroyable
    {
        // implementation of DestructionSound property from our IDestroyable interface
        public string DestructionSound { get; set; }

        // creating a new property specific to Car to store the destroyable objects nearby
        // when a car getes destroyed it should also destroy the nearby object
        // this list is of type IDestroyable which means it can store any object
        // that implements this interface and we can only access the properties and 
        // methods in this interface
        public List<IDestroyable> DestroyablesNearby;

        // Simple Constructor
        public Car(float speed, string color) 
        {
            Speed = speed;
            Color = color;
            // initialize the IDestroyable interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            // initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

       public void Destroy()
        {
            // when a car gets destroyed we should play the destruction sound and
            // create the fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            // go through each destroyable object nearby and call it's destroy method
            foreach (IDestroyable destroyableObject in DestroyablesNearby)
            {
                destroyableObject.Destroy();
            }
        }
    }
}
