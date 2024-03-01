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
            Console.WriteLine("Введите предложение");
            string Str = Console.ReadLine();
            string[] splited = Str.Split();
            string StrMax = "";
            foreach (string s in splited) 
            {
                if (s.Length > StrMax.Length)
                {
                    StrMax = s;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении: \"{0}\"", StrMax);
        }
    }
}
