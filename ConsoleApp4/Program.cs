using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"x = {Math.Round(Func(5, 7) + Func(12, 8) + Func(19, 2))}");
            Console.ReadKey();
        }

        static double Func(int a, int b) => Math.Sqrt(a) + a / Math.Sqrt(b) + b;
    }
    }
}
