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
            Console.WriteLine("Введите коэффициенты линейного уравнения k и b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Linear lin = new Linear(k,b);
            Console.WriteLine(lin.Root());
            Console.ReadKey();
        }
    }
}
