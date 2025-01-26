using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
internal class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j <= 10; j++)
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