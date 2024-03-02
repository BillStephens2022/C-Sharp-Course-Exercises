using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08J_Inheritance_IEnumerable_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }

        class Contact {
            public string Name { get; set; }    
            public string PhoneNumber { get; set; }

            public Contact(string name, string phoneNumber)
            {
                Name = name;
                PhoneNumber = phoneNumber;
            }

            public void Call()
            {
                // "Calling to X. Phone number is Y"
                Console.WriteLine($"Calling to {Name}. Phone number is {PhoneNumber}");
            }
        }

        class PhoneBook : IEnumerable<Contact>
        {
            public List<Contact> Contacts { get; set; }

            public PhoneBook()
            {

                Contacts = new List<Contact>{
                    new Contact("Andre", "435797087"),
                    new Contact("Lisa", "435677087"),
                    new Contact("Dine", "3457697087"),
                    new Contact("Sofi", "4367697087")
                };
            }

            IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
            {
                return Contacts.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
