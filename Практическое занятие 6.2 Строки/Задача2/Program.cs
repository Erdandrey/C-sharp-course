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
            Console.WriteLine("Введите предложение");
            string Str = Console.ReadLine();
            string StrReversed = "";
            string StrNoSpace = "";
            string[] rr = Str.Split();
            foreach (string s in rr)
            {
                StrNoSpace += s;
            }
            foreach (char s in StrNoSpace)
            {
                StrReversed = s+StrReversed;
            }
            if (StrNoSpace.ToLower()== StrReversed.ToLower())
            {
                Console.WriteLine("Это строка-палиндром!");
            }
            else
            {
                Console.WriteLine("Это не строка-палиндром!");
            }
            Console.ReadKey();
        }
    }
}
