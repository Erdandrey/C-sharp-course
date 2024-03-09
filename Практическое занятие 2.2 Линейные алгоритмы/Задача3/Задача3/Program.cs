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
            double X1, X2, X3, Y1, Y2, Y3, P, p, S, a, b, c;
            Console.WriteLine("Ввведите координату X первой точки ");
            X1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввведите координату Y первой точки ");
            Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввведите координату X второй точки ");
            X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввведите координату Y второй точки ");
            Y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввведите координату X третьей точки ");
            X3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ввведите координату Y третьей точки ");
            Y3 = double.Parse(Console.ReadLine());
            a = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            b = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
            c = Math.Sqrt(Math.Pow(X2 - X3, 2) + Math.Pow(Y2 - Y3, 2));
            P = a + b + c;
            p = P / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Периметр треугольника равен P={0}. Площадь треугольника равен S={1}", P, S);
            Console.ReadKey();
        }
    }
}
