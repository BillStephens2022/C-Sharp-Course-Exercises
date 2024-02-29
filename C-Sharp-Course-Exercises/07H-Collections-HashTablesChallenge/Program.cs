using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07H_Collections_HashTablesChallenge
{
    /* Write a program that will iterate through each element of the students array and insert them 
      into a hashtable.  If a student with the same ID already exists, skip it and display the following
      error:
      "Sorry, a Student with the same ID already exists".
      Hint: use the method ContainsKey() to check whether a student with the same already exists
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();

            foreach(Student student in students)
            {
                if (studentsTable.ContainsKey(student.Id)) {
                    Console.WriteLine("***ERROR*** Sorry, student with name: {0} and id of {1} could not be added. ID already exists!", student.Name, student.Id);
                } else
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine("Student with name: {0} and id of {1} added!", student.Name, student.Id);
                } 
            }

            Console.WriteLine("================PRINTING THE STUDENTS HASH TABLE=========================");

            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}, Student Name: {1}, Student GPA: {2}", student.Name, student.Id, student.GPA);
            }
        }

        class Student
        {
            // Properties
            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }

            // Constructor
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;

            }
        }
    }
}
