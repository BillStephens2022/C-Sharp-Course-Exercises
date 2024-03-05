using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._10F_AdvancedTopics_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2002, 08, 04);
            Console.WriteLine("My birthday is {0}", dateTime);

            // write today on screen (note that it will show 12AM for the current day)
            Console.WriteLine(DateTime.Today);

            // write current time on screen (will show both current date and current time to the ms)
            Console.WriteLine(DateTime.Now);

            // use custom method GetTomorrow(defined below)
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be {0}", tomorrow);

            // get the day of week (i.e. Monday, Tuesday, etc)
            Console.WriteLine("Today is: {0}", DateTime.Today.DayOfWeek);


            // get first day of any year using custom function (GetFirstDayOfYear) defined below
            int year1 = 1972;
            Console.WriteLine("The first day of {0} is: {1} and is a {2}", year1, GetFirstDayOfYear(year1), GetFirstDayOfYear(year1).DayOfWeek);

            int daysInFeb = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine("Number of Days in month for Feb 2024: {0}", daysInFeb);
            daysInFeb = DateTime.DaysInMonth(2025, 2);
            Console.WriteLine("Number of Days in month for Feb 2025: {0}", daysInFeb);

            DateTime now = DateTime.Now;
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);

            // display the time in this structure  x o'clock and y minutes and z seconds
            Console.WriteLine("{0} o'clock, {1} minutes, {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
                Console.WriteLine("Date entered plus 20,000 days: {0}", dateTime.AddDays(20000));
            } else
            {
                Console.WriteLine("wrong input!");
            }
        }

        // custom method to get tomorrow's date by adding 1 day to today

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        // custom method to get the first day of any year
        static DateTime GetFirstDayOfYear(int year) 
        {
            return new DateTime(year, 1, 1);
        }
    }
}
