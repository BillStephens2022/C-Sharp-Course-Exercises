using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08D_Inheritance4_Challenge2
{
    internal class Employee
    {
        public string Name {  get; set; }
        public string FirstName { get; set; }   
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary) { 
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"The employee, {Name}, is Working!");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"The employee, {Name}, is taking a break.");
        }

        public override string ToString()
        {
            return $"The Employee's name is {Name}, and earns ${Salary} per year";
        }

    }
}
