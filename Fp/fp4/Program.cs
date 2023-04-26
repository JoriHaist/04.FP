using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the weight of the object");
            double objectWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of object: ");
            int objectCount = Convert.ToInt32(Console.ReadLine());

            double totalWeight = TotalWeight(objectWeight, objectCount);

            Console.WriteLine("The total weight of {0} object weighing {1} each is {2}", objectCount, objectWeight, totalWeight);
        }

        static double TotalWeight(double objectWeight, int objectCount )
        {
            return objectWeight * objectCount;
        }
    }
}
