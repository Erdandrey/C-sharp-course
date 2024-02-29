using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите целое положительное число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[N, N];
            int t=0;
            for (int i = 0; i < N; i++) 
            {
                if (i % 2 == 0)
                {
                    t = 1;
                }
                else 
                {
                    t = 0; 
                }
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = t;
                    Console.Write("{0} ", arr[i,j]);
                    if (t == 0)
                    {
                        t = 1;
                    }
                    else
                    {
                        t = 0;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
