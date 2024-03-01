using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        static double GetSquare(int x, int y, int z)
        {
            double PP = ((double)x + y + z) / 2;
            return Math.Sqrt(PP * (PP - x) * (PP - y) * (PP - z));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S1 = GetSquare(a1, b1, c1);
            double S2 = GetSquare(a2, b2, c2);
            if (S1 > S2) 
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if ((S1 < S2))
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
        }
    }
}
