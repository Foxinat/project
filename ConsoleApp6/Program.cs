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
    for (int i = 41; i <= 80; i += 10)
    {
        for (int j = i; j <= i + 9; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.ReadLine();
}
    }
}