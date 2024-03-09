using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neg = 0, pos = 0, count = 0, N = 0;
            Console.WriteLine("Вводите целые числа ");
            do
            {
                N = Convert.ToInt32(Console.ReadLine());

                if (N < 0)
                {
                    neg++; count++;
                } else if (N > 0)
                {
                    pos++; count++;
                }
            } while (N != 0);
            Console.WriteLine("Введено {0} чисел. Отрицательных - {1}. Положительных - {2}.", count, neg, pos);
            if (neg > pos)
            {
                Console.WriteLine("Отрицательных больше.");
            } else if (pos > neg )
            {
                Console.WriteLine("Положительных больше.");
            } else 
            {
                Console.WriteLine("Отрицательных и положительных чисел введено одинаковое количество.");
            }
            Console.ReadKey();
        }
    }
}
