﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {


        static void Main()
        {
            Console.Write("Введите признак транспортного средства (а, в, м, с, п): ");
            char transport = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            string maxSpeed;
            switch (transport)
            {
                case 'а': maxSpeed = "Автомобиль: до 200 км/ч"; break;
                case 'в': maxSpeed = "Велосипед: до 50 км/ч"; break;
                case 'м': maxSpeed = "Мотоцикл: до 250 км/ч"; break;
                case 'с': maxSpeed = "Самолет: до 900 км/ч"; break;
                case 'п': maxSpeed = "Поезд: до 300 км/ч"; break;
                default: maxSpeed = "Неизвестное транспортное средство"; break;
            }

            Console.WriteLine("Максимальная скорость: " + maxSpeed);
            Console.ReadKey();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите признак фигуры (к - круг, п - прямоугольник, т - треугольник): ");
        char shape = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (shape)
        {
            case 'к':
                Console.Write("Введите радиус круга: ");
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                double circlePerimeter = 2 * Math.PI * radius;
                Console.WriteLine($"Площадь круга: {circleArea:F2}, Периметр: {circlePerimeter:F2}");
                break;

            case 'п':
                Console.Write("Введите длину прямоугольника: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Введите ширину прямоугольника: ");
                double width = double.Parse(Console.ReadLine());
                double rectangleArea = length * width;
                double rectanglePerimeter = 2 * (length + width);
                Console.WriteLine($"Площадь прямоугольника: {rectangleArea:F2}, Периметр: {rectanglePerimeter:F2}");
                break;

            case 'т':
                Console.Write("Введите стороны треугольника (через пробел): ");
                string[] sides = Console.ReadLine().Split();
                double a = double.Parse(sides[0]);
                double b = double.Parse(sides[1]);
                double c = double.Parse(sides[2]);
                double semiPerimeter = (a + b + c) / 2;
                double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
                double trianglePerimeter = a + b + c;
                Console.WriteLine($"Площадь треугольника: {triangleArea:F2}, Периметр: {trianglePerimeter:F2}");
                break;

            default:
                Console.WriteLine("Неизвестная фигура.");
                break;
        }

        Console.ReadKey();
    }
}






