using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Задача1
{
    internal class Program
    {
        const int n = 10;
        static int[,] Garden = new int[n, n];
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++) // чтобы не заполнять вручную
            {
                for (int j = 0; j < n; j++)
                {
                    Garden[i, j] = 0;
                }
            }

            ThreadStart threadStart = new ThreadStart(Gardener1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardener2();

            for ( int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0} ", Garden[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Gardener1()
        {
            for ( int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    if (Garden[i, j] == 0)
                    {
                        Garden[i, j] = 1;
                    }
                    Thread.Sleep(10); //без задержки второй оказывался слишком шустрым)
                }
            }
        }

        static void Gardener2()
        {
            for (int i = n-1; i >= 0; i--)
            {
                for (int j = n-1; j >= 0; j--)
                {
                    if (Garden[j, i] == 0)
                    {
                        Garden[j, i] = 2;
                    }
                    Thread.Sleep(10);
                }
            }
        }
    }
}
