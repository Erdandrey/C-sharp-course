using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое положительное число B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое положительное число C");
            int C = Convert.ToInt32(Console.ReadLine());
            int count = 0, a=A, b=B;
            while (a >= C) 
            {
                a = a - C;
                b = B;
                while (b >= C)
                {
                    b = b - C;
                    count++;
                }
            }
            Console.WriteLine("В прямоугольнике со сторонами {0} на {1} поместится {2} квадратов стороной {3}",A,B,count,C);
            Console.ReadKey();
        }
    }
}
