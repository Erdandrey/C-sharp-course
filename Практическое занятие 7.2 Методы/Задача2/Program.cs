using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    internal class Program
    {
        static void GetCubeParams(int D, out int V,out int S)
        {
            V = D*D*D;
            S = 6*D*D;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int D = Convert.ToInt32(Console.ReadLine());
            int Square, Volume;
            GetCubeParams(D,out Volume,out Square);
            Console.WriteLine("Объём куба будет равен {0}, а площадь поверхности {1}", Volume, Square);
        }
    }
}
