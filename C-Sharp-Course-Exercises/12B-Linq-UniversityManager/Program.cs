using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._12B_Linq_UniversityManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.ShowMaleStudents();

            um.ShowFemaleStudents();

            um.SortStudentsByAge();

            um.AllStudentsFromRutgers();

            Console.Write("Enter a university Id to get students at that university: ");
            string input = Console.ReadLine();  
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.ShowStudentsByUniversity(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter an valid university Id (integer)!");
            }
            
   
        }
    }

}
