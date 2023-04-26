using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double perimeter = CirclePerimeter(radius);

            Console.WriteLine("The perimeter of the circle with radius {0} is {1}", radius, perimeter);
        }

        static double CirclePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
