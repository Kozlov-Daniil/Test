using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оператор_выбора
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите значение k от 0 до 2");
            double number_k = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите а");
            double number_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double number_b = double.Parse(Console.ReadLine());


            if (number_k > 2)
            {
                Console.WriteLine("Такая операция не предусмотрена");
            }
            else if (number_k == 0)
            {

                Console.WriteLine("Если k=0, то  {0}",
                Math.Log(number_a / number_b));
            }
            else if (number_k == 1)
            {
                double number_e = 2.71;

                Console.WriteLine("Если k=1, то{0}",
                    Math.Pow(number_e, number_a * number_b));
            }
            else if (number_k == 2)
            {
                Console.WriteLine("Введите с");
                double number_c = int.Parse(Console.ReadLine());
                Console.WriteLine("Если k=2, то{0}",
                    Math.Sqrt(Math.Abs(Math.Pow(number_a + number_b, 3) + number_c)));
            }

            Console.ReadKey();
        }
    }
}
