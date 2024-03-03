using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._09_Polymorphism1
{
    // "Has a" relationship - used this CarIDInfo as a property within the Car class,
    // and set up getter and setter within the Car class to set these properties.  Used
    // the getters and setters in the Main class when creating instances using the Car class.
    internal class CarIDInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "No owner";
        
    }
}
