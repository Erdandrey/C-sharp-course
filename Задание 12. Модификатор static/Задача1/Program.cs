using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длина окружности {Circle.GetLength(r)}. Площадь круга {Circle.GetSquare(r)}.");
            Circle.BelongsToCircle(r, x, y, x0, y0 );
        }
    }
}
