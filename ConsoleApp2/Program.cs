using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{




    class Program
    {
        static void Main()
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = int.Parse(Console.ReadLine());

            string season;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;
                default:
                    season = "Неверный номер месяца!";
                    break;
            }

            Console.WriteLine("Время года: " + season);
            Console.ReadKey();
        }
    }
}


   



class Program
{
    static void Main()
    {
        Console.Write("Введите первую букву предмета (ф, м, и, г, б): ");
        char letter = char.ToLower(Console.ReadKey().KeyChar); // Считываем символ с клавиатуры
        Console.WriteLine(); // Для новой строки

        string subject;
        switch (letter)
        {
            case 'ф': subject = "Физика"; break;
            case 'м': subject = "Математика"; break;
            case 'и': subject = "История"; break;
            case 'г': subject = "География"; break;
            case 'б': subject = "Биология"; break;
            default: subject = "Неизвестный предмет"; break;
        }

        Console.WriteLine("Название предмета: " + subject);
        Console.ReadKey();
    }
}
