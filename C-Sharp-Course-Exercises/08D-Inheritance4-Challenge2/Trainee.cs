using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08D_Inheritance4_Challenge2
{
    internal class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string name, string firstName, int salary) : base(name, firstName, salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            WorkingHours = 5;
            SchoolHours = 3;
        }

        public override void Work()
        {
            Console.WriteLine($"The Trainee, {FirstName}, is working and will work for {WorkingHours} hours.");
        }

        public override void Pause()
        {
            Console.WriteLine($"The Trainee, {FirstName}, is taking a break...");
        }

        public void Learn()
        {
            Console.WriteLine($"The Trainee, {FirstName}, is currently training and learning new tasks... and will be doing so for {SchoolHours} hours.");
        }

        public override string ToString()
        {
            return $"The Trainee's name is {Name}, earns ${Salary} per year, and is scheduled to work {WorkingHours} hours and learn for {SchoolHours} hours.";
        }

    }
}
