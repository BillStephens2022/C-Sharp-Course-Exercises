using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07I_Collections_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Declare a new Dictionary
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" }
            };

            Employee[] employees = new Employee[]
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee employee in employees) 
            { 
                employeesDirectory.Add(employee.Role, employee);
            }

            Console.WriteLine("====== Using key to get a value from the dictionary ========");

            string key = "CTO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            } else
            {
                Console.WriteLine("KEY ERROR:  Key not found in dictionary");
            }

            Console.WriteLine("====== Using TryGetValue() method to Retrieve from Dictionary ========");

            Employee result = null;
            // using TryGetValue() - it returns a boolean
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!");

                Console.WriteLine("Employee Name: {0}, Employee Role: {1}, Employee Age: {2}, Employee Salary: {3}", result.Name, result.Role, result.Age, result.Salary);

            }
            else
            {
                Console.WriteLine("The key does not exist!");
            }

            // modifying a value at a specific key - Lora was fired, Eleka was hired at HR role.
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with id of '{0}' was updated successfully!", keyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", keyToUpdate);
            }

            // removing an item from the dictionary
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with Role of '{0}' was successfully removed!", keyToRemove);
            }

            // iterating thru dictionary using KeyValuePair, ElementAt(i), etc

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}, Employee Role: {1}, Employee Age: {2}, Employee Salary: {3}", employeeValue.Name, employeeValue.Role, employeeValue.Age, employeeValue.Salary);
            }

            // Testing Convert method below (coding exercise)
            Console.WriteLine("===========TESTING CODING EXERCISE==============");
            Console.WriteLine("Testing Key of int 1: {0}", Convert(1));
            Console.WriteLine("Testing Key of int 3: {0}", Convert(3));
            Console.WriteLine("Testing Key of int 5: {0}", Convert(5));
            Console.WriteLine("Testing Key of int 9: {0}", Convert(9));
        }

        public static string Convert(int i)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" }
            };
            string result = "";
            if (myDictionary.ContainsKey(i))
            {
                result = myDictionary[i];
            } else
            {
                result = "nope";
            }

            return result;
        }
    }

    

    class Employee
    {
        // properties (Role, Name, Age, Rate, Salary)
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                // Yearly salary = rate/h * number of days * number of weeks * number of months
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
