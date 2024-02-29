using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random R = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(-50, 50);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length/2-1; i++)
            {
                for (int j = i+1; j < arr.Length/2; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            for (int i = arr.Length / 2; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i==5) { Console.Write("| "); }
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
