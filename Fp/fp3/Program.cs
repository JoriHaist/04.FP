using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of a side of the cube:");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double volume = CubeVolume(sideLength);

            Console.Write("The volume of the cume with side length {0} is {1}", sideLength, volume);
        }

        static double CubeVolume(double sideLength)
        {
            return Math.Pow(sideLength, 3);
        }
    }
}
