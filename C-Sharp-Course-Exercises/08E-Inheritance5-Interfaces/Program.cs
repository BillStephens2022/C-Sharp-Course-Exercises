using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08E_Inheritance5_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Ticket t3 = new Ticket(6);
            Console.WriteLine($"Does ticket 1 equal ticket 2? {t2.Equals(t1)}");
            Console.WriteLine($"Does ticket 1 equal ticket 3? {t3.Equals(t1)}");
        }
    }
}
