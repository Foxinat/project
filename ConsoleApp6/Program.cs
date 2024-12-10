using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Input("a = ");
            int number2 = Input("b = ");
            int number3 = Input("c = ");
            Console.WriteLine($"Наибольшее число = {Math.Max(Math.Max(number1, number2), number3)}");
            Console.ReadKey();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
