using C_Sharp_Course_Exercises._07A_Collections_Arrays;
using C_Sharp_Course_Exercises._08B_Inheritance2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08G_Inheritance_IEnumerator_IEnumerable
{
    internal class Program
    {

        // 1. IEnumerable <T> for generic collections
        // 2. IEnumerable for non-generic collections
        // used for iterating through collections and keeping count

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this 
        /// interface: GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> object provides the ability to iterate through the
        /// collection by exposing a Current property that points at the object we are currently
        /// at in the collection.
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            foreach(Dog dog in shelter) 
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }

        }

        class Dog
        {
            // Properties
            public string Name { get; set; }    
            public bool IsNaughtyDog { get; set; }

            // Simple constructor
            public Dog(string name, bool isNaughtyDog) 
            {
                Name = name;
                IsNaughtyDog = isNaughtyDog;
            }

            // Method to print how many treats the dog received
            public void GiveTreat(int numberOfTreats)
            {
                // print a message containing the number of treats and the name of the dog
                Console.WriteLine("Dog: {0} said Woof! {1} times!", Name, numberOfTreats);
            }
        }

        class DogShelter : IEnumerable<Dog>
        {
            // list of type List<Dog>
            public List<Dog> dogs;

            // this constructor will initialize the dogs list with some values
            public DogShelter()
            {
                // initialize the dogs list using the collection initializer
                dogs = new List<Dog>()
                {
                    new Dog("Abbie", false),
                    new Dog("Ginger Snap", true),
                    new Dog("Preston", false),
                    new Dog("Cheri", false)
                };
            }

            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
            {
                return dogs.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
