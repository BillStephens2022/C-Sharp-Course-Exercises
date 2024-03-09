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
            int[] someInts = { 30, 12, 4, 3, 12 };
            // sort
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            // reverse sort
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            // another way to reverse sort
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

        }
    }

}
