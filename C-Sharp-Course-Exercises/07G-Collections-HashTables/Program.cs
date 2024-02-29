using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07G_Collections_HashTables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare empty hashtable
            Hashtable studentsTable = new Hashtable();

            // Create new student objects using our Student class defined below
            Student student1 = new Student(1, "Maria", 98);
            Student student2 = new Student(2, "Jason", 76);
            Student student3 = new Student(3, "Clara", 43);
            Student student4 = new Student(4, "Steve", 55);

            // add students to the students table - below we are using the students id as the "key" in
            // the hashtable.  And the "value" is the student object itself.
            // Using the Add method you will need to specify both key and value.
            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            // Retrieve a student by key
            Student storedStudent1 = (Student)studentsTable[student1.Id];
            Student storedStudent2 = (Student)studentsTable[student2.Id];

            Console.WriteLine("Student 1's Details - id: {0}, name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.WriteLine("Student 2's Details - id: {0}, name: {1}, GPA: {2}", storedStudent2.Id, storedStudent2.Name, storedStudent2.GPA);

            // Print all items in the hashtable - note that it starts at end and
            // ends at the beginning of the hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);
            }

            // Another way to do it by accessing Values directly
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA: {0}", value.GPA);
            }


            Console.ReadKey();
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
