using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._12B_Linq_UniversityManager
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // foreign key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with id {1}, Gender {2}, " + 
                "and Age {3} from University with the id {4}", Name, Id, Gender, Age, UniversityId);
        } 
    }
}
