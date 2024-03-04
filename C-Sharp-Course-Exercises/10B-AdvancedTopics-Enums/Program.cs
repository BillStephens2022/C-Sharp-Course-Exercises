using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._10B_AdvancedTopics_Enums
{
    internal class Program
    {
        enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun }

        // note: by setting Jan to 1 below, this will ensure the numerical of each Month is
        // set with Jan being 1, Feb being 2, etc.  If you want, you can set each month to a different
        // value so if you cast the month into an int it will use the numerical value assigned.
        enum Month {  Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
        static void Main(string[] args)
        {
            Day fri = Day.Fri;
            Day sun = Day.Sun;

            Day a = Day.Fri;

            // result of below is 'true'
            Console.WriteLine("Comparing variable 'a' and variable and variable 'fri' which were assigned to the same enum value: {0}", a == fri);
            
            // as expected both lines below print the same thing: 'Sun'
            Console.WriteLine("printing Day.Sun: " + Day.Sun);
            Console.WriteLine("printing variable 'sun': " + sun);

            // prints the integer value of Wed which is the index value in the enum. For Wed, this is index 2.
            Console.WriteLine((int)Day.Wed); // 2

            // will return 2 (instead of 1 which would be the default) because we set Jan to 1
            // in the enum definition
            Console.WriteLine((int)Month.Feb);  // 2
            Console.WriteLine((int)Month.Aug);  // 8


        }
    }
}
