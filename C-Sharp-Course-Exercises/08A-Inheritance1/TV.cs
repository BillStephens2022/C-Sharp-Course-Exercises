using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08_Inheritance
{
    class TV:ElectronicDevice
    {
        // properties IsOn and Brand inherited from the parent class ElectronicDevice

        // inherits constructor from base (parent) class
        public TV(bool isOn, string brand) : base(isOn, brand) { }

        // Methods
        // SwitchOn and SwitchOff methods inherited from parent class (ElectronicDevice)

        // method to watch TV - this is unique to the TV class (i.e. not inherited)

        public void WatchTV()
        {
            if (IsOn)
            {
                // watch TV
                Console.WriteLine("Watching the Television!");
            }
            else
            {
                // print error message if radio is off
                Console.WriteLine("TV is switched off, switch it on first to watch...");
            }

        }

    }
}
