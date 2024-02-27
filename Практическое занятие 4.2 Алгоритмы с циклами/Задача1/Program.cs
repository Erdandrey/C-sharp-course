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
            Console.WriteLine("Введите целое число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int S = 0;
            for (int i = 1; i <= N; i++)
            {
                S += 2 * i - 1;
                Console.WriteLine("{0} - {1}", i, S);
            }
        }
    }
}
