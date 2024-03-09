using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._12B_Linq_UniversityManager
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // constructor
        public UniversityManager() 
        { 
            universities = new List<University>();
            students = new List<Student>();

            // add some universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 1, Name = "Rutgers" });

            // add some students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Cliff", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Norm", Gender = "male", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Rebecca", Gender = "female", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Diane", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Sam", Gender = "male", Age = 20, UniversityId = 1 });
            students.Add(new Student { Id = 7, Name = "Woody", Gender = "male", Age = 18, UniversityId = 2 });
            students.Add(new Student { Id = 8, Name = "Coach", Gender = "male", Age = 24, UniversityId = 2 });
            students.Add(new Student { Id = 9, Name = "Frasier", Gender = "male", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 10, Name = "Paul", Gender = "male", Age = 19, UniversityId = 1 });
            students.Add(new Student { Id = 11, Name = "Lilith", Gender = "female", Age = 20, UniversityId = 1 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }
    }
}
