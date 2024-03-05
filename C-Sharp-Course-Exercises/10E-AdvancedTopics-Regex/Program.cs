using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Course_Exercises._10E_AdvancedTopics_Regex
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            string pattern = @"\d"; // to find all digit
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 1234321";

            MatchCollection matchCollection = regex.Matches(text);

            // below should show 7 hits since 7 digits in the string text.
            Console.WriteLine("{0} hits found: \n {1}", matchCollection.Count, text);

            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at: {1}", group[0].Value, group[0].Index);
            }
        }
    }
}
