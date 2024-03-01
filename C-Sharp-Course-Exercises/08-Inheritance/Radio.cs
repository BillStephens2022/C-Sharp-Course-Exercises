using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08_Inheritance
{
    // the colon indicates that Radio class inherits from (extends) the ElectronicDevice class
    class Radio : ElectronicDevice
    {

        // Properties - note that Radio class inherits the IsOn and Brand properties from the 
        // ElectronicDevice class

        // constructor - ' : base' indicates that it is inheriting constructor from base class (which
        // is Electronic Device
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

       // Methods
       // SwitchOn and SwitchOff methods inherited from parent class (ElectronicDevice)

        // method to listen to the radio - this is unique to the radio class (i.e. not inherited)
        public void ListenRadio()
        {
            if (IsOn)
            {
                // listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                // print error message if radio is off
                Console.WriteLine("Radio is switched off, switch it on first to listen...");
            }

        }

    }
}
