using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._12B_Linq_UniversityManager
{
    internal class University
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }
}
