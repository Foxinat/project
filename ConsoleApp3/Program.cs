using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = Math.Round(Func(5) + Func(12) + Func(19), 2);
            Console.WriteLine($"Результат: {result}");
            Console.ReadKey();
        }

        static double Func(int a) => (Math.Sqrt(a) + a) / 2;
    }
    }

