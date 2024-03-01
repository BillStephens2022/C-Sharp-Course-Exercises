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

            VideoPost videoPost1 = new VideoPost("Embarassing Video (for some) from Company Christmas Party!", "TroubleMaker", true, "https://www.video.com/troublemaker", 42);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
