using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        delegate double MyDelegate(double value);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = RoundLength;
            double answer = myDelegate(1);
            Console.WriteLine("Длина окружности");
            Console.WriteLine("{0:f3}", answer);

            myDelegate = RoundSquare;
            answer = myDelegate(1);
            Console.WriteLine("Площадь круга");
            Console.WriteLine("{0:f3}", answer);

            myDelegate = RoundVolume;
            answer = myDelegate(1);
            Console.WriteLine("Объём шара");
            Console.WriteLine("{0:f3}",answer);

            Console.ReadKey();
        }

        static double RoundLength(double R) => 2 * R * Math.PI;
        static double RoundSquare(double R) => R * R * Math.PI;
        static double RoundVolume(double R) => (4.0 / 3) * R * R * R * Math.PI;
    }
}
