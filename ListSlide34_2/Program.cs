using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSlide34_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of true-false
            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            // Go through each to decide true-false
            foreach (bool element in boolList)
            {
                if (element == true)
                {
                    // Print out for true
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    // Print out for false
                    Console.WriteLine("No rain today, enjoy the sunshine!");
                }
            }
        }
    }
}
