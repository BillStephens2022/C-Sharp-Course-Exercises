using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08D_Inheritance4_Challenge2
{
    internal class Boss : Employee
    {
        public string CompanyCar {  get; set; }

        public Boss(string name, string firstName, int salary, string companyCar): base(name, firstName, salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            CompanyCar = companyCar;
        }

        public override void Work()
        {
            Console.WriteLine($"The BOSS, {FirstName}, is working!");
        }

        public override void Pause() {
            Console.WriteLine($"The BOSS, {FirstName}, is taking a break...");
        }

        public void Lead()
        {
            Console.WriteLine($"The BOSS, {FirstName}, is Leading his team on a project.");
        }

        public override string ToString()
        {
            return $"The Boss' name is {Name}, earns ${Salary} per year, and drives a {CompanyCar} as the company car.";
        }

    }
}
