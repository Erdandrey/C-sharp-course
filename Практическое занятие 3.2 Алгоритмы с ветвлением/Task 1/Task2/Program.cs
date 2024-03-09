using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату X первой точки");
            int X1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки");
            int Y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату X второй точки");
            int X2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки");
            int Y2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату X третьей точки");
            int X3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите координату Y третьей точки");
            int Y3 = Convert.ToInt16(Console.ReadLine());
            double AB = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double AC = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            if (AB < AC)
            {
                Console.WriteLine("Точка B расположена ближе к точке А. Расстояние между точками: {0}", AB);
            }
            else if (AB > AC)
            {
                Console.WriteLine("Точка C расположена ближе к точке А. Расстояние между точками: {0}", AC);
            }
            else 
            { 
                Console.WriteLine("Точки C и B расположены на одинаковом расстоянии от точки А. Это расстояние равно: {0}", AC);
            }
            Console.ReadKey();
        }
    }
}
