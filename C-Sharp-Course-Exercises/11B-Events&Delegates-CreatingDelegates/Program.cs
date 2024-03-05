using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._11B_Events_Delegates_CreatingDelegates
{
    internal class Program
    {
        // Creating our own delegate
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids:", people, IsMinor);
            DisplayPeople("Adults:", people, IsAdult);
            DisplayPeople("Seniors:", people, IsSenior);

            // creating a new variable called filter of type FilterDelegate
            // then assign an anonmymous method to it instead of an already defined method.
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            // using new filter
            DisplayPeople("Between 20 and 30:", people, filter);
            // anonymous method
            DisplayPeople("All:", people, delegate (Person p) { return true; });



            string searchKeyword = "A";

            // using a lambda statement block to filter
            DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, p =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                } else
                {
                    return false;
                }
            });

            // using a lambda expression
            DisplayPeople("exactly 25: ", people, p => p.Age == 25);
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate Filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people) {
                // checks if the person(p) passes the filter (i.e. IsMinor or IsSenior)
                if (Filter(p))
                {
                   Console.WriteLine("{0}, {1} years old", p.Name, p.Age); 
                }
                
            }
            
        }

        // ====== FILTERS ===============
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }


    }
}
