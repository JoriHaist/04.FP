using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of miles driven:");
            double milesDriven = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the price of gasoline per gallon:");
            double pricePerGallon = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fuel efficiency in miles per gallon:");
            double milesPerGallon = Convert.ToDouble(Console.ReadLine());

            double fuelCost = FuelCost(milesDriven, pricePerGallon, milesPerGallon);

            Console.WriteLine("The cost of driving {0} miles at {1} miles per gallon with gasoline priced at {2} per gallon is {3}", milesDriven, milesPerGallon, pricePerGallon, fuelCost);
        }

        static double FuelCost(double milesDriven, double pricePerGallon, double milesPerGallon)
        {
            double gallonsUsed = milesDriven / milesPerGallon;
            return gallonsUsed * pricePerGallon;
        }
    }
}
