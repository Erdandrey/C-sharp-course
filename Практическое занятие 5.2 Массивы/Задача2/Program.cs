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
            int[] arr = new int[15];
            Random R= new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(0,50);
                Console.Write("{0} ",arr[i]);
            }
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
               if (arr[i] < min)
                {
                    min = arr[i];
                }
               if (arr[i] > max) 
                { 
                    max = arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Минимальное значение в массиве: {0}. Максимальное значение в массиве: {1}", min, max);
            Console.ReadKey();
        }
    }
}
