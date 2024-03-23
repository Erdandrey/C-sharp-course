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
            ArithProgression a = new ArithProgression();
            a.SetStart(15);
            a.SetStep(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a.GetNext());
            }
            a.Reset();
            Console.WriteLine(a.GetNext());
            Console.WriteLine(a.GetNext());
            GeomProgression b = new GeomProgression();
            b.SetStart(1);
            b.SetStep(3);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(b.GetNext());
            }
            b.Reset();
            Console.WriteLine(b.GetNext());
            Console.WriteLine(b.GetNext());
            Console.ReadKey();
        }
    }
}
