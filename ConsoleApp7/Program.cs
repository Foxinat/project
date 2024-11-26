using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");
            int d = Input("d = ");
            Console.WriteLine($"S = {Math.Max(a, b) + Math.Max(c, d)}");
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
