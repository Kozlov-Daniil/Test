using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_шарп__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма чисел от -12 до -65 ");
            int a = -12;
            int sum = 0;
            int b = -65;
            int c = 0;
            while (a>-65)
            {
                sum = sum + a;
                a--;
                b++;
               
            }
            Console.WriteLine(sum);


            
            Console.WriteLine("Среднее арифметическое от -12 до -65");
            Console.WriteLine(c-=sum/b);

            Console.ReadKey();
        }
    }
}
