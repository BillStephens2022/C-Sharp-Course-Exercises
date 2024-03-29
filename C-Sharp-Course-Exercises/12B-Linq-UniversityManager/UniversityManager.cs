﻿using System;
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
            universities.Add(new University { Id = 2, Name = "Rutgers" });

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

        public void ShowMaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void ShowFemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by Age:");
            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromRutgers()
        {
            IEnumerable<Student> rutgersStudents = from student in students
                                                   join university in universities on student.UniversityId equals university.Id
                                                   where university.Name == "Rutgers"
                                                   select student;
            Console.WriteLine("List of Students from Rutgers:");
            foreach (Student student in rutgersStudents)
            {
                student.Print();
            }
        }

        public void ShowStudentsByUniversity(int IdOfUniversity)
        {
            IEnumerable<Student> uniStudents = from student in students
                                                   join university in universities on student.UniversityId equals university.Id
                                                   where university.Id == IdOfUniversity
                                                   select student;
            Console.WriteLine("List of Students from {0}:", IdOfUniversity);
            foreach (Student student in uniStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection: ");

            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }
    }
}
