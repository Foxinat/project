using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
    
static void Main(string[] args)
{

    for (int i = 1; i < 5; i++)
    {
        for (int j = 1; j <= 15; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }
    Console.Read();
}
    }
}