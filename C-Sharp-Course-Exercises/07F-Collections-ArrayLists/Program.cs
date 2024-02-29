using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._07F_Collections_ArrayLists
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            
            // declaring an ArrayList with an undefined # of objects
            ArrayList myArrayList = new ArrayList(); 
            // declaring an ArrayList with a defined # of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.33);
            myArrayList.Add(13);

            // removes 1st element with a specific value (removes the number 13 from the array list)
            // note that it only removes one of the 13 values (there are 2 added in the ArrayList)
            myArrayList.Remove(13);

            // delete element at specific index position
            myArrayList.RemoveAt(0);  // removes item at index 0 which is 25

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if(obj is double) 
                {
                    sum += (double)obj;
                } else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
                
            }

            Console.WriteLine("Sum is {0}", sum);

        }
    }
}
