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
            int X1, X2, Y1, Y2, P, S;
            Console.WriteLine("Введите координату Х первой вершины прямоугольника X1:");
            X1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой вершины прямоугольника Y1:");
            Y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Х второй вершины прямоугольника X2:");
            X2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй вершины прямоугольника Y2:");
            Y2 = Convert.ToInt16(Console.ReadLine());
            P = 2 * Math.Abs(X1 - X2) + 2 * Math.Abs(Y1 - Y2);
            S = Math.Abs(X1 - X2) * Math.Abs(Y1 - Y2);
            Console.WriteLine("Периметр прямоугольника равен P={0}. Площадь прямоугольника равна S={1}", P,S);
        }
    }
}
