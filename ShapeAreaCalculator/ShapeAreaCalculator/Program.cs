using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape area you want to calculate?\nEnter 'r' for rectangle or other key for circle");
            answer= Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Enter the height of rectangle...");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of rectangle...");
                float width = float.Parse(Console.ReadLine());
                result = height * width;
            }
            else
            {
                Console.WriteLine("Enter the radius of rectangle...");
                float radius = float.Parse(Console.ReadLine());
                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadKey(); //the app will not close until user inputs
        }
    }
}
