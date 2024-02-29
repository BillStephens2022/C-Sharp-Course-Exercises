using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07D_Collections_ArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);
            Console.WriteLine("The average of the students' grades is {0}", averageResult);

            foreach (int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            int[] adjustedStudentGrades = CurveBump(studentsGrades);
            foreach (int grade in adjustedStudentGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double) sum / size;

            return average;
        }

        // adds 2 points to each students score
        static int[] CurveBump(int[] gradesArray)
        {
            for (int i = 0; i < gradesArray.Length; i++)
            {
                gradesArray[i] = gradesArray[i] + 2;
            }

            return gradesArray;
        }
    }
}
