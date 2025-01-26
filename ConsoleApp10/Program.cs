using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
static void Main(string[] args)
{
    for (int i = 0; i < 16; i++)
    {
        Console.Write("#");
    }
    for (int i = 0; i < 16 - 2; i++)
    {
        Console.Write("#");
        for (int j = 0; j < 16 - 2; j++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("#");
    }
    for (int i = 0; i < 16; i++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
    Console.ReadLine();

}
    }
}
