using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кейс
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу ");
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число от 1 до 5 ");
            string weight = Console.ReadLine();
            switch (weight)
            {
                case "1":
                    Console.WriteLine("Ваше число в киллограммах ", (number_a));
                 break;
                case "2":
                     Console.WriteLine("Ваше число в киллограммах ", (number_a * 1000000));
                    break;
                case "3":
                    Console.WriteLine(("Ваше число в киллограммах ", number_a * 1000));
                    break;
                case "4":
                    Console.WriteLine("Ваше число в киллограммах ", (number_a / 1000));
                    break;
                case "5":
                    Console.WriteLine("Ваше число в киллограммах ", (number_a / 100));
                    break;
                default:
                    Console.WriteLine("Такая операция не предусмотрена");
                    break;



            }
            Console.ReadKey();

        }
    }
}
