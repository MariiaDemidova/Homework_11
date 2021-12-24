using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    class Program
    {
        static void Main(string[] args)
        {
            FindX solve = new FindX();
            Console.WriteLine("Введите коэффициент b для уравнения 0=kx+b");
            solve.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент k для уравнения 0=kx+b");
            solve.k = Convert.ToDouble(Console.ReadLine());
            solve.Root();
            Console.ReadKey();
        }
        struct FindX
        {
            public double b;
            public double k;
            public void Root ()
            {
                if (b == 0 && k == 0)
                {
                    Console.WriteLine("Корень уравнения имеет бесконечное множество значений");
                }
                else if (k == 0)
                {
                    Console.WriteLine("Недопустимое значение k");
                }
                else 
                {
                    double x = -b / k;
                    Console.WriteLine("Корень уравнения = {0}", x);
                }
            }
        }
    }
}

