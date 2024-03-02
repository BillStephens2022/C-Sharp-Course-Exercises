using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08F_Inheritance6_Interfaces2
{
    internal class Furniture
    {
        // Properties
        public string Color { get; set; }
        public string Material { get; set; }

        // Default Constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        // Simple Constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;             
        }
    }
}
