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

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);
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
