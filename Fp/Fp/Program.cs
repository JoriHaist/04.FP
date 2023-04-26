using System;


namespace Fp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = Sum(num1, num2);

            Console.WriteLine("The sum of {0} and {1} is {2},",num1, num2, sum);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
