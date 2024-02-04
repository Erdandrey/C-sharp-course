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
            double L, R, S;
            Console.WriteLine("Введите длину окружности:");
            L = Convert.ToDouble(Console.ReadLine());
            R = L / (2 * Math.PI);
            S= Math.Pow(L,2) / (4 * Math.PI);
            Console.WriteLine("Радиус окружности: {0}, площадь круга: {1}", R,S);


        }
    }
}
