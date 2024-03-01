using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08_Inheritance
{
    // Parent class (Electronic Device) of Child Classes Radio class and TV class
    class ElectronicDevice
    {
        // Properties
        // boolean to determine the state of the Electronic Device
        public bool IsOn { get; set; }

        // string for the Brand of Electronic Device
        public string Brand { get; set; }

        // constructor
        public ElectronicDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // Methods

        // switch on the Electronic Device
        public void SwitchOn()
        {
            IsOn = true;
        }

        // switch off the Electronic Device
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
