using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._08C_Inheritance3
{
    internal class Program
    {
        static void Main(string[] args) {
            Post post1 = new Post("Thanks for the birthday wishes!", true, "Bill Stephens");
            Console.WriteLine(post1.ToString());
            

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Bill Stephens", true, "https://wwww.example.com/shoes");
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
