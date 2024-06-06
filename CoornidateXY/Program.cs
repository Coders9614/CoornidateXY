using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoornidateXY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the axes.");
            }
            Console.ReadKey();
        }
    }
}
