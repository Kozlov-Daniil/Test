using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_шарп__2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Формула 1+1/2+1/3+...+1/N
            int a, n;
            n = int.Parse(Console.ReadLine());
            double b=0 , c;
            for (a = 1; a < n; a++);
            {
                b += 1 / a;
            }
            Console.WriteLine("Ответ=" + b);
            Console.ReadKey();
        }
    }
}
