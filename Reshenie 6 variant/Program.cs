using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reshenie_6_variant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            double x = rand.NextDouble(); 

            double y = rand.NextDouble() * 2 * Math.PI;

            double M = Math.Pow(Math.Cos(y), 2) + 3.6 * Math.Exp(x);

            Console.WriteLine($"Случайное значение x: {x}");

            Console.WriteLine($"Случайное значение y: {y}");

            Console.WriteLine($"Результат M = cos^2(y) + 3.6e^x: {M}");
        }
    }
}
