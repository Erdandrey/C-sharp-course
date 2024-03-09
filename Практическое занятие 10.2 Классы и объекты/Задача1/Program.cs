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
            try
            {
                Angle An;
                do
                {
                    Console.WriteLine("Введите число градусов угла");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число минут угла");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите число секунд угла");
                    int s = Convert.ToInt32(Console.ReadLine());
                    An = new Angle(g, m, s);
                } while (An.flag == false);
                double r = An.ToRadians();
                Console.WriteLine("{0}  {1}   {2}", An.Gradus, An.Min, An.Sec); // проверка корректности перевода "излишних" минут и секунд
                Console.WriteLine("Значение угла в радианах: {0}", r);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }
    }
}
