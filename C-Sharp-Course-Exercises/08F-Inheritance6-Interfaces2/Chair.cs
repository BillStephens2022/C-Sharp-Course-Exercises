using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08F_Inheritance6_Interfaces2
{
    internal class Chair : Furniture, IDestroyable
    { 
        // implementing the IDestroyable interface's DestructionSound property
        public string DestructionSound {  get; set; }

        // Simple Constructor
        public Chair(string color, string material) 
        {
            this.Color = color;
            this.Material = material;
            // initializing the IDestroyable interface's property with a value in the constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            // when a chair gets destroyed we should play the destruction sound
            // and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts...");
        }
    }
}
