using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08D_Inheritance4_Challenge2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Boss bill = new Boss("Bill Stephens", "Bill", 300000, "Mercedez Benz");
            Employee mia = new Employee("Mia Wallace", "Mia", 85000);
            Trainee vincent = new Trainee("Vincent Vega", "Vincent", 45000);

            Console.WriteLine(bill.ToString());
            Console.WriteLine(mia.ToString());
            Console.WriteLine(vincent.ToString());

            bill.Work();
            mia.Work();
            vincent.Work();

            bill.Pause();
            mia.Pause();
            vincent.Pause();

            bill.Lead();
            vincent.Learn();

        }
    }
}
