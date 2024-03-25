using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задача1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            GetFactorialAsync(N);
            Console.ReadKey();
        }

        static void GetFactorial(int n) 
        {
            int S = 1;
            for (int i = 1; i < n+1; i++) 
            {
                S *= i;
                Thread.Sleep(20);
            }
            Console.WriteLine(S);
        }
        static async void GetFactorialAsync( int n)
        {
            await Task.Run(() => { GetFactorial(n); });
        }
    }
}
