using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Sum is: {a + b}");
            Console.ReadKey();
        }
    }
}
